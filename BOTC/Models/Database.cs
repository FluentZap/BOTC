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
        int Id = rdr.GetInt32(0);
        string Name = rdr.GetString(1);
        int CurrentHealth = rdr.GetInt32(2);
        string ClassName = rdr.GetString(5);
        int TotalHealth = rdr.GetInt32(6);
        int Strength = rdr.GetInt32(7);
        int Dexterity = rdr.GetInt32(8);
        bandits.Add(new Bandit(Id, Name, ClassName, CurrentHealth, TotalHealth, Strength, Dexterity));
      }
      DB.Close(conn);
      return bandits;
    }

  }

  public static class DBConfiguration
  {
    public static string ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=botc;";
  }





}
