using System.Collections.Generic;
using System.Linq;

namespace NixSolHT1.CityDistance
{
    struct City
    {
        public string Name;
        public int Distance;
    }

    class Task3
    {
        private List<City> cities;

        public Task3()
        {
            cities = new List<City>();
            cities.Add(new City { Name = "Kiev", Distance = 0 });
            cities.Add(new City { Name = "Borispol", Distance = 38 });
            cities.Add(new City { Name = "Piryatin", Distance = 127 });
            cities.Add(new City { Name = "Lubny", Distance = 47 });
            cities.Add(new City { Name = "Horol", Distance = 41 });
            cities.Add(new City { Name = "Reshetylivka", Distance = 73 });
            cities.Add(new City { Name = "Poltava", Distance = 39 });
            cities.Add(new City { Name = "Chutovo", Distance = 52 });
            cities.Add(new City { Name = "Valki", Distance = 38 });
            cities.Add(new City { Name = "Lubotin", Distance = 37 });
            cities.Add(new City { Name = "Pisochyn", Distance = 15 });
            cities.Add(new City { Name = "Kharkov", Distance = 11 });
        }

        static void Swap<T>(ref T obj1, ref T obj2)
        {
            var temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        private int GetDistance(string cityFrom, string cityTo)
        {
            int res = -1;
            var from = cities.Select(t => t.Name).ToList().IndexOf(cityFrom);  //n
            var to = cities.Select(t => t.Name).ToList().IndexOf(cityTo);      //n
            if (from != -1 && to != -1)
            {
                if (from > to)
                {
                    Swap(ref from, ref to);
                }
                res = 0;
                from++;
                while (from <= to)
                {
                    res += cities[from++].Distance;   //n
                }
            }
            return res;
        } //3n O(n)
    }
}
