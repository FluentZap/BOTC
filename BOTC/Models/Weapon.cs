using System;

namespace BOTC
{
  public class Weapon
  {
    public string Name {get; set;}
    public int Id {get;}
    public int Speed {get; set;}
    public int DamageDie {get; set;}
    public string DamageType {get; set;}
    public int AttackRange {get; set;}

    public Weapon(int id)
    {
      Id = id;
    }
    public Weapon() { }

  }


}
