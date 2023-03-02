using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TamagotchiProject.Models;
using System;

namespace TamagotchiProject.Tests
{
  [TestClass]
  public class TamagotchiTests : IDisposable
  {

    public void Dispose()
    {
      Tamagotchi.ClearAll();
    }

    [TestMethod]
    public void TamagotchiConstructor_CreatesInstanceOfTamagotchi_Tamagotchi()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("test");
      Assert.AreEqual(typeof(Tamagotchi), newTamagotchi.GetType());
    }

    [TestMethod]
    public void TamagotchiConstructor_ReturnsWithNameField_Tamagotchi()
    {
      string test = "eat my shorts";
      Tamagotchi newTamagotchi = new Tamagotchi(test);
      Assert.AreEqual(test, newTamagotchi.Name);
    }

    [TestMethod]
    public void TamagotchiConstructor_IncrementsTotalCountStaticField_Tamagotchi()
    {
      string test = "eat my shorts";
      int countBeforeTest = Tamagotchi.totalCount;
      Tamagotchi newTamagotchi = new Tamagotchi(test);
      Assert.AreEqual(countBeforeTest, Tamagotchi.totalCount - 1);
    }
  }
}