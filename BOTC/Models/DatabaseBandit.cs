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
    public static List<Bandit> GetAll(string sessionId)
    {
      using(var db = new BOTCContext())
      {
        var user = db.User.Where(b => b.SessionId == sessionId).FirstOrDefault();
        var bandits = db.Bandit.Where(b => b.User == user).Include("Class").ToList();
        return bandits;
      }
    }

    public static Bandit GetBandit(string banditId)
    {
      int id = int.Parse(banditId);
      using(var db = new BOTCContext())
      {
      var bandit = db.Bandit.Where(b => b.Id == id).Include("Class").FirstOrDefault();
      return bandit;
      }
    }

    // //CreateBandit saves new bandit to db
    public static string CreateBandit(string name, string sessionId, int classId)
    {
      using (var db = new BOTCContext())
      {
        Classes banditClass = db.Classes.Where(c => c.Id == classId).FirstOrDefault();
        User user = db.User.Where(u => u.SessionId == sessionId).FirstOrDefault();
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
      var banditClass = db.Classes.Where(c => c.Id == classId).FirstOrDefault();
      return banditClass;
      }
    }
  }

}
