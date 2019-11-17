using Railway.Forms;
using Railway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway
{
    class DataBase
    {
       public Context db;
        public DataBase()
        {
            db = new Context();
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
            List<TripRoutes> temp = GetTripRoutesbyTrip(id);
            List<String> response = new List<String>();
            response.Add(
            getStationById(
            getRouteById(temp.First<TripRoutes>().IdRoute).id_start_station).name_station);

            response.Add(
            getStationById(
            getRouteById(temp.Last<TripRoutes>().IdRoute).id_finish_station).name_station);

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
                r.route = r.name_start_station + " - " + r.name_finish_station;
                route.Add(r);
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
                if (temp.time_start < DateTime.Now)
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
                t.start_station = st.First<String>();
                t.finish_station = st.Last<String>();
                trip.Add(t);
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

        public Carriage newCarriage(int numberSeats, String type)
        {
            CARRIAGE cARRIAGE = new CARRIAGE();
            cARRIAGE.number_of_seats = numberSeats;
            db.CARRIAGEs.Add(cARRIAGE);
            db.SaveChanges();
            CARRIAGE_TYPE cARRIAGE_TYPE = new CARRIAGE_TYPE();
            cARRIAGE_TYPE.type_carriage = type;
            db.CARRIAGE_TYPE.Add(cARRIAGE_TYPE);
            db.SaveChanges();

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
            TRAIN_COMPOSITION tRAIN_COMPOSITION = new TRAIN_COMPOSITION();
            Composition composition = new Composition();
            composition.number_train = numberTrain;
            composition.id_carriage = car;
            tRAIN_COMPOSITION.id_carriage = car;
            tRAIN_COMPOSITION.id_train= getIdTrainByNumber(numberTrain);

            db.TRAIN_COMPOSITION.Add(tRAIN_COMPOSITION);
            db.SaveChanges();
            
            return composition;
        }

        public PASSANGER newPassanger(string name, string passport)
        {
            PASSANGER pas = new PASSANGER();
            pas.name = name;
            pas.passport = passport;
            pas.is_admin = 0;
            db.PASSANGERs.Add(pas);
            db.SaveChanges();
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

        public TICKET newTicket(int passanger, int train, int carriage, int price, int trip)
        {
            TICKET ticket = new TICKET();
            ticket.id_passanger = passanger;
            ticket.id_train = train;
            ticket.id_carriage = carriage;
            ticket.price = price;
            ticket.id_trip = trip;

            db.TICKETs.Add(ticket);
            db.SaveChanges();
            return ticket;
        }

        public List<Ticket> getTickets()
        {
            List<TICKET> list = db.TICKETs.ToList();
            List<Ticket> ticket = new List<Ticket>();
            foreach(TICKET temp in list)
            {
                Ticket t = new Ticket();
                //t.finish =getStationById(getRouteById(getTripById(temp.id_trip).id_route).id_finish_station).name_station;
                //t.start = getStationById(getRouteById(getTripById(temp.id_trip).id_route).id_start_station).name_station;
                t.id_carriage = temp.id_carriage;
                t.id_passanger = temp.id_passanger;
                t.id_ticket = temp.id_ticket;
                t.id_train = temp.id_train;
                t.id_trip = temp.id_trip;
                t.name = getPassangerByid(temp.id_passanger).name;
                t.number_train = getTrainById(temp.id_train).number_train;
                t.price = temp.price;
                ticket.Add(t);
            }
            return ticket;
        }

        

        public Boolean updatePassanger(int id, string name, string passport)
        {
            PASSANGER pas = getPassangerByid(id);
            pas.name = name;
            pas.passport = passport;
            db.SaveChanges();
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

        public TRIP newTrip(String numberTrain, DateTime time1, DateTime time2, ListBox.SelectedObjectCollection selectedItems)
        {
            if (selectedItems.Count == 0)
                return null;
            TRIP trip = new TRIP();
            trip.id_train = getIdTrainByNumber(numberTrain);
            trip.time_start = time1;
            trip.time_finish = time2;

            if (time1 < time2)
            {
                trip.time_start = time1;
                trip.time_finish = time2;
            }
            else
            {
                trip.time_start = time2;
                trip.time_finish = time1;
            }
            
            if (trip.time_start < DateTime.Now && DateTime.Now < trip.time_finish)
            {
                trip.status = "В пути";
            }
            if (trip.time_start < DateTime.Now)
            {
                trip.status = "Не начат";
            }
            if (DateTime.Now > trip.time_finish)
            {
                trip.status = "Окончен";
            }

            
           
            db.TRIPs.Add(trip);
            db.SaveChanges();

            foreach (Object temp in selectedItems)
            {
                TripRoutes tr = new TripRoutes();
                Route r = (Route)temp;
                tr.IdRoute = r.id_route;
                tr.IdTrip = trip.id_trip;
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
                trip.id_train = getIdTrainByNumber(numberTrain);
            if(time1 < time2)
                {
                    trip.time_start = time1;
                    trip.time_finish = time2;
                }
                else
                {
                    trip.time_start = time2;
                    trip.time_finish = time1;
                }
                
               

            if (trip.time_start < DateTime.Now && DateTime.Now < trip.time_finish)
            {
                trip.status = "В пути";
            }
            if (trip.time_start < DateTime.Now)
            {
                trip.status = "Не начат";
            }
            if (DateTime.Now > trip.time_finish)
            {
                trip.status = "Окончен";
            }

       


            db.SaveChanges();

            return true;
            }
            return false;
        }

        public ROUTE newRoute(String station1, string station2, int min)
        {
            if (checkExistRoute(station1, station2))
            {

                if (!station1.Equals(station2))
                {

                    ROUTE route = new ROUTE();
                    route.id_start_station = getStationByName(station1).id_station;
                    route.id_finish_station = getStationByName(station2).id_station;
                    route.route_time = min;
                    db.ROUTEs.Add(route);
                    db.SaveChanges();
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
            STATION sTATION = new STATION();
            sTATION.name_station = name;
            db.STATIONs.Add(sTATION);
            db.SaveChanges();
            return (sTATION);

        }

        public Train newTrain(String number, String type)
        {
            TRAIN train = db.TRAINs.Where(p => p.number_train == number).FirstOrDefault();
            if (train != null)
                return null;
            TRAIN t = new TRAIN();
            t.number_train = number;
            db.TRAINs.Add(t);
            db.SaveChanges();

            train = db.TRAINs.Where(p => p.number_train == number).FirstOrDefault();
            TRAIN_TYPE tt = new TRAIN_TYPE();
            tt.id_train = train.id_train;
            tt.type_train = type;
            db.TRAIN_TYPE.Add(tt);
            db.SaveChanges();
            Train new_train = new Train();
            new_train.id = t.id_train;
            new_train.numberTrain = t.number_train;
            new_train.typeTrain = tt.type_train;
            return new_train;
        }

        public Boolean UpdateTrain(int id, string numberTrain, string typeTrain)
        {
            TRAIN train = getTrainById(id);
            TRAIN_TYPE tt = getTrainTypeById(id);
            if(train != null)
            {
                train.number_train = numberTrain;
                tt.type_train = typeTrain;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Boolean checkExistRoute(string station1, string station2)
        {
            List<Route> list = getRoute();
            foreach(Route temp in list){
                if((temp.name_start_station==station1 && temp.name_finish_station==station2) ||
                    (temp.name_start_station == station2 && temp.name_finish_station == station1))
                {
                    return false;
                }
            }
            return true;

        }

        public Boolean UpdateRoute(int id, string station1, string station2, int min)
        {
            if (checkExistRoute(station1, station2))
            {
                ROUTE route = getRouteById(id);
                if (station1 != station2)
                {
                    route.id_start_station = getStationByName(station1).id_station;
                    route.id_finish_station = getStationByName(station2).id_station;
                    route.route_time = min;
                    db.SaveChanges();
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
            CARRIAGE car = getCarriageById(id);
            CARRIAGE_TYPE ct = getCarriageTypeById(id);
            if(car != null)
            {
                car.number_of_seats = numberOfSeats;
                ct.type_carriage = type;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Boolean UpdateStation(int id, string name)
        {
            STATION s = getStationById(id);
          
            if (s != null)
            {
                s.name_station = name;
                
                db.SaveChanges();
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
                db.TRAIN_TYPE.Remove(tt);
                db.SaveChanges();
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
            List<ROUTE> route = getRouteByStation(id);
            if (sTATION != null)
            {
                db.STATIONs.Remove(sTATION);
                foreach(ROUTE temp in route)
                {
                    db.ROUTEs.Remove(temp);
                }
                
                db.SaveChanges();
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
                deleteTripRoutesByTrip(trip.id_trip);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Boolean deleteRoute(int id)
        {
            ROUTE route = getRouteById(id);
            
            db.ROUTEs.Remove(route);
            db.SaveChanges();
            return true;
           
        }

        public Boolean deleteComposition(int id)
        {
            TRAIN_COMPOSITION tRAIN_COMPOSITION = getComposition(id);
       
            if (tRAIN_COMPOSITION!= null)
            {
                db.TRAIN_COMPOSITION.Remove(tRAIN_COMPOSITION);
            
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public Boolean deleteCarriage(int id)
        {
            CARRIAGE c = getCarriageById(id);
            CARRIAGE_TYPE ct = getCarriageTypeById(id);
            TRAIN_COMPOSITION tc = GetCompositionByCarriage(id);
            if (c != null)
            {
                db.CARRIAGEs.Remove(c);
                db.CARRIAGE_TYPE.Remove(ct);
                db.TRAIN_COMPOSITION.Remove(tc);
                db.SaveChanges();
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
            List<TICKET> tic = getTicketByPassanger(id);
            foreach(TICKET temp in tic)
            {
                db.TICKETs.Remove(temp);
            }
            db.PASSANGERs.Remove(pas);
            db.SaveChanges();
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
            db.TICKETs.Remove(pas);
           
            db.SaveChanges();
            return true;

        }

        public Boolean addTripRoutes(TripRoutes trp)
        {
           
            db.TripRoutes.Add(trp);
            db.SaveChanges();
            return true;
        }
        public void deleteTripRoutes(int idRoute)
        {
            List<TripRoutes> list = GetTripRoutes();
            foreach (TripRoutes tmp in list)
            {
                if (tmp.IdRoute == idRoute)
                    db.TripRoutes.Remove(tmp);
            }
            db.SaveChanges();
        }

        public Boolean deleteTripRoutesByTrip(int id)
        {
            List<TripRoutes> list = GetTripRoutesbyTrip(id);
      
            foreach (TripRoutes temp in list)
            {
                db.TripRoutes.Remove(temp);
            }
            
            db.SaveChanges();
            return true;
        }
    }
}
