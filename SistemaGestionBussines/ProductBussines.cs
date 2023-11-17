using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussines
{
    public static class ProductBussines
    {
        public static List<Product> LoadProduct()
        {
            return ProductData.LoadProduct();
        }
        public static void CreateProduct(Product product)
        {
            ProductData.CreateProduct(product);
        }
        public static void UpdateProduct(Product product)
        {
            ProductData.UpdateProduct(product);
        }
        public static void DeleteProduct(Product product)
        {
            ProductData.DeleteProduct(product);

        }
    }
}
