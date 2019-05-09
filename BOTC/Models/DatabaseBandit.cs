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
      List<Bandit> bandits = new List<Bandit>{};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM bandits INNER JOIN classes ON bandits.class_Id = classes.id;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        Bandit newBandit = new Bandit(rdr.GetInt32(0));
        newBandit.Name = rdr.GetString(1);
        newBandit.Stats.CurrentHealth = rdr.GetInt32(2);
        newBandit.Stats.Name = rdr.GetString(5);
        newBandit.Stats.TotalHealth = rdr.GetInt32(6);
        newBandit.Stats.Strength = rdr.GetInt32(7);
        newBandit.Stats.Dexterity = rdr.GetInt32(8);
        bandits.Add(newBandit);
      }
      DB.Close(conn);
      return bandits;
    }

    public static Bandit GetBandit(string banditId)
    {
      int id = int.Parse(banditId);
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM bandits INNER JOIN classes ON bandits.class_Id = classes.id WHERE bandits.id = @bandit_id;";
      cmd.Parameters.AddWithValue("@bandit_id", id);
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      rdr.Read();
      Bandit bandit = new Bandit(rdr.GetInt32(0));
      bandit.Name = rdr.GetString(1);
      bandit.Stats.CurrentHealth = rdr.GetInt32(2);
      bandit.Stats.Name = rdr.GetString(5);
      bandit.Stats.TotalHealth = rdr.GetInt32(6);
      bandit.Stats.Strength = rdr.GetInt32(7);
      bandit.Stats.Dexterity = rdr.GetInt32(8);
      DB.Close(conn);
      return bandit;
    }

    //Create Bandit
    public static string CreateBandit(string name, int classId)
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO bandits (name, currentHealth, class_id) VALUES (@name, @currentHealth, @classId);";
      cmd.Parameters.AddWithValue("@name", name);
      cmd.Parameters.AddWithValue("@currentHealth", GetClassStats(classId).CurrentHealth);
      cmd.Parameters.AddWithValue("@classId", classId);
      cmd.ExecuteNonQuery();
      DB.Close(conn);
      return cmd.LastInsertedId.ToString();
    }

    public static ClassStats GetClassStats(int classId)
    {
      ClassStats stats = new ClassStats();
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM classes WHERE id = @class_id;";
      cmd.Parameters.AddWithValue("@class_id", classId);
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      rdr.Read();
      stats.Name = rdr.GetString(1);
      stats.TotalHealth = rdr.GetInt32(2);
      stats.Strength = rdr.GetInt32(3);
      stats.Dexterity = rdr.GetInt32(4);

      DB.Close(conn);
      return stats;
    }

  }

}
