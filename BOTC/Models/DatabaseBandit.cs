using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

namespace BOTC
{
  public partial class DB
  {

    //Database Calls
    public static List<Bandit> GetAll()
    {

      using(var db = new BOTCContext())
      {
        var bandits = db.Bandit.ToList();
      return bandits;
      }
    }

    public static Bandit GetBandit(string banditId)
    {
      int id = int.Parse(banditId);
      using(var db = new BOTCContext())
      {
      var bandit = db.Bandit.Where(b => b.Id == id) as Bandit;
      return bandit;
      }
    }
 
    // //CreateBandit saves new bandit to db
    public static string CreateBandit(string name, string sessionId, int classId)
    {
      using (var db = new BOTCContext())
      {
        Classes banditClass = db.Classes.Where(c => c.Id == classId) as Classes;
        User user = db.User.Where(u => u.SessionId == sessionId) as User;
        Bandit bandit = new Bandit() {Name = name, CurrentHealth = 100, User = user, Class = banditClass};
        db.Bandit.Add(bandit);
        db.SaveChanges();
        return bandit.Id.ToString();
      }
    }
    
    public static Classes GetClasses(int classId)
    {
      using(var db = new BOTCContext())
      {
      var banditClass = db.Classes.Where(c => c.Id == classId) as Classes;
      return banditClass;
      }
    }
  }

}
