using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BOTC
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }

    public static void Close(MySqlConnection conn)
    {
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

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

  public static class DBConfiguration
  {
    public static string ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=botc;";
  }





}
