using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BOTC
{
  public partial class DB
  {

    //Database Calls
    public static List<Bandit> GetAll()
    {

      using(var db = new BOTCContext())
      {
        var bandits = db.Bandit
            .ToList();
      }

      // List<Bandit> bandits = new List<Bandit>{};
      // MySqlConnection conn = DB.Connection();
      // conn.Open();
      // MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      // cmd.CommandText = @"SELECT * FROM bandits INNER JOIN classes ON bandits.class_Id = classes.id;";
      // MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      // while(rdr.Read())
      // {
      //   Bandit newBandit = new Bandit(rdr.GetInt32(0));
      //   newBandit.Name = rdr.GetString(1);
      //   newBandit.Class_Id.CurrentHealth = rdr.GetInt32(2);
      //   newBandit.Class_Id.Name = rdr.GetString(6);
      //   newBandit.Class_Id.TotalHealth = rdr.GetInt32(7);
      //   newBandit.Class_Id.Strength = rdr.GetInt32(8);
      //   newBandit.Class_Id.Dexterity = rdr.GetInt32(9);
      //   bandits.Add(newBandit);
      // }
      // DB.Close(conn);
      return bandits;
    }

    // public static Bandit GetBandit(string banditId)
    // {
    //   int id = int.Parse(banditId);
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"SELECT * FROM bandits INNER JOIN classes ON bandits.class_Id = classes.id WHERE bandits.id = @bandit_id;";
    //   cmd.Parameters.AddWithValue("@bandit_id", id);
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   rdr.Read();
    //   Bandit bandit = new Bandit(rdr.GetInt32(0));
    //   bandit.Name = rdr.GetString(1);
    //   bandit.Class_Id.CurrentHealth = rdr.GetInt32(2);
    //   bandit.Class_Id.Name = rdr.GetString(6);
    //   bandit.Class_Id.TotalHealth = rdr.GetInt32(7);
    //   bandit.Class_Id.Strength = rdr.GetInt32(8);
    //   bandit.Class_Id.Dexterity = rdr.GetInt32(9);
    //   DB.Close(conn);
    //   return bandit;
    // }
    //
    // //Create Bandit
    // public static string CreateBandit(string name, int classId)
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = @"INSERT INTO bandits (name, currentHealth, class_id) VALUES (@name, @currentHealth, @classId);";
    //   cmd.Parameters.AddWithValue("@name", name);
    //   cmd.Parameters.AddWithValue("@currentHealth", GetClasses(classId).CurrentHealth);
    //   cmd.Parameters.AddWithValue("@classId", classId);
    //   cmd.ExecuteNonQuery();
    //   DB.Close(conn);
    //   return cmd.LastInsertedId.ToString();
    // }
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
