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
 
    // //Create Bandit
    public static string CreateBandit(string name, int classId)
    {

      
      // MySqlConnection conn = DB.Connection();
      // conn.Open();
      // MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      // cmd.CommandText = @"INSERT INTO bandits (name, currentHealth, class_id) VALUES (@name, @currentHealth, @classId);";
      // cmd.Parameters.AddWithValue("@name", name);
      // cmd.Parameters.AddWithValue("@currentHealth", GetClasses(classId).CurrentHealth);
      // cmd.Parameters.AddWithValue("@classId", classId);
      // cmd.ExecuteNonQuery();
      // DB.Close(conn);
      return cmd.LastInsertedId.ToString();
    }
    //
    // public static Classes GetClasses(int classId)
    // {
    //   Classes stats = new Classes();
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM classes WHERE id = @class_id;";
    //   cmd.Parameters.AddWithValue("@class_id", classId);
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   rdr.Read();
    //   stats.Name = rdr.GetString(1);
    //   stats.TotalHealth = rdr.GetInt32(2);
    //   stats.Strength = rdr.GetInt32(3);
    //   stats.Dexterity = rdr.GetInt32(4);
    //
    //   DB.Close(conn);
    //   return stats;
    // }

  }

}
