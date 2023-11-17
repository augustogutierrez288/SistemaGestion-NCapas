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
    public static class SoldBussines
    {
        public static List<Sold> LoadSold()
        {
           return SoldData.LoadSold();
        }

        public static void CreateSold(Sold sold)
        {
            SoldData.CreateSold(sold);
        }

        public static void UpdateSold(Sold sold)
        {
           SoldData.UpdateSold(sold);

        }

        public static void DeleteSold(Sold sold)
        {
            SoldData.DeleteSold(sold);

        }
    }
}
