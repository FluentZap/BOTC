using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BOTC
{
  public partial class DB
  {

    //Database Calls
    public static List<Classes> GetAllClasses()
    {
      using(var db = new BOTCContext())
      {
        var allClasses = db.Classes.ToList();
        return allClasses;
      }
    }

    public static Classes GetClass(string classId)
    {
      int id = int.Parse(classId);
      using(var db = new BOTCContext())
      {
      var classType = db.Classes.Where(b => b.Id == id).FirstOrDefault();
      return classType;
      }
    }

    // //CreateClass saves new classes to db
    public static string CreateClass(string className, string totalHealth, string currentHealth, string strength, string dexterity)
    {
      using (var db = new BOTCContext())
      {
        Classes newClass = new Classes() {Name = className, CurrentHealth = int.Parse(currentHealth), TotalHealth = int.Parse(totalHealth), Strength = int.Parse(strength), Dexterity = int.Parse(dexterity)};
        db.Classes.Add(newClass);
        db.SaveChanges();
        return newClass.Id.ToString();
      }
    }
  }

}
