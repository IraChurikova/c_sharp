using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба1_с_шарп
{
    class Train
    {
        public List<TrainCarriage> trainList; //список всех вагонов
        public Train() 
        {
            trainList = new List<TrainCarriage>();
            trainList.Add(new TrainCarriage("Вагон 1 ",classOfComfort.Econom,25,10));
            trainList.Add(new TrainCarriage("Вагон 2 ",classOfComfort.Lux,11,11));
            trainList.Add(new TrainCarriage("Вагон 3 ",classOfComfort.Advanced,25,25));
            trainList.Add(new TrainCarriage("Вагон 4 ",classOfComfort.Econom,20,12));
            trainList.Add(new TrainCarriage("Вагон 5 ",classOfComfort.Econom,20,12));
            trainList.Add(new TrainCarriage("Вагон 6 ",classOfComfort.Premium,20,20));
            trainList.Add(new TrainCarriage("Вагон 7 ",classOfComfort.Advanced,15,15));
            trainList.Add(new TrainCarriage("Вагон 8 ",classOfComfort.Econom,25,10));
            trainList.Add(new TrainCarriage("Вагон 9 ",classOfComfort.Lux,10,10));
            trainList.Add(new TrainCarriage("Вагон 10 ",classOfComfort.Econom,25,10));
          
        }

        public double TrainCapacityByPas() // метод, считающий количество пассажиров
        {
            double capacityOfTrainP = 0;
            for (int i = 0; i < trainList.Count(); i++)
            {
                capacityOfTrainP += trainList[i].CapacityOfPassenger;
            }
            return capacityOfTrainP;
        }  
        public double TrainCapacityByBag() // метод, считающий количество багажа
        {
            double capacityOfTrainBag = 0;
            for (int i = 0; i < trainList.Count(); i++)
            {
                capacityOfTrainBag += trainList[i].CapacityOfBaggage;
            }
            return capacityOfTrainBag;
        }

        public List<TrainCarriage> sortByclassOfComfort(classOfComfort ClassOfComfort) //сортировка по классу комфортности
        {

            List<TrainCarriage> sortedtrainList = trainList.OrderByDescending(s => s.getClassOfComfort() == ClassOfComfort).ToList();
            return sortedtrainList;
        }

        public string findByRangePas(int first, int last) // находит поезда, удовл. диопазону кол-во пассажиров
        {
            string str = "";
            int capacity = 0;
            for (int i = 0; i < trainList.Count(); i++)
            {
                capacity = trainList[i].CapacityOfPassenger;
                if (capacity >= first && capacity <= last)
                {
                    str+= trainList[i].makeStr() + '\n';
                }
            }
            return str;
        }
        public string findByRangeBag(int first, int last)// находит поезда, удовл. диопазону кол-во багажа
        {
            string str = "";
            int capacity = 0;
            for (int i = 0; i < trainList.Count(); i++)
            {
                capacity = trainList[i].CapacityOfBaggage;
                if (capacity >= first && capacity <= last)
                {
                    str+= trainList[i].makeStr() + " ";
                }
            }
            return str;
        }
    }
}
