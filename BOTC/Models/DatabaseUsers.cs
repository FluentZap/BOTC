using System;
using System.Linq;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace BOTC
{
    public partial class DB
    {

        public static void CreateUser(string userName, string password, string sessionId, string privileges)
        {
            using (var db = new BOTCContext())
            {
                User user = new User() { UserName = userName, Password = password, SessionId = sessionId, Privileges = "" };
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public static bool CheckForUserById(string sessionId)
        {
            using (var db = new BOTCContext())
            {
                var user = db.User.Where(b => b.SessionId == sessionId);
                return user != null;
            }
        }

        public static bool CheckForUserByName(string userName)
        {
            using (var db = new BOTCContext())
            {
                var user = db.User.Where(b => b.UserName == userName);
                return user != null;
            }
        }

        public static User GetUser(string sessionId)
        {
            using (var db = new BOTCContext())
            {
                var user = db.User.Where(b => b.SessionId == sessionId) as User;
                return user;
            }
        }

        public static User GetUserByName(string userName)
        {
            using (var db = new BOTCContext())
            {
                var user = db.User.Where(b => b.UserName == userName) as User;
                return user;
            }
        }

        public static void UpdateUserSessionId(string userName, string sessionId)
        {
            using (var db = new BOTCContext())
            {
                var user = db.User.Where(b => b.UserName == userName) as User;
                user.SessionId = sessionId;
                db.SaveChanges();
            }           
        }

        public static bool UserLogIn(string userName, string password, string sessionId)
        {
            try
            {
                User dbUser = GetUserByName(userName);
                if (dbUser.Password == password)
                {
                    UpdateUserSessionId(userName, sessionId);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


    }
}
