using System.Collections.Generic;

namespace PlacesBeen.Models
  {
    public class Place
    {
      public string City { get; set; }

      public Place(string city)
      {
        City = city;
      }
    }
  }