using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public static class Emergency
    {
        static string[] _allEmergency = new string[]
        {
            "Загорелся №1",
            "Загорелся №2",
            "Загорелся №3",
            "Разбился №1",
            "Разбился №2",
            "Разбился №3",
            "Заглох №1",
            "Заглох №2",
            "Заглох №3"
        };

        public static string[] AllEmergency { get => _allEmergency; }
    }
}
