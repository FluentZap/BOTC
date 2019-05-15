
namespace BOTC
{

  public class Bandit
  {
    public string Name {get; set;}
    public int Id {get; set;}
    public int CurrentHealth {get; set;}
    public User User {get;set;}
    public Classes Class{get; set;}

    public Bandit(int id)
    {
      Class = new Classes();
      Id = id;
    }
    

    public Bandit()
    {}

  }


  public class Classes
  {
    public int Id {get; set;}
    public string Name {get; set;}
    public int TotalHealth {get; set;}
    public int CurrentHealth {get; set;}
    public int Strength {get; set;}
    public int Dexterity {get; set;}
  }
}
