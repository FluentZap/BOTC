
namespace BOTC
{
  public class Item
  {
    public int Id {get; set;}
    public string Type {get; set;}
    public int Type_Id {get; set;}
    public string Name {get; set;}
    public int Cost {get; set;}
  }

  public class Inventory
  {
    public int Id {get;set;}
    public Bandit Bandit {get;set;}
    public Item Item {get;set;}
    public int Quantity {get;set;}
  }
}
