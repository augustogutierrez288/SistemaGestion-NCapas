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
    public static class ProductSoldBussines
    {
        public static List<ProductSold> LoadProductSold()
        {
            return ProductSoldData.LoadProductSold();
        }

        public static void CreateProductSold(ProductSold productSold)
        {
           ProductSoldData.CreateProductSold(productSold);
        }

        public static void UpdateProductSold(ProductSold productSold)
        {
            ProductSoldData.UpdateProductSold(productSold);
        }

        public static void DeleteProductSold(ProductSold productSold)
        {
            ProductSoldData.DeleteProductSold(productSold);
        }

    }
}
