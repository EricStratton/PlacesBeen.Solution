using System.Collections.Generic;

namespace PlacesBeen.Models
  {
    public class Place
    {
      public string City { get; set; }
      public string Country { get; set; }
      public string When { get; set; }
      public string Who { get; set; }
      public string HowLong { get; set; }
      public string Journal { get; set; }
      public int Id { get; }
      private static List<Place> _instances = new List<Place> {};

      public Place(string city, string country, string when, string who, string howLong, string journal)
      {
        City = city;
        Country = country;
        When = when;
        Who = who;
        HowLong = howLong;
        Journal = journal;
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