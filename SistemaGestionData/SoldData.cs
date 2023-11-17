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
    public static class SoldData
    {
        public static List<Sold> LoadSold()
        {
            List<Sold> saleList = new List<Sold>();

            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";

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
                                    Sold sale = new Sold();
                                    sale.Id = Convert.ToInt32(dr["Id"]);
                                    sale.Commit = dr["Comentarios"].ToString();
                                    sale.IdUser = Convert.ToInt32(dr["IdUsuario"]);

                                    saleList.Add(sale);
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                return saleList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CreateSold(Sold sold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario); ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = sold.Commit });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = sold.IdUser });
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

        public static void UpdateSold(Sold sold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "UPDATE Venta SET Comentarios = @Comentarios, IdUsuario = @IdUsuario WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = sold.Id });
                        command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = sold.Commit });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = sold.IdUser });
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

        public static void DeleteSold(Sold sold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "DELETE Venta WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = sold.Id });

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
