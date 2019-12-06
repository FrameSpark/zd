using Railway.Forms;
using Railway.GuestModels;
using Railway.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace Railway
{
    class DataBase
    {
       public Context db;
        public DataBase()
        {
            db = new Context();
        }

        public List<TrainsGuest> searchTrain(String need_type, String station)
        {
            //id train, Номер поезда, start, finish, type, time
            List<TrainsGuest> response = new List<TrainsGuest>();
            List<Train> trains = GetTrains();
            List<Train> edit = new List<Train>();
            if (trains != null)
            {
                //Первый фильтр по типу поезда
                
                    foreach (Train temp in trains)
                    {
                        
                        if (temp.typeTrain == need_type || need_type == "Все")
                            edit.Add(temp);
                    }
                

                //Фильтр по станциям
                if(edit.Count != 0) {
                    foreach (Train temp in edit)
                    {
                        if (getTripByTrain(temp.id).Count >0)
                        {
                            if (getTripByTrain(temp.id).First<TRIP>().status == "Не начат")
                            {
                                List<TripRoutes> tr = GetTripRoutesbyTrip(getTripByTrain(temp.id).FirstOrDefault<TRIP>().id_trip);
                                foreach (TripRoutes r in tr)
                                {
                                    if (getStationById(getRouteById(r.IdRoute).id_start_station).name_station == station ||
                                        getStationById(getRouteById(r.IdRoute).id_finish_station).name_station == station)
                                    {
                                        TrainsGuest goodTrain = new TrainsGuest();
                                        goodTrain.id_train = temp.id;
                                        goodTrain.number_train = temp.numberTrain;
                                        List<String> st = getStationsByTrip(getTripByTrain(temp.id).First<TRIP>().id_trip);
                                        goodTrain.start = st.First<String>();
                                        goodTrain.finish = st.Last<String>();
                                        goodTrain.type = temp.typeTrain;
                                        goodTrain.time = getTimeForTrip(getTripByTrain(temp.id).First<TRIP>().id_trip) / 60;
                                        response.Add(goodTrain);
                                        goodTrain.time_start = getTripByTrain(temp.id).LastOrDefault<TRIP>().time_start;
                                        goodTrain.time_fiinish = getTripByTrain(temp.id).LastOrDefault<TRIP>().time_finish;
                                        break;
                                    }



                                }
                            }
                        }
                    }
                }
                
            }
            return response;
           


        }

        public int getTimeForTrip(int trip)
        {
            List<TripRoutes> tr = GetTripRoutesbyTrip(trip);
            int time = 0;
            foreach(TripRoutes t in tr)
            {
                time += getRouteById(t.IdRoute).route_time;
                
            }
            return time;
        }
        public List<TripRoutes> GetTripRoutes()
        {
            return db.TripRoutes.ToList();
        }

        public List<TripRoutes> GetTripRoutesbyTrip(int id)
        {
            List<TripRoutes> list = GetTripRoutes();
            List<TripRoutes> temp = new List<TripRoutes>();
            foreach (TripRoutes t in list)
            {
                if (t.IdTrip == id)
                    temp.Add(t);
            }
            return temp;
        }

        public List<String> getStationsByTrip(int id)
        {
            
            List<String> response = new List<String>();
            deleteRetryTripRoutes();
            List<Route> routes = getRoutebyTrip(id);
            Route start=null, finish=null;
            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_start_station == temp2.name_finish_station || temp.name_start_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    start = temp;
                    break;
                }
            }

            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_finish_station == temp2.name_finish_station || temp.name_finish_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    finish = temp;
                    break;
                }
            }
            try
            {
                response.Add(start.name_start_station);

                response.Add(finish.name_finish_station);

            }
            catch
            {
                response.Add("Ошибка");

                response.Add("Ошибка");
            }
            return response;

        }

        public List<Carriage> GetCarriages()
        {
            List<Carriage> carriages = new List<Carriage>();
            List<CARRIAGE> CARRIAGEs = db.CARRIAGEs.ToList();
            List<CARRIAGE_TYPE> CARRIAGE_TYPEs = db.CARRIAGE_TYPE.ToList();
            foreach(CARRIAGE temp in CARRIAGEs)
            {
                CARRIAGE_TYPE type = CARRIAGE_TYPEs.Where(t => t.id_carriage == temp.id_carriage).ToList().FirstOrDefault();
                Carriage tempCarriage = new Carriage();
                tempCarriage.id_carriage = temp.id_carriage;
                tempCarriage.number_of_seats = temp.number_of_seats;
                tempCarriage.type_carriage = type.type_carriage;
                carriages.Add(tempCarriage);
            }
            return carriages;
        }

        public List<PASSANGER> GetPASSANGERs()
        {
            return db.PASSANGERs.ToList();
        }

        public List<PASSANGER> GetPASSANGERs(String role)
        {
           
            int r=4;
            if (role == "Все")
                r = 4;
            if (role == "Админ")
                r = 1;
            if (role == "Пассажиры")
                r = 0;
            if (role == "Начальники поезда")
                r = 3;
            List<PASSANGER> pas = new List<PASSANGER>();
            foreach(PASSANGER p in db.PASSANGERs.ToList())
            {
                if(r==4)
                {
                    pas.Add(p);
                }

                else
                {
                    if (p.is_admin == r)
                        pas.Add(p);
                }
            }
            return pas;
        }

        public List<PASSANGER> GetPASSANGERsOnly()
        {
            List<PASSANGER> list = GetPASSANGERs();
            List<PASSANGER> response = new List<PASSANGER>();
            foreach(PASSANGER p in list)
            {
                if (p.is_admin == 0)
                    response.Add(p);
            }
            return response;
        }

        public List<Composition> GetComposition()
        {
            List<Composition> compositions = new List<Composition>();

            List<TRAIN_COMPOSITION> tc = db.TRAIN_COMPOSITION.ToList();
            
            foreach (TRAIN_COMPOSITION temp in tc)
            {
                Composition composition = new Composition();
                composition.id_carriage = temp.id_carriage;
                composition.id_composition = temp.id_composition;
                composition.number_train = getTrainById(temp.id_train).number_train;
                composition.type_carriage = getCarriageTypeById(temp.id_carriage).type_carriage;
                compositions.Add(composition);
            }
            return compositions;
        }
        public List<Train> GetTrains()
        {
            List<Train> train = new List<Train>();
            List<TRAIN> db_trains = db.TRAINs.ToList();
            List<TRAIN_TYPE> db_type = db.TRAIN_TYPE.ToList();
            foreach (TRAIN temp in db_trains)
            {
                List<TRAIN_TYPE> type = db_type.Where(t => t.id_train == temp.id_train).ToList();
                Train tempTrain = new Train();
                tempTrain.id = temp.id_train;
                tempTrain.numberTrain = temp.number_train;
                tempTrain.typeTrain = type.Last().type_train;
                train.Add(tempTrain);
            }
            return train;
        }

        public List<Train> GetTrainsWithoutTrip(string ts)
        {
            List<Train> train = new List<Train>();
            List<TRAIN> db_trains = db.TRAINs.ToList();
            List<TRAIN_TYPE> db_type = db.TRAIN_TYPE.ToList();
            foreach (TRAIN temp in db_trains)
            {
                if (getTripByTrain(temp.id_train).Count == 0)
                {
                    List<TRAIN_TYPE> type = db_type.Where(t => t.id_train == temp.id_train).ToList();
                    Train tempTrain = new Train();
                    tempTrain.id = temp.id_train;
                    tempTrain.numberTrain = temp.number_train;
                    tempTrain.typeTrain = type.Last().type_train;
                    train.Add(tempTrain);
                }
            }
            if (ts != null)
            {
                TRAIN tT = getTrainById(getIdTrainByNumber(ts));
                Train tr = new Train();
                tr.id = tT.id_train;
                tr.numberTrain = tT.number_train;
                List<TRAIN_TYPE> type1 = db_type.Where(t1 => t1.id_train == tT.id_train).ToList();
                tr.typeTrain = type1.Last().type_train;
                train.Add(tr);
            }
            return train;
        }

        public List<TRAIN> GetTrainsWithTrip()
        {
            List<TRAIN> train = new List<TRAIN>();
            List<TRAIN> db_trains = db.TRAINs.ToList();

            foreach (TRAIN temp in db_trains)
            {
                if (getTripByTrain(temp.id_train).Count != 0)
                {
                    
                    TRAIN tempTrain = new TRAIN();
                    tempTrain.id_train = temp.id_train;
                    tempTrain.number_train = temp.number_train;
                    
                    train.Add(tempTrain);
                }
            }
            return train;
        }

        public List<Train> GetTrainsNumberWithCarriage()
        {
            List<Train> train = new List<Train>();
            
            List<TRAIN> db_trains = db.TRAINs.ToList();
            List<TRAIN_TYPE> db_type = db.TRAIN_TYPE.ToList();
            Train tr = new Train();
            tr.numberTrain = "Все";
            train.Add(tr);
            foreach (TRAIN temp in db_trains)
            {
                List<TRAIN_TYPE> type = db_type.Where(t => t.id_train == temp.id_train).ToList();
                Train tempTrain = new Train();
                tempTrain.id = temp.id_train;
                tempTrain.numberTrain = temp.number_train;
                tempTrain.typeTrain = type.Last().type_train;
                if(getCompositionByTrain(tempTrain.id).Count > 0)
                 train.Add(tempTrain);
            }
            return train;
        }

        public List<Train> GetTrainsNumber()
        {
            List<Train> train = new List<Train>();
            List<TRAIN> db_trains = db.TRAINs.ToList();
            List<TRAIN_TYPE> db_type = db.TRAIN_TYPE.ToList();
            Train tr = new Train();
            tr.numberTrain = "Все";
            train.Add(tr);
            foreach (TRAIN temp in db_trains)
            {
                List<TRAIN_TYPE> type = db_type.Where(t => t.id_train == temp.id_train).ToList();
                Train tempTrain = new Train();
                tempTrain.id = temp.id_train;
                tempTrain.numberTrain = temp.number_train;
                tempTrain.typeTrain = type.Last().type_train;
                train.Add(tempTrain);
            }
            return train;
        }

        public List<STATION> GetStations()
        {
            List<STATION> db_stations = db.STATIONs.ToList();
            return db_stations;
        }

        public STATION getStationById(int id)
        {

            List<STATION> db_station = db.STATIONs.ToList();
            foreach (STATION temp in db_station)
            {
                if (temp.id_station == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public STATION getStationByName(string name)
        {

            List<STATION> db_station = db.STATIONs.ToList();
            foreach (STATION temp in db_station)
            {
                if (temp.name_station == name)
                {
                    return temp;
                }
            }
            return null;
        }

        public TRAIN getTrainById(int id)
        {
           
            List<TRAIN> db_trains = db.TRAINs.ToList();
            foreach (TRAIN temp in db_trains)
            {
                if (temp.id_train == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public CARRIAGE getCarriageById(int id)
        {

            List<CARRIAGE> db_carriage = db.CARRIAGEs.ToList();
            foreach (CARRIAGE temp in db_carriage)
            {
                if (temp.id_carriage == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public TRAIN_TYPE getTrainTypeById(int id)
        {
           
            List<TRAIN_TYPE> db_type = db.TRAIN_TYPE.ToList();
            foreach (TRAIN_TYPE temp in db_type)
            {
                if (temp.id_train == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public CARRIAGE_TYPE getCarriageTypeById(int id)
        {

            List<CARRIAGE_TYPE> db_type = db.CARRIAGE_TYPE.ToList();
            foreach (CARRIAGE_TYPE temp in db_type)
            {
                if (temp.id_carriage == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public List<TRAIN_COMPOSITION> getCompositionByTrain(int id)
        {

            List<TRAIN_COMPOSITION> db_type = db.TRAIN_COMPOSITION.ToList();
            List<TRAIN_COMPOSITION> list = new List<TRAIN_COMPOSITION>();
            foreach (TRAIN_COMPOSITION temp in db_type)
            {
                if (temp.id_train == id)
                {
                    list.Add(temp);
                }
            }
            return list;
        }

        public List<Composition> getCompositionByTrain(String id)
        {
            List<Composition> compositions = new List<Composition>();

            List<TRAIN_COMPOSITION> tc = db.TRAIN_COMPOSITION.ToList();
            if (id != "Все")
            {
                foreach (TRAIN_COMPOSITION temp in tc)
                {
                    if (temp.TRAIN.number_train == id)
                    {
                        Composition composition = new Composition();
                        composition.id_carriage = temp.id_carriage;
                        composition.id_composition = temp.id_composition;
                        composition.number_train = getTrainById(temp.id_train).number_train;
                        composition.type_carriage = getCarriageTypeById(temp.id_carriage).type_carriage;
                        compositions.Add(composition);
                    }
                }
            }
            else
            {
                foreach (TRAIN_COMPOSITION temp in tc)
                {
                  
                        Composition composition = new Composition();
                        composition.id_carriage = temp.id_carriage;
                        composition.id_composition = temp.id_composition;
                        composition.number_train = getTrainById(temp.id_train).number_train;
                        composition.type_carriage = getCarriageTypeById(temp.id_carriage).type_carriage;
                        compositions.Add(composition);
                    
                }
            }
            return compositions;

        }

        public TRAIN_COMPOSITION getComposition(int id)
        {

            List<TRAIN_COMPOSITION> db_type = db.TRAIN_COMPOSITION.ToList();
            foreach (TRAIN_COMPOSITION temp in db_type)
            {
                if (temp.id_composition == id)
                {
                    return temp;
                }
            }
            return null;
        }
        public TRIP getTripById(int id)
        {

            List<TRIP> db_type = db.TRIPs.ToList();
            foreach (TRIP temp in db_type)
            {
                if (temp.id_trip == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public int getFreeTicket(int train)
        {
            int seat = 0;
            List<TRAIN_COMPOSITION> tc = getCompositionByTrain(train);
            List<TICKET> pas = db.TICKETs.ToList();
            foreach(TRAIN_COMPOSITION temp in tc)
            {
                seat += getCarriageById(temp.id_carriage).number_of_seats;
            }
            foreach(TICKET temp in pas)
            {
                if (temp.id_train == train)
                    seat -= 1;
            }
            return seat;
        }

        public List<TRIP> getTripByTrain(int id)
        {
            
            List<TRIP> db_type = db.TRIPs.ToList();
            List<TRIP> t = new List<TRIP>();
            foreach (TRIP temp in db_type)
            {
                if (temp.id_train == id)
                {
                    t.Add(temp);
                }
            }
            return t;
        }

        public ROUTE getRouteById(int id)
        {

            List<ROUTE> db_type = db.ROUTEs.ToList();
            foreach (ROUTE temp in db_type)
            {
                if (temp.id_route == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public List<Route> getRoute()
        {
            List<ROUTE> db_type = db.ROUTEs.ToList();
            List<Route> route = new List<Route>();
            foreach(ROUTE temp in db_type)
            {
                Route r = new Route();
                r.id_route = temp.id_route;
                r.name_start_station =getStationById(temp.id_start_station).name_station;
                r.name_finish_station = getStationById(temp.id_finish_station).name_station;
                r.route_time = temp.route_time;
                r.route = r.name_start_station + " - " + r.name_finish_station + " (" + r.route_time + ")";
                route.Add(r);
            }
            return route;
        }

        public void deleteRetryTripRoutes()
        {
            List<TripRoutes> tr = GetTripRoutes();
            List<TripRoutes> tr2 = GetTripRoutes();
            try
            {
                for(int i=0; i<tr.Count; i++)
                {
                    for(int j = i + 1; j < tr.Count; j++)
                    {
                        if(tr[i].idTR != tr[j].idTR && tr[i].IdRoute == tr[j].IdRoute && tr[i].IdTrip == tr[j].IdTrip)
                        {
                            deleteTripRoutes(tr[j].idTR);
                        }
                    }
                }
            
            }
            catch
            {

            }
        }
        public List<Route> getRoutebyTrip(int id_trip)
        {
            List<ROUTE> db_type = db.ROUTEs.ToList();
            List<Route> route = new List<Route>();
            deleteRetryTripRoutes();
            List<TripRoutes> tr = GetTripRoutes();
            foreach(TripRoutes t in tr)
            {
                if(t.IdTrip == id_trip)
                {
                    ROUTE temp = getRouteById(t.IdRoute);
                    Route r = new Route();
                    try
                    {
                        r.id_route = temp.id_route;
                        r.name_start_station = getStationById(temp.id_start_station).name_station;
                        r.name_finish_station = getStationById(temp.id_finish_station).name_station;
                        r.route_time = temp.route_time;
                        r.route = r.name_start_station + " - " + r.name_finish_station;
                        route.Add(r);
                    }
                    catch
                    {

                    }
                }
            }
           
            return route;
        }


        public List<Trip> getTrip()
        {
            
            List<TRIP> list = db.TRIPs.ToList();
            foreach (TRIP temp in list)
            {
                if (temp.time_start < DateTime.Now && DateTime.Now < temp.time_finish)
                {
                    temp.status = "В пути";
                }
                if (temp.time_start > DateTime.Now)
                {
                    temp.status = "Не начат";
                }
                if (DateTime.Now > temp.time_finish)
                {
                    temp.status = "Окончен";
                }
            }
            List<Trip> trip = new List<Trip>();
            foreach (TRIP temp in list)
            {
                Trip t = new Trip();
                t.id_route = temp.id_route;
                t.id_train = temp.id_train;
                t.id_trip = temp.id_trip;
                t.status = temp.status;
                t.time_start = temp.time_start;
                t.time_finish = temp.time_finish;
                t.number_train = getTrainById(temp.id_train).number_train;
                List<String> st = getStationsByTrip(t.id_trip);
                if (st.Last<String>() == "Отсутствует" || st.First<String>() == "Отсутствует")
                {
                    MessageBox.Show("У рейса нет маршрутов, мы вынуждены его удалить");
                    db.TRIPs.Remove(temp);
                    db.SaveChanges();
                }
                else
                {
                    t.start_station = st.First<String>();
                    t.finish_station = st.Last<String>();
                    trip.Add(t);
                }
            }
            return trip;
        }

        public List<Train> GetTrainsByType(String need_type)
        {
            List<Train> train = new List<Train>();
            List<TRAIN> db_trains = db.TRAINs.ToList();
            List<TRAIN_TYPE> db_type = db.TRAIN_TYPE.ToList();
            foreach (TRAIN temp in db_trains)
            {
                List<TRAIN_TYPE> type = db_type.Where(t => t.id_train == temp.id_train).ToList();
                Train tempTrain = new Train();
                tempTrain.id = temp.id_train;
                tempTrain.numberTrain = temp.number_train;
                tempTrain.typeTrain = type.Last().type_train;
                if (tempTrain.typeTrain == need_type || need_type == "Все")
                    train.Add(tempTrain);
            }
            return train;
        }

        public List<String> getTypesCarriage()
        {
            List<String> type = new List<String>();
            type.Add("Все");
            foreach (CARRIAGE_TYPE types in db.CARRIAGE_TYPE.ToList())
            {
                type.Add(types.type_carriage);
            }
            type = type.Distinct().ToList();
            return type;
        }

        public List<String> getTypesTrain()
        {
            List<String> type = new List<String>();
            type.Add("Все");
            foreach (TRAIN_TYPE types in db.TRAIN_TYPE.ToList())
            {
                type.Add(types.type_train);
            }
            type = type.Distinct().ToList();
            return type;
        }

        public List<String> getStations()
        {
            List<String> type = new List<String>();
          
            foreach (STATION types in db.STATIONs.ToList())
            {
                type.Add(types.name_station);
            }
            type = type.Distinct().ToList();
            return type;
        }

        public Carriage newCarriage(int numberSeats, String type)
        {
            if(0>=numberSeats || numberSeats > 80)
            {
                return null;
            }

            type = type.Trim();
            type = Regex.Replace(type, @"\s+", "");
            if (!Regex.IsMatch(type, @"^[А-Я]{1}[а-я]{1,9}$"))
            {
                return null;
            }
            CARRIAGE cARRIAGE = new CARRIAGE();
            cARRIAGE.number_of_seats = numberSeats;
            db.CARRIAGEs.Add(cARRIAGE);
            db.SaveChanges(); db = new Context();
            CARRIAGE_TYPE cARRIAGE_TYPE = new CARRIAGE_TYPE();
            cARRIAGE_TYPE.type_carriage = type;
            db.CARRIAGE_TYPE.Add(cARRIAGE_TYPE);
            db.SaveChanges(); db = new Context();

            Carriage carriage = new Carriage();
            carriage.number_of_seats = numberSeats;
            carriage.type_carriage = type;
            carriage.id_carriage = cARRIAGE.id_carriage;
            return carriage;
        }

        public int getIdTrainByNumber(string number)
        {
            List<TRAIN> db_trains = db.TRAINs.ToList();
            foreach (TRAIN temp in db_trains)
            {
                if (temp.number_train == number)
                {
                    return temp.id_train;
                }
            }
            return 0;
        }

        public Composition newComposition(String numberTrain, int car)
        {
            numberTrain = numberTrain.Trim();
            numberTrain = Regex.Replace(numberTrain, @"\s+", "");
            try
            {
                if (getIdTrainByNumber(numberTrain) == null || getCarriageById(car) == null)
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }

            TRAIN_COMPOSITION tRAIN_COMPOSITION = new TRAIN_COMPOSITION();
            Composition composition = new Composition();
            composition.number_train = numberTrain;
            composition.id_carriage = car;
            tRAIN_COMPOSITION.id_carriage = car;
            tRAIN_COMPOSITION.id_train= getIdTrainByNumber(numberTrain);

            db.TRAIN_COMPOSITION.Add(tRAIN_COMPOSITION);
            db.SaveChanges();
            db = new Context();
            return composition;
        }

        public PASSANGER newPassanger(string name, string passport)
        {
            db.Configuration.ValidateOnSaveEnabled = false;
            name = name.Trim();
            name = Regex.Replace(name, @"\s+", " ");
            passport = passport.Trim();
            passport = Regex.Replace(passport, @"\s+", "");
            if (!Regex.IsMatch(name, @"^[А-Я]{1}[а-я]{1,17} [А-Я]{1}[а-я]{1,13} [А-Я]{1}[а-я]{1,11}$"))
            {
                return null;
            }
            if(getPassangerByNamePass(name, passport).Count != 0)
            {
                return null;
            }
           
            foreach(PASSANGER p in GetPASSANGERs())
            {
                if(p.passport == passport)
                {
                    MessageBox.Show("Номер пасспорта уже существует");
                    return null;
                }
            }
            if(!Regex.IsMatch(passport, @"^[0-9]{10}$"))
            {
                return null;
            }
            PASSANGER pas = new PASSANGER();
            pas.name = name;
            pas.passport = passport;
            pas.is_admin = 0;
            db.PASSANGERs.Add(pas);
            db.SaveChanges();
            db = new Context();
            return pas;
        }

        public List<TICKET> getTicketByPassanger(int id)
        {
            List<TICKET> list = db.TICKETs.ToList();
            List<TICKET> ret = new List<TICKET>();
            foreach(TICKET temp in list)
            {
                if (temp.id_passanger == id)
                    ret.Add(temp);
            }
            return ret;
        }

        public TICKET newTicket(int passanger, int train, int carriage, int price, int trip, String station)
        {
            if(train < 0 || getIdTrainByNumber(Convert.ToString(train)) == 0)
            {
                return null;
            }

            if(carriage <0 || getCarriageById(carriage) == null)
            {
                return null;
            }

            if(price < 0 || price > 20000)
            {
                return null;
            }

            if(trip < 0 || getTripById(trip) == null)
            {
                return null;
            }
            station = station.Trim();
            station = Regex.Replace(station, @"\s+", " ");
            if(getStationByName(station) == null || station == null)
            {
                return null;
            }

            db = new Context();
            TICKET ticket = new TICKET();
          
            if(getFreeTicket(getIdTrainByNumber(Convert.ToString(train))) == 0)
            {
                MessageBox.Show("Мест на поезд нет");
                return null;
            }
            ticket.id_passanger = passanger;
            ticket.id_train = getIdTrainByNumber(Convert.ToString(train));
            ticket.id_carriage = carriage;
            ticket.price = price;
            ticket.id_trip = trip;
            int id = getStationByName(station).id_station;
            ticket.timeP = getTripById(trip).time_start.AddMinutes(getTimeToStation(trip,station));
            ticket.id_station = id;
            bool saveFailed = false;
            db.TICKETs.Add(ticket);
            STATION st = new STATION();
                saveFailed = false;
            try
            {
                 db.SaveChanges();
                db = new Context();
            }
            catch (Exception e)
            {

            }
           
           
            return ticket;
        }

      

        public List<Ticket> getTickets()
        {
            
            List<TICKET> list = db.TICKETs.ToList();
            List<Ticket> ticket = new List<Ticket>();
            foreach(TICKET temp in list)
            {
                Ticket t = new Ticket();
                bool error = false;
                try
                {
                    List<String> st = getStationsByTrip(getTripByTrain(temp.id_train).First<TRIP>().id_trip);
                    t.start = st.First<String>();
                    t.finish = st.Last<String>();
                }
                catch (Exception)
                {
                    error = true;
                    
                    MessageBox.Show("В рейсе удалена станция, на которую был билет. Билет удален");
                    db.TICKETs.Remove(temp);
                    db.SaveChanges();
                    return null;
                }
               
                t.id_carriage = temp.id_carriage;
                t.id_passanger = temp.id_passanger;
                t.id_ticket = temp.id_ticket;
                t.id_train = temp.id_train;
                t.id_trip = getTripByTrain(temp.id_train).First<TRIP>().id_trip;
                t.name = getPassangerByid(temp.id_passanger).name;
                t.number_train = getTrainById(temp.id_train).number_train;
                t.time = temp.timeP;
                
                try
                {
                    t.station = getStationById(temp.id_station).name_station;
                }
                catch(Exception)
                {
                    error = true;
                    MessageBox.Show("В рейсе удалена станция, на которую был билет. Билет удален");
                    db.TICKETs.Remove(temp);
                    db.SaveChanges();
                }
                t.price = temp.price;
                if(!error)
                    ticket.Add(t);
                error = false;
            }
            return ticket;
        }

        public List<Ticket> getTicketsByPassangerId(int id)
        {
            List<TICKET> list = db.TICKETs.ToList();
            List<Ticket> ticket = new List<Ticket>();
            foreach (TICKET temp in list)
            {
                if (temp.id_passanger == id)
                {
                    Ticket t = new Ticket();
                    List<String> st = getStationsByTrip(getTripByTrain(temp.id_train).First<TRIP>().id_trip);
                    t.start = st.First<String>();
                    t.finish = st.Last<String>();
                    t.id_carriage = temp.id_carriage;
                    t.id_passanger = temp.id_passanger;
                    t.id_ticket = temp.id_ticket;
                    t.id_train = temp.id_train;
                    t.id_trip = getTripByTrain(temp.id_train).First<TRIP>().id_trip;
                    t.name = getPassangerByid(temp.id_passanger).name;
                    t.number_train = getTrainById(temp.id_train).number_train;
                    t.time = temp.timeP;
                    t.station = getStationById(temp.id_station).name_station;
                    t.price = temp.price;
                    ticket.Add(t);
                }
            }
            return ticket;
        }

        public List<String> getStationsByTrain(int id)
        {
            List<TripRoutes> tr = GetTripRoutesbyTrip(getTripByTrain(id).LastOrDefault<TRIP>().id_trip);
            List<String> t = new List<String>();
            foreach(TripRoutes temp in tr)
            {
                try
                {
                    t.Add(getStationById(getRouteById(temp.IdRoute).id_start_station).name_station);
                    t.Add(getStationById(getRouteById(temp.IdRoute).id_finish_station).name_station);
                }
                catch(Exception e)
                {
                   
                }
            }
            t = t.Distinct().ToList();
            return t;
        }
        public Boolean updatePassanger(int id, string name, string passport)
        {
            PASSANGER pas = getPassangerByid(id);
            
            if(pas.is_admin == 0)
            {
                name = name.Trim();
                name = Regex.Replace(name, @"\s+", " ");
                passport = passport.Trim();
                passport = Regex.Replace(passport, @"\s+", "");
                if (!Regex.IsMatch(name, @"^[А-Я]{1}[а-я]{1,17} [А-Я]{1}[а-я]{1,13} [А-Я]{1}[а-я]{1,11}$"))
                {
                    return false;
                }
                if (getPassangerByNamePass(name, passport).Count != 0)
                {
                    return false;
                }
                if (!Regex.IsMatch(passport, @"^[0-9]{10}$"))
                {
                    return false;
                }
                foreach (PASSANGER p in GetPASSANGERs())
                {
                    if (p.passport == passport)
                    {
                        MessageBox.Show("Номер пасспорта уже существует");
                        return false;
                    }
                }
            }
            pas.name = name;
            pas.passport = passport;
            db.SaveChanges();
            db = new Context();
            return true;
        }

        public PASSANGER getPassangerByid(int id)
        {
            List<PASSANGER> list = db.PASSANGERs.ToList();
            foreach(PASSANGER temp in list)
            {
                if (temp.id_passanger == id)
                    return temp;
            }
            return null;
        }

        public List<PASSANGER> getPassangerByNamePass(string name, string pass)
        {
            List<PASSANGER> list = db.PASSANGERs.ToList();
            List<PASSANGER> tempList = new List<PASSANGER>();
            foreach (PASSANGER temp in list)
            {
                if (temp.name == name && temp.passport == pass)
                    tempList.Add(temp);
            }
            return tempList;
        }

        public void checkAllRoute()
        {
            List<Trip> trips = getTrip();
            foreach(Trip tr in trips)
            {
                if(!checkGoodroutesByTrip(tr.id_trip))
                {
                    MessageBox.Show("При внесении изменений, маршрут рейса был несовместим.");
                    deleteTrip(tr.id_trip);
                }
            }
        }

        public bool checkGoodroutesByTrip(int id_trip)
        {
            Route start = null, finish = null;
            List<Route> routes = getRoutebyTrip(id_trip);

            if (routes.Count == 0 || routes == null)
                return false;
            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_start_station == temp2.name_finish_station || temp.name_start_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    start = temp;
                    break;
                }
            }

            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_finish_station == temp2.name_finish_station || temp.name_finish_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    finish = temp;
                    break;
                }
            }

            if (start == null || finish == null)
            {
                return false;
            }

            List<Route> goodRoute = new List<Route>();
            goodRoute.Add(start);
            routes.Remove(start);
            while (routes.Count != 0)
            {
                Route temp = goodRoute.Last<Route>();
                bool flag = false;
                foreach (Route t in routes)
                {
                    if (temp.name_finish_station == t.name_start_station)
                    {
                        goodRoute.Add(t);
                        routes.Remove(t);
                        flag = true;

                    }
                    if (flag)
                    {
                        break;
                    }
                }
                if (!flag)
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkGoodroutes(ListBox.SelectedObjectCollection selectedItems)
        {
            Route start=null, finish=null;
            List<Route> routes = new List<Route>();
            
            foreach (Object checkObj in selectedItems)
            {
                routes.Add((Route)checkObj);
            }

            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_start_station == temp2.name_finish_station || temp.name_start_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    start = temp;
                    break;
                }
            }

            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_finish_station == temp2.name_finish_station || temp.name_finish_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    finish = temp;
                    break;
                }
            }

            if (start == null || finish == null)
            {
                return false;
            }

            List<Route> goodRoute = new List<Route>();
            goodRoute.Add(start);
            routes.Remove(start);
            while(routes.Count != 0)
            {
                Route temp = goodRoute.Last<Route>();
                bool flag = false;
                foreach(Route t in routes)
                {
                    if (temp.name_finish_station == t.name_start_station)
                    {
                        goodRoute.Add(t);
                        routes.Remove(t);
                        flag = true;

                    }
                    if(flag)
                    {
                        break;
                    }
                }
                if(!flag)
                {
                    return false;
                }
            }
            if (goodRoute.Count == 0 )
                return false;
            return true;
        }


        public int getTimeToStation(int idTrip,String station)
        {
            Route start = null, finish = null;
            List<Route> routes = getRoutebyTrip(idTrip);
            

            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_start_station == temp2.name_finish_station || temp.name_start_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    start = temp;
                    break;
                }
            }

            foreach (Route temp in routes)
            {
                bool flag = false;
                foreach (Route temp2 in routes)
                {
                    if (temp != temp2)
                    {
                        if (temp.name_finish_station == temp2.name_finish_station || temp.name_finish_station == temp2.name_start_station)
                            flag = true;
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                {
                    finish = temp;
                    break;
                }
            }

           

            List<Route> goodRoute = new List<Route>();
            goodRoute.Add(start);
            routes.Remove(start);
            while (routes.Count != 0)
            {
                Route temp = goodRoute.Last<Route>();
                bool flag = false;
                foreach (Route t in routes)
                {
                    if (temp.name_finish_station == t.name_start_station)
                    {
                        goodRoute.Add(t);
                        routes.Remove(t);
                        flag = true;

                    }
                    if (flag)
                    {
                        break;
                    }
                }
                if (!flag)
                {
                    
                }
            }

            int time = 0;
            bool flag1=false;
            foreach(Route temp in goodRoute)
            {

                if (flag1)
                {
                    time += temp.route_time;
                    break;
                }
                if (temp.name_start_station != station && temp.name_finish_station != station)
                {
                    time += temp.route_time;
                    
                }
                else
                {
                    flag1 = true;
                }
            }
            return time;
        }

        public TRIP newTrip(String numberTrain, DateTime time1, DateTime time2, ListBox.SelectedObjectCollection selectedItems)
        {
            if(time1.AddMinutes(10) < DateTime.Now)
            {
                return null;
            }
            db = new Context();
            if (selectedItems.Count == 0)
                return null;
            TRIP trip = new TRIP();
            trip.id_train = getIdTrainByNumber(numberTrain);
            if(getCompositionByTrain(trip.id_train).Count == 0)
            {
                MessageBox.Show("У поезда нет вагонов!");
                return null;
            }
            trip.time_start = time1;
            trip.time_finish = time2;
            if (!checkGoodroutes(selectedItems))
                return null;
            int c=0;
            foreach (Object temp in selectedItems)
            {
               
                Route r = (Route)temp;
                c += r.route_time;
                
            }
            trip.time_finish = time1.AddMinutes(c);
            if (trip.time_start < DateTime.Now && DateTime.Now < trip.time_finish)
            {
                trip.status = "В пути";
            }
            if (trip.time_start > DateTime.Now)
            {
                trip.status = "Не начат";
            }
            if (DateTime.Now > trip.time_finish)
            {
                trip.status = "Окончен";
            }

            
           
            db.TRIPs.Add(trip);
            db.SaveChanges();
            db = new Context();
            int id = db.TRIPs.ToList().Last<TRIP>().id_trip;
            foreach (Object temp in selectedItems)
            {
                TripRoutes tr = new TripRoutes();
                Route r = (Route)temp;
                tr.IdRoute = r.id_route;
                tr.IdTrip = id;
                addTripRoutes(tr);
            }
       

            return trip;
        }

        public int getDayRoute(int id)
        {
            ROUTE route = getRouteById(id);
            return route.route_time / 1440;
        }

        public Boolean updateTrip(int id, String numberTrain, DateTime time1, DateTime time2, ListBox.SelectedObjectCollection selectedItems)
        {

            numberTrain = numberTrain.Trim();
         
            if (!Regex.IsMatch(numberTrain, @"^[0-9]{1,6}$"))
            {
                return false;
            }

            if (getIdTrainByNumber(numberTrain) == 0 || getIdTrainByNumber(numberTrain) == null)
            {
                return false;
            }

            if (time1.AddMinutes(10) < DateTime.Now)
            {
                return false;
            }
            if (selectedItems.Count == 0)
                return false;

            TRIP trip = getTripById(id);
            if (trip != null) {
                deleteTripRoutesByTrip(trip.id_trip);
                foreach (Object temp in selectedItems)
                {
                    TripRoutes tr = new TripRoutes();
                    Route r = (Route)temp;
                    tr.IdRoute = r.id_route;
                    tr.IdTrip = trip.id_trip;
                    addTripRoutes(tr);
                }
                if (!checkGoodroutes(selectedItems))
                    return false;
                trip = getTripById(id);
                int c = 0;
                foreach (Object temp in selectedItems)
                {

                    Route r = (Route)temp;
                    c += r.route_time;

                }
                trip.id_train = getIdTrainByNumber(numberTrain);
                if (getCompositionByTrain(trip.id_train).Count == 0)
                {
                    MessageBox.Show("У поезда нет вагонов!");
                    return false;
                }
                trip.time_start = time1;
                trip.time_finish = time1.AddMinutes(c);
                if (trip.time_start < DateTime.Now && DateTime.Now < trip.time_finish)
                {
                    trip.status = "В пути";
                }
                if (trip.time_start > DateTime.Now)
                {
                    trip.status = "Не начат";
                }
                if (DateTime.Now > trip.time_finish)
                {
                    trip.status = "Окончен";
                }
                try
                {
                    db.SaveChanges();
                    deleteRetryTripRoutes();
                }
                catch
                {

                }
                db = new Context();
                updateTickets();
                return true;
            }
            return false;
        }

        void updateTickets()
        {
            try
            {
                List<Ticket> tickets = getTickets();
                foreach (Ticket t in tickets)
                {
                    t.time = getTripById(t.id_trip).time_start.AddMinutes(getTimeToStation(t.id_trip, t.station));
                }
                db.SaveChanges();
            }
            catch
            {

            }
           
        }
        public ROUTE newRoute(String station1, string station2, int min)
        {
            station1 = station1.Trim();
            station2 = station2.Trim();
            station1 = Regex.Replace(station1, @"\s+", " ");
            station2 = Regex.Replace(station2, @"\s+", " ");

            try
            {
                if (getStationByName(station1) == null || getStationByName(station2) == null)
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }

            if(min < 30 || min > 14400) //10 дней
            {
                return null;
            }


            if (checkExistRoute(station1, station2))
            {

                if (!station1.Equals(station2))
                {

                    ROUTE route = new ROUTE();
                    route.id_start_station = getStationByName(station1).id_station;
                    route.id_finish_station = getStationByName(station2).id_station;
                    route.route_time = min;
                    db.ROUTEs.Add(route);
                    db.SaveChanges(); db = new Context();
                    return route;
                }
                else
                    return null;
            }
            else
            {
                return null;
            }
        }


        public STATION newStation(String name)
        {
            name = name.Trim();
            name = Regex.Replace(name, @"\s+", " ");
            try
            {
                if (getStationByName(name) != null)
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }

            if(!Regex.IsMatch(name, @"^[А-Я]{1}[а-я]{2,4}([-а-я]{0,1})?([-А-Яа-я]{0,1})?([а-я]{0,2})?([-а-я]{0,1})?([А-Яа-я]{0,1})?([а-я]{0,7})?( [а-я]{0,17})?$"))
            {
                return null;
            }
            STATION sTATION = new STATION();
            sTATION.name_station = name;
            db.STATIONs.Add(sTATION);
            db.SaveChanges();
            db = new Context();
            return (sTATION);

        }

        public Train newTrain(String number, String type)
        {
            number = number.Trim();
            number = Regex.Replace(number, @"\s+", "");
            type = type.Trim();
            type = Regex.Replace(type, @"\s+", "");
            if (!Regex.IsMatch(number, @"^[0-9]{1,6}$"))
            {
                return null;
            }
            if(!Regex.IsMatch(type, @"^[А-Я]{1}[а-я]{2,11}$"))
            {
                return null;
            }
            TRAIN train = db.TRAINs.Where(p => p.number_train == number).FirstOrDefault();
            if (train != null)
                return null;
            TRAIN t = new TRAIN();
            t.number_train = number;
            db.TRAINs.Add(t);
            db.SaveChanges();
            db = new Context();
            train = db.TRAINs.Where(p => p.number_train == number).FirstOrDefault();
            TRAIN_TYPE tt = new TRAIN_TYPE();
            tt.id_train = train.id_train;
            tt.type_train = type;
            db.TRAIN_TYPE.Add(tt);
            db.SaveChanges();
            db = new Context();
            Train new_train = new Train();
            new_train.id = t.id_train;
            new_train.numberTrain = t.number_train;
            new_train.typeTrain = tt.type_train;
            return new_train;
        }

        public Boolean UpdateTrain(int id, string numberTrain, string typeTrain)
        {
            numberTrain = numberTrain.Trim();
            numberTrain = Regex.Replace(numberTrain, @"\s+", "");
            typeTrain = typeTrain.Trim();
            typeTrain = Regex.Replace(typeTrain, @"\s+", "");
            if (!Regex.IsMatch(numberTrain, @"^[0-9]{1,6}$"))
            {
                return false;
            }
            if (!Regex.IsMatch(typeTrain, @"^[А-Я]{1}[а-я]{2,11}$"))
            {
                return false;
             }
            TRAIN train = getTrainById(id);
            TRAIN_TYPE tt = getTrainTypeById(id);
            if(train != null)
            {
                train.number_train = numberTrain;
                tt.type_train = typeTrain;
                db.SaveChanges();
                db = new Context();
                return true;
            }
            return false;
        }

        public Boolean checkExistRoute(string station1, string station2)
        {
            List<Route> list = getRoute();
            foreach(Route temp in list){
                if((temp.name_start_station==station1 && temp.name_finish_station==station2) /*||
                    (temp.name_start_station == station2 && temp.name_finish_station == station1)*/)
                {
                    return false;
                }
            }
            return true;

        }

        public Boolean UpdateRoute(int id, string station1, string station2, int min)
        {
            station1 = station1.Trim();
            station2 = station2.Trim();
            station1 = Regex.Replace(station1, @"\s+", " ");
            station2 = Regex.Replace(station2, @"\s+", " ");
            try
            {
                if (getStationByName(station1) == null || getStationByName(station2) == null)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            if (min <= 0 || min > 14400) //10 дней
            {
                return false;
            }

            if (checkExistRoute(station1, station2))
            {
                ROUTE route = getRouteById(id);
                if (station1 != station2)
                {
                    route.id_start_station = getStationByName(station1).id_station;
                    route.id_finish_station = getStationByName(station2).id_station;
                    route.route_time = min;
                    db.SaveChanges(); db = new Context();
               
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
           
        }

        public Boolean UpdateCarriage(int id, int numberOfSeats, string type)
        {
            if (0 >= numberOfSeats || numberOfSeats > 80)
            {
                return false;
            }

            type = type.Trim();
            type = Regex.Replace(type, @"\s+", "");
            if (!Regex.IsMatch(type, @"^[А-Я]{1}[а-я]{1,9}$"))
            {
                return false;
            }

            CARRIAGE car = getCarriageById(id);
            CARRIAGE_TYPE ct = getCarriageTypeById(id);
            if(car != null)
            {
                car.number_of_seats = numberOfSeats;
                ct.type_carriage = type;
                db.SaveChanges(); db = new Context();
                return true;
            }
            return false;
        }

        public Boolean UpdateStation(int id, string name)
        {

            name = name.Trim();
            name = Regex.Replace(name, @"\s+", " ");
            try
            {
                if (getStationByName(name) != null)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            if (!Regex.IsMatch(name, @"^[А-Я]{1}[а-я]{2,4}([-а-я]{0,1})?([-А-Яа-я]{0,1})?([а-я]{0,2})?([-а-я]{0,1})?([А-Яа-я]{0,1})?([а-я]{0,7})?( [а-я]{0,17})?$"))
            {
                return false;
            }

            STATION s = getStationById(id);
          
            if (s != null)
            {
                s.name_station = name;
                
                db.SaveChanges(); db = new Context();
                return true;
            }
            return false;
        }

        public Boolean deleteTrain(int id)
        {
            TRAIN train = getTrainById(id);
            TRAIN_TYPE tt = getTrainTypeById(id);
            if(train != null)
            {
                db.TRAINs.Remove(train);
                db.SaveChanges();
                db = new Context();
                
                
             //   if (getTrainById(id) == null)
              //  {
              //      db.TRAIN_TYPE.Remove(tt);
               //     db.SaveChanges();
               // }
                
                return true;
            }
            return false;
        }

        public TRAIN_COMPOSITION GetCompositionByCarriage(int id)
        {
            List<TRAIN_COMPOSITION> db_type = db.TRAIN_COMPOSITION.ToList();
            foreach (TRAIN_COMPOSITION temp in db_type)
            {
                if (temp.id_carriage == id)
                {
                    return temp;
                }
            }
            return null;
        }

        public List<ROUTE> getRouteByStation(int id)
        {
            List<ROUTE> routes = db.ROUTEs.ToList();
            List<ROUTE> find = new List<ROUTE>();
            foreach(ROUTE temp in routes)
            {
                if(temp.id_start_station == id || temp.id_finish_station == id)
                {
                    find.Add(temp);
                }
            }
            return find;
        }

        public Boolean deleteStation(int id)
        {
            STATION sTATION = getStationById(id);
            
            if (sTATION != null)
            {
                db.STATIONs.Remove(sTATION);
                db.SaveChanges();
                db = new Context();
                List<Route> route = getRoute();
                List<Route> route2 = getRoute();
                try
                {
                    foreach (Route r in route)
                    {
                        foreach (Route r2 in route)
                        {
                            if (r.id_route != r2.id_route && r.name_start_station == r2.name_start_station && r.name_finish_station == r2.name_finish_station && r.route_time == r2.route_time)
                            {
                                deleteRoute(r2.id_route);
                                route.Remove(r2);
                               // route.Remove(r2);
                            }   
                        }
                    }
                }
                catch
                { }

                checkAllRoute();
                updateTimeFinish();
                return true;
            }
            return false;
        }

        public Boolean deleteTrip(int id)
        {
            TRIP trip = getTripById(id);
            
            if (trip != null)
            {
                db.TRIPs.Remove(trip);
                db.SaveChanges(); db = new Context();
                deleteTripRoutesByTrip(trip.id_trip);
                
                return true;
            }
            return false;
        }

        public Boolean deleteRoute(int id)
        {
            ROUTE route = getRouteById(id);
            try
            {
                db.ROUTEs.Remove(route);
                db.SaveChanges();
            }
            catch
            { }
            deleteTripRoutes(route.id_route);
            db = new Context();
            updateTimeFinish();
            return true;
           
        }

        public Boolean deleteComposition(int id)
        {
            TRAIN_COMPOSITION tRAIN_COMPOSITION = getComposition(id);
       
            if (tRAIN_COMPOSITION!= null)
            {
                db.TRAIN_COMPOSITION.Remove(tRAIN_COMPOSITION);
            
                db.SaveChanges(); db = new Context();
                List<Ticket> tickets = getTickets();
                foreach(Ticket t in tickets)
                {
                    if(tRAIN_COMPOSITION.id_carriage == t.id_carriage)
                    {
                        deleteTicket(t.id_ticket);
                    }
                }
                return true;
            }
            return false;
        }
        public Boolean deleteCarriage(int id)
        {
            CARRIAGE c = getCarriageById(id);
            CARRIAGE_TYPE ct = getCarriageTypeById(id);
            TRAIN_COMPOSITION tc = GetCompositionByCarriage(id);
            if (tc != null)
            {
                db.CARRIAGEs.Remove(c);
                db.CARRIAGE_TYPE.Remove(ct);
                db.TRAIN_COMPOSITION.Remove(tc);
                db.SaveChanges(); db = new Context();
                List<Ticket> t = getTickets();
                foreach (Ticket temp in t)
                {
                    if (temp.id_carriage == c.id_carriage)
                    {
                        deleteTicket(temp.id_ticket);
                    }
                }
                return true;
            }
            else
            {
                db.CARRIAGEs.Remove(c);
                db.CARRIAGE_TYPE.Remove(ct);
                db.SaveChanges(); db = new Context();
                List<Ticket> t = getTickets();
                foreach (Ticket temp in t)
                {
                    if (temp.id_carriage == c.id_carriage)
                    {
                        deleteTicket(temp.id_ticket);
                    }
                }
                return true;
            }

            
            return false;
        }

        public List<Carriage> getFreeCarriage()
        {
            List<Carriage> carriages = new List<Carriage>();
            List<Carriage> dbCarriage = GetCarriages();
            List<Composition> compositions = GetComposition();
            foreach(Carriage temp in dbCarriage)
            {
                if (compositions.Count == 0)
                {
                    carriages.Add(temp);
                }
                else
                if(compositions.Where(p => p.id_carriage == temp.id_carriage).FirstOrDefault() == null)
                {
                    carriages.Add(temp);
                }
            }
            return carriages;
        }

        public List<Carriage> getCarriageByType(String type)
        {
            List<Carriage> carriages = new List<Carriage>();
            List<Carriage> dbCarriage = GetCarriages();
            List<Composition> compositions = GetComposition();

            if (type != "Все")
            {
                foreach (Carriage temp in dbCarriage)
                {
                    if (temp.type_carriage == type)
                        carriages.Add(temp);
                }
            }
            else
            {
                return dbCarriage;
            }
            return carriages;
        }

        public Boolean deletePassanger(int id)
        {
            PASSANGER pas = getPassangerByid(id);
            try
            {
                List<TICKET> tic = getTicketByPassanger(id);
                foreach (TICKET temp in tic)
                {
                    db.TICKETs.Remove(temp);
                }
            }
            catch
            {

            }
            db.PASSANGERs.Remove(pas);
            db.SaveChanges(); db = new Context();
            return true;

        }

        public TICKET getTicketById(int id)
        {
            List<TICKET> list = db.TICKETs.ToList();
            foreach(TICKET temp in list)
            {
                if (temp.id_ticket == id)
                    return temp;
            }
            return null;
        }

        public Boolean deleteTicket(int id)
        {
            TICKET pas = getTicketById(id);
            try
            {
                db.TICKETs.Remove(pas);

                db.SaveChanges(); db = new Context();
            }
            catch
            {

            }
            return true;

        }

        public Boolean addTripRoutes(TripRoutes trp)
        {
            
            db.TripRoutes.Add(trp);
            try
            {
                db.SaveChanges(); db = new Context();
            }
            catch { }
            return true;
        }
        public void deleteTripRoutes(int idTR)
        {
            List<TripRoutes> list = GetTripRoutes();
            foreach (TripRoutes tmp in list)
            {
                if (tmp.idTR == idTR)
                    db.TripRoutes.Remove(tmp);
            }
            db.SaveChanges();
           
        }

        public void updateTimeFinish()
        {
            List<TripRoutes> tr = GetTripRoutes();
            List<Trip> trip = getTrip();

            foreach(Trip temp in trip)
            {
                int id_trip = temp.id_trip;
                int time = 0;
                foreach(TripRoutes temp2 in tr)
                {
                    if(temp2.IdTrip == id_trip)
                    {
                        try
                        {
                            time += getRouteById(temp2.IdRoute).route_time;
                        }
                        catch(Exception)
                        {
                           
                        }
                    }
                }

                TRIP tempTRIP = getTripById(temp.id_trip);
                tempTRIP.time_finish = temp.time_start.AddMinutes(time);
                db.SaveChanges();
            }
            db.SaveChanges();
            db = new Context();

            List<Ticket> ticket = getTickets();
            foreach(Ticket temp in ticket)
            {
                List<string> stations = getStationsByTrip(temp.id_trip);
                bool flag = false;
                foreach(string str in stations)
                {
                    if(str == temp.station)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    TICKET T = getTicketById(temp.id_ticket);
                    db.TICKETs.Remove(T);
                    db.SaveChanges();
                }
            }
        }

        

        public Boolean deleteTripRoutesByTrip(int id)
        {
            List<TripRoutes> list = GetTripRoutesbyTrip(id);
      
            foreach (TripRoutes temp in list)
            {
                db.TripRoutes.Remove(temp);
            }
            try
            {
                db.SaveChanges(); db = new Context();
            }
            catch
            {

            }
            return true;
        }
    }
}
