using System;
using System.Collections.Generic;
using System.Linq;

namespace Nxsht
{
    public struct City
    {
        public string Name;
        public int Distance;
        public int AggregateDistance;
    }

    class CityDistance
    {
        private List<City> cities;
        public CityDistance()
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

        static T Swap<T>(ref T obj1, ref T obj2) =>
            ((obj1, obj2) = (obj2, obj1)).obj1;

        public void CalcAggragateDistance(List<City> cities)
        {
            City city;

            for (int i = 1, dist = 0; i < cities.Count; i++)
            {
                city = cities[i];
                city.AggregateDistance = dist += cities[i].Distance;
                cities[i] = city;
            }
        }

        public int GetDistanceLinq(string cityFrom, string cityTo) =>
      cities.AsQueryable()
          .Reverse()
          .SkipWhile(c => c.Name != cityFrom && c.Name != Swap(ref cityFrom, ref cityTo))
          .TakeWhile(c => c.Name != cityTo)
          .Select(c => c.Distance)
          .Sum();

        public int GetDistance(string cityFrom, string cityTo)
        {
            int distance = 0;
            int i = -1;

            while(++i < cities.Count)
            {
                if(cities[i].Name == cityFrom || cities[i].Name == cityTo)
                {
                    if (cityFrom == cityTo)
                        return 0;

                    if (cities[i].Name == cityTo) 
                        cityTo = cityFrom;

                    break;
                }
            }

            while (++i < cities.Count)
            {
                distance += cities[i].Distance;

                if (cities[i].Name == cityTo)
                    return distance;
            }

            return -1;
        }
    }
}
