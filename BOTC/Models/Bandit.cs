using System;


namespace BOTC
{

  public class Bandit
  {
    public string Name {get;}
    public int Id {get;}
    public string ClassName {get;}
    public int Health {get; set;}
    public int HealthTotal {get; set;}
    public int Strength {get; set;}
    public int Dexterity {get; set;}

    public Bandit(int id, string name, string className, int currentHealth, int totalHealth, int strength, int dexterity)
    {
      Id = id;
      Name = name;
      ClassName = className;
      Health = currentHealth;
      HealthTotal = totalHealth;
      Strength = strength;
      Dexterity = dexterity;
    }

  }
}
