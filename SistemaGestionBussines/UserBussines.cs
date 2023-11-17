using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;

namespace SistemaGestionBussines
{
    public static class UserBussines
    {
        public static List<User> LoadUser()
        {
            return UserData.LoadUser();
        }

        public static void CreateUser(User user)
        {
            UserData.CreateUser(user);
        }

        public static void UpdateUser(User user)
        {
            UserData.UpdateUser(user);
        }

        public static void DeleteUser(User user)
        {
            UserData.DeleteUser(user);
        }
    }
}
