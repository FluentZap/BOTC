using System;
using System.Linq;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace BOTC
{
    public partial class DB
    {

        //Items
        public static string CreateItem(Item item)
        {
            using (var db = new BOTCContext())
            {
                db.Item.Add(item);
                db.SaveChanges();
            }
            return item.Name;
        }

        public static string CreateWeapon(Item item, Weapon weapon)
        {
            using (var db = new BOTCContext())
            {
              db.Weapon.Add(weapon);
              db.SaveChanges();
            }

            using (var db = new BOTCContext())
            {
              item.Type_Id = weapon.Id;
              db.Item.Add(item);
              db.SaveChanges();
            }

            return item.Id.ToString();
        }

        public static Item GetItem(string itemId)
        {
            using (var db = new BOTCContext())
            {
                var item = db.Item.Where(b => b.Id == int.Parse(itemId)).FirstOrDefault();
                return item;
            }
        }

        public static object GetItemStats(string itemId, string type)
        {
            using (var db = new BOTCContext())
            {
              if (type == "weapon")
              {
                var weapon = db.Weapon.Where(b => b.Id == int.Parse(itemId)).FirstOrDefault();
                return weapon;
              }
            }
            return null;
        }

        public static List<Item> GetAllItem()
        {
            using (var db = new BOTCContext())
            {
                List<Item> item = db.Item.ToList();
                return item;
            }
        }

        public static void DeleteItem(string itemId)
        {
            using (var db = new BOTCContext())
            {
                var item = db.Item.Where(b => b.Id == int.Parse(itemId)).FirstOrDefault();
                db.Remove(item);
                db.SaveChanges();
            }
        }
    }

}
