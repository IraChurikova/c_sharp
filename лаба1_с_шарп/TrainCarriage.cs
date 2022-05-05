using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Транспорт.
Определить иерархию подвижного состава железнодорожного транспорта.
Создать пассажирский поезд. Подсчитать общую численность пассажиров и багажа.
Провести сортировку вагонов поезда на основе уровня комфортности.
Найти в поезде вагоны, соответствующие заданному диапазону параметров числа пассажиров.
*/


namespace лаба1_с_шарп
{
    public enum classOfComfort 
    {
        Lux, Econom, Advanced, Premium
    }

    public class TrainCarriage 
    {
        private string name;
        private classOfComfort ClassOfComfort;
        private int capacityOfPassenger;
        private int capacityOfBaggage;
        public int CapacityOfPassenger { get { return capacityOfPassenger; } set { capacityOfPassenger = value; } }
        public int CapacityOfBaggage { get { return capacityOfBaggage; } set { capacityOfBaggage = value; } }
        public TrainCarriage()
        {
            name = "";
            ClassOfComfort = classOfComfort.Econom;
            capacityOfPassenger = 0;
            capacityOfBaggage = 0;
        }

        public TrainCarriage(string name, classOfComfort ClassOfComfort, int capacityOfPassenger, int capacityOfBaggage) //конструктор
        {
            this.name = name;
            this.ClassOfComfort = ClassOfComfort;
            this.capacityOfPassenger = capacityOfPassenger;
            this.capacityOfBaggage = capacityOfBaggage;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

      
        public classOfComfort getClassOfComfort()
        {
            return ClassOfComfort;
        }

        public void setClassOfComfort(classOfComfort ClassOfComfort)
        {
            this.ClassOfComfort = ClassOfComfort;
        }

        public string makeStr() // возвращает строку для вывода в листбокс
        {
            return "Название вагона: " + getName() + ", Количество пассажиров: " + capacityOfPassenger + ", Количество багажа: " + capacityOfBaggage + ", Класс комфорта: " + getClassOfComfort()+' ';
        }
    }
}
