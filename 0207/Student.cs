using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207
{
    public class City
    {
        private string name;
        private string country;
        private double population;
        private int code;
        private string[] regions;
        public override string ToString()
        {
            return "Имя города: " + name + "\nСтрана: " + country + "\nКоличество жителей: " + population + "\nТелефонный код: " + code;
        }
        public string Name //prop
        {
            get => name;
            set => name = value;
        }
        public string Country //prop
        {
            get => country;
            set => country = value;
        }
        public double Population //prop
        {
            get => population;
            set => population = value;
        }
        public int Code //prop
        {
            get => code;
            set => code = value;
        }
        public City() {}
        public City(string _name,string _country,double _population, int _code, string[] _regions)
        {
            name = _name;
            country = _country;
            population = _population;
            code = _code;
            regions = _regions;
        }
        public void Print()
        {
            Console.Write("Имя города: " + name + "\nСтрана: " + country+"\nКоличество жителей: "+population+"\nТелефонный код: "+code+"\nРайоны:");
            foreach(string i in regions)
            {
                Console.Write(i+", ");
            }
        }
    }
}
