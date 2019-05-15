// using System;
// using System.Collections.Generic;
// using MySql.Data.MySqlClient;
//
// namespace BOTC
// {
//   public partial class DB
//   {
//
//     public static void CreateUser(string userName, string password, string sessionId, string privileges)
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"INSERT INTO users (name, password, sessionId, Privileges) VALUES (@name, @password, @sessionId, @Privileges);";
//       cmd.Parameters.AddWithValue("@name", userName);
//       cmd.Parameters.AddWithValue("@sessionId", sessionId);
//       cmd.Parameters.AddWithValue("@Privileges", privileges);
//       cmd.Parameters.AddWithValue("@password", password);
//       cmd.ExecuteNonQuery();
//       DB.Close(conn);
//       //return cmd.LastInsertedId.ToString();
//     }
//
//     public static bool CheckForUserById(string sessionId)
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM users WHERE sessionId = @id;";
//       cmd.Parameters.AddWithValue("@id", sessionId);
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       bool isUser = rdr.Read();
//
//       DB.Close(conn);
//       return isUser;
//     }
//
//     public static bool CheckForUserByName(string userName)
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM users WHERE name = @userName;";
//       cmd.Parameters.AddWithValue("@userName", userName);
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       bool isUser = rdr.Read();
//
//       DB.Close(conn);
//       return isUser;
//     }
//
//     public static User GetUser(string sessionId)
//     {
//       User user = new User();
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM users WHERE sessionId = @id;";
//       cmd.Parameters.AddWithValue("@id", sessionId);
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       rdr.Read();
//       user.Id = rdr.GetInt32(0);
//       user.UserName= rdr.GetString(1);
//       user.Password= rdr.GetString(2);
//       user.SessionId = rdr.GetString(3);
//       user.Privileges = rdr.GetString(4);
//
//       DB.Close(conn);
//       return user;
//     }
//
//     public static User GetUserByName(string userName)
//     {
//       User user = new User();
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM users WHERE name = @userName;";
//       cmd.Parameters.AddWithValue("@userName", userName);
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       rdr.Read();
//       user.Id = rdr.GetInt32(0);
//       user.UserName= rdr.GetString(1);
//       user.Password= rdr.GetString(2);
//       user.SessionId = rdr.GetString(3);
//       user.Privileges = rdr.GetString(4);
//
//       DB.Close(conn);
//       return user;
//     }
//
//     public static void UpdateUserSessionId(string userName, string sessionId)
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"UPDATE users SET sessionId = @id WHERE Name = @userName;";
//       cmd.Parameters.AddWithValue("@id", sessionId);
//       cmd.Parameters.AddWithValue("@userName", userName);
//       cmd.ExecuteNonQuery();
//       DB.Close(conn);
//     }
//
//     public static bool UserLogIn(string userName, string password, string sessionId)
//     {
//       try
//       {
//         User dbUser = GetUserByName(userName);
//         if (dbUser.Password == password)
//         {
//           UpdateUserSessionId(userName, sessionId);
//           return true;
//         }
//         else
//         {
//           return false;
//         }
//       }
//       catch
//       {
//         return false;
//       }
//     }
//
//
//   }
// }
