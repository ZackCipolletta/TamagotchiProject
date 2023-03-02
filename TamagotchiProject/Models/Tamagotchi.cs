using System.Collections.Generic;
using System.Timers;
using System;

namespace TamagotchiProject.Models
{
  public class Tamagotchi
  {
    private static Timer _timer;
    public string Name { get; set; }
    private static List<Tamagotchi> _instances = new List<Tamagotchi> { };
    public static int totalCount = 0;
    public int Id;
    public int FoodLevel { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }


    public Tamagotchi(string name)
    {
      Name = name;
      _instances.Add(this);
      totalCount++;
      Id = totalCount;
      FoodLevel = 100;
      Attention = 100;
      Rest = 100;
      StartTimer();
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void StartTimer() 
    {
      // Create a timer and set a two second interval.
      _timer = new System.Timers.Timer();
      _timer.Interval = 10000;

      // Hook up the Elapsed event for the timer. 
      _timer.Elapsed += PassTime;

      // Have the timer fire repeated events (true is the default)
      _timer.AutoReset = true;

      // Start the timer
      _timer.Enabled = true;
    }

    public void Feed()
    {
      FoodLevel += 10;
      if (FoodLevel >= 100)
      {
        FoodLevel = 100;
      }
      
      if (FoodLevel <= 0)
      {
        FoodLevel = 0;
      }

    }

    public void GiveAttention()
    {
      Attention += 12;
      if (Attention >= 100)
      {
        Attention = 100;
      }
      
      if (Attention <= 0)
      {
        Attention = 0;
      }

    }

    public static Tamagotchi FindWithId(int searchId) {
      foreach (Tamagotchi tama in _instances) {
        if (tama.Id == searchId) {
          return tama;
        }
      }
      return null;
    }

    public void GiveSleep()
    {
      Rest += 50;
      if (Rest >= 100)
      {
        Rest = 100;
      }
      
      if (Rest <= 0)
      {
        Rest = 0;
      }

    }



    public bool CheckIfDead() {
      return FoodLevel == 0;
    }

    public void PassTime(Object source, System.Timers.ElapsedEventArgs e)
    {
      Console.Write("TICK WENT OFF " + this);
      // Dictionary<string,int> newRates = GetNewDepletionRates();
      FoodLevel -= 15;
      Attention -= 8;
      Rest -=7;
      if (FoodLevel <= 0) { FoodLevel = 0; } if (Attention <= 0) { Attention = 0; } if (Rest <= 0) { Rest = 0; }
    }
  }
}
