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

        public static Item GetItem(string itemId)
        {
            using (var db = new BOTCContext())
            {
                var item = db.Item.Where(b => b.Id == int.Parse(itemId)).FirstOrDefault();
                return item;
            }
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
            }
        }
    }

}
