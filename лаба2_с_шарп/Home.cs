using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2_с_шарп
{
    public class Home //класс 1-го уровня
    {

        private int numberOfHome;
        private int countOfFlats;
        private int yearOfBuild;

        public Home() //конструктор по умолчанию
        {

        }

        public Home(int numberOfHome, int countOfFlats, int yearOfBuild) //конструктор с параметрами
        {
            this.numberOfHome = numberOfHome;
            this.countOfFlats = countOfFlats;
            this.yearOfBuild = yearOfBuild;
        }

        public int getNumberOfHome()
        {
            return numberOfHome;
        }

        public void setNumberOfHome(int numberOfHome)
        {
            this.numberOfHome = numberOfHome;
        }

        public int getcountOfFlats()
        {
            return countOfFlats;
        }

        public void setCountOfFlats(int countOfFlats)
        {
            this.countOfFlats = countOfFlats;
        }

        public int getYearOfBuild()
        {
            return yearOfBuild;
        }

        public void setYearOfBuild(int yearOfBuild)
        {
            this.yearOfBuild = yearOfBuild;
        }

        public virtual double qualityOfHome() //функция, которая определяет качество объекта по заданной формуле для класса 1-го уровня
        {
            double Q = getcountOfFlats() + 2 * (2022 - getYearOfBuild());
            return Q;
        }

        public virtual string makeStr()
        {
            return "Номер дома: " + getNumberOfHome() + ", Количество квартир: " + getcountOfFlats() + " Год сооружения дома: " + getYearOfBuild() + " год";
        }

    }

    public class ExstraHome: Home //класс 2-го уровня
    {
        private string district; //дополнительное поле - район
        public ExstraHome(int numberOfHome, int countOfFlats, int yearOfBuild, string district) : base (numberOfHome, countOfFlats, yearOfBuild) //конструктор
        {
            this.district = district;
        }

        public string getDistrict()
        {
            return district;
        }

        public void setDistrict(string district)
        {
            this.district = district;
        }

        public override double qualityOfHome()
        {
            double Q = base.qualityOfHome();
            double Qp;
            if (getDistrict() == "Центр")
            {
                Qp = 2 * Q;
            }   
            else 
            {
                Qp = 0.5 * Q;
            }
           
            return Qp;
        }

        public override string makeStr() // возвращает строку для вывода в листбокс класса 2-го уровня
        {
            return base.makeStr() + ",Район: " + getDistrict();
        }
    }
}
