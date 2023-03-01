using System.Collections.Generic;

namespace TamagotchiProject.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    private static List<Tamagotchi> _instances = new List<Tamagotchi> { };
    public static int totalCount = 0;

    public Tamagotchi(string name)
    {
      Name = name;
      _instances.Add(this);
      totalCount++;
      
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
