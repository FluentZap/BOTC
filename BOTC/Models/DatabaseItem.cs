// using System;
// using System.Collections.Generic;
// using MySql.Data.MySqlClient;
//
// namespace BOTC
// {
//   public partial class DB
//   {
//
//     //Items
//     public static string CreateItem(Item item)
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"INSERT INTO items (name, type) VALUES (@name, @type);";
//       cmd.Parameters.AddWithValue("@name", item.Name);
//       cmd.Parameters.AddWithValue("@type", item.Type);
//       cmd.ExecuteNonQuery();
//       int itemId = (int)cmd.LastInsertedId;
//
//       cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"INSERT INTO weaponStats (Item_id, Speed, DamageDie, DamageType, AttackRange) VALUES (@Item_id, @Speed, @DamageDie, @DamageType, @AttackRange);";
//       cmd.Parameters.AddWithValue("@Item_id", itemId);
//       cmd.Parameters.AddWithValue("@Speed", item.Speed);
//       cmd.Parameters.AddWithValue("@DamageDie", item.DamageDie);
//       cmd.Parameters.AddWithValue("@DamageType", item.DamageType);
//       cmd.Parameters.AddWithValue("@AttackRange", item.AttackRange);
//       cmd.ExecuteNonQuery();
//       DB.Close(conn);
//       return itemId.ToString();
//     }
//
//     public static Item GetItem(string itemId)
//     {
//       int id = int.Parse(itemId);
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM items INNER JOIN weaponStats ON items.id = weaponStats.item_Id WHERE items.id = @item_id;";
//       cmd.Parameters.AddWithValue("@item_id", id);
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       rdr.Read();
//       Item newItem = new Item();
//       newItem.Id = rdr.GetInt32(0);
//       newItem.Name = rdr.GetString(1);
//       newItem.Type = rdr.GetString(2);
//       newItem.Speed = rdr.GetInt32(5);
//       newItem.DamageDie = rdr.GetInt32(6);
//       newItem.DamageType = rdr.GetString(7);
//       newItem.AttackRange = rdr.GetInt32(8);
//       DB.Close(conn);
//       return newItem;
//     }
//
//     public static List<Item> GetAllItem()
//     {
//       List<Item> items = new List<Item>{};
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM items INNER JOIN weaponStats ON items.id = weaponStats.item_id;";
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       while(rdr.Read())
//       {
//         Item newItem = new Item();
//         newItem.Id = rdr.GetInt32(0);
//         newItem.Name = rdr.GetString(1);
//         newItem.Type = rdr.GetString(2);
//         newItem.Speed = rdr.GetInt32(5);
//         newItem.DamageDie = rdr.GetInt32(6);
//         newItem.DamageType = rdr.GetString(7);
//         newItem.AttackRange = rdr.GetInt32(8);
//         items.Add(newItem);
//       }
//       DB.Close(conn);
//       return items;
//     }
//
//     public static void DeleteItem(string itemId)
//     {
//       int id = int.Parse(itemId);
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"DELETE FROM weaponStats WHERE weaponStats.item_id = @itemId;";
//       cmd.Parameters.AddWithValue("@itemId", id);
//       cmd.ExecuteNonQuery();
//
//       cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"DELETE FROM items WHERE items.id = @itemId;";
//       cmd.Parameters.AddWithValue("@itemId", id);
//       cmd.ExecuteNonQuery();
//       DB.Close(conn);
//     }
//
//
//
//   }
//
//
//
//
// }
