using Railway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway
{
    class DataBase
    {
        Context db;
        public DataBase()
        {
            db = new Context();
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
    }
}
