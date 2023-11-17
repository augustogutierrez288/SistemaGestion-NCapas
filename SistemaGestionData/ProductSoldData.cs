using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;


namespace SistemaGestionData
{
    public static class ProductSoldData
    {
        public static List<ProductSold> LoadProductSold()
        {
            List<ProductSold> listProductSold = new List<ProductSold>();

            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    ProductSold productSold = new ProductSold();
                                    productSold.Id = Convert.ToInt32(dr["Id"]);
                                    productSold.Stock = Convert.ToInt32(dr["Stock"]);
                                    productSold.IdProduct = Convert.ToInt32(dr["IdProducto"]);
                                    productSold.IdSold = Convert.ToInt32(dr["IdVenta"]);

                                    listProductSold.Add(productSold);
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                return listProductSold;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CreateProductSold(ProductSold productSold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta) VALUES (@Stock,@IdProducto, @IdVenta); ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productSold.Stock });
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productSold.IdProduct });
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productSold.IdSold });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateProductSold(ProductSold productSold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "UPDATE ProductoVendido SET Stock = @Stock, IdProducto = @IdProducto, @IdVenta = @IdVenta WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = productSold.Id });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productSold.Stock });
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productSold.IdProduct });
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productSold.IdSold });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void DeleteProductSold(ProductSold productSold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "DELETE ProductoVendido WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = productSold.Id });

                        command.ExecuteNonQuery();

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
