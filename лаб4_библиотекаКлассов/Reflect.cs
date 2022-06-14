using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace лаб4_библиотекаКлассов
{
    public class Reflect
    {
        // Данный метод выводит информацию о содержащихся в классе методах
        public static string MethodReflectInfo<T>(T obj) where T : class
        {
            string s = "***Список методов класса "+ obj.ToString()+" ***\n";
            Type t = typeof(T);
            // Получаем коллекцию методов
            MethodInfo[] MArr = t.GetMethods();

            // Вывести методы
            foreach (MethodInfo m in MArr)
            {
                s+=" --> " + m.ReturnType.Name + " \t" + m.Name + "(";
                // Вывести параметры методов
                ParameterInfo[] p = m.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    s+=p[i].ParameterType.Name + " " + p[i].Name;
                    if (i + 1 < p.Length)
                    {
                       s+=", ";
                    }
                }
                s += ")\n";
            }
            
            return s;
        } 
        public static MethodInfo[] GetMethod<T>(T obj) where T : class
        {
            Type t = obj.GetType();
            // Получаем коллекцию методов
            MethodInfo[] MArr = t.GetMethods();

            return MArr;
        }
    }
}
