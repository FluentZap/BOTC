using System;


namespace BOTC
{

  public class Bandit
  {
    public string Name {get; set;}
    public int Id {get;}
    public ClassStats Stats {get; set;}

    public Bandit(int id)
    {
      Stats = new ClassStats();
      Id = id;
    }

  }


  public class ClassStats
  {
    public string Name {get; set;}
    public int TotalHealth {get; set;}
    public int CurrentHealth {get; set;}
    public int Strength {get; set;}
    public int Dexterity {get; set;}
  }
}
