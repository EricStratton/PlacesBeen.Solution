using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string myCity = "Seattle";
      Place newPlace = new Place(myCity);
      string result = newPlace.City;
      Assert.AreEqual(myCity, result);
    }   
  }
}