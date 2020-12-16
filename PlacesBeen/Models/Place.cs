using System.Collections.Generic;

namespace PlacesBeen.Models
  {
    public class Place
    {
      public string City { get; set; }
      public int Id { get; }
      private static List<Place> _instances = new List<Place> {};

      public Place(string city)
      {
        City = city;
        Id = _instances.Count;
        _instances.Add(this);
      }

      public static List<Place> GetAll()
      {
        return _instances;
      }

      public static Place Find(int searchId)
      {
        return _instances[searchId];
      }
    }
  }