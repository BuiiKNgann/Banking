using bank.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bank.Controller
{
    internal class BranchController : IController
    {
        // Thay đổi connectionString theo dạng server
        readonly string connectionString = "server=NGANBUI2003; Initial Catalog=Banking; Integrated Security=True; TrustServerCertificate=True;";
        List<IModel> branches = new List<IModel>();

        public List<IModel> Items => branches;

        public bool IsExist(object model)
        {
            if (model is AccountModel branch)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM BRANCH WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", branch.id);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            branches.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BRANCH ORDER BY id ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BranchModel branch = new BranchModel
                            
                            {
                                id = reader.GetString(0),
                                name = reader.GetString(1),
                                house_no = reader.GetString(2),
                                city = reader.GetString(3)
                            };
                            branches.Add(branch);
                        }
                    }
                }
            }
            return branches.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM BRANCH WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BranchModel branch = new BranchModel
                            {
                                id = reader.GetString(0),
                                name = reader.GetString(1),
                                house_no = reader.GetString(2),
                                city = reader.GetString(3)
                            };
                            branches.Clear();
                            branches.Add(branch);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool Create(IModel model)
        {
            if (model is BranchModel branch)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO BRANCH (id, name, house_no, city) VALUES (@id, @name, @house_no, @city)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", branch.id);
                        command.Parameters.AddWithValue("@name", branch.name);
                        command.Parameters.AddWithValue("@house_no", branch.house_no);
                        command.Parameters.AddWithValue("@city", branch.city);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is BranchModel branch)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM BRANCH WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", branch.id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is BranchModel branch)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BRANCH WHERE Id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", branch.id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BranchModel
                                {
                                    id = reader.GetString(0),
                                    name = reader.GetString(1),
                                    house_no = reader.GetString(2),
                                    city = reader.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        public bool Update(IModel model)
        {
            if (model is not BranchModel branch)
            {
                Console.WriteLine("Model không hợp lệ.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE BRANCH SET Name = @name, house_no = @house_no, City = @city WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", branch.id);
                        command.Parameters.AddWithValue("@name", branch.name);
                        command.Parameters.AddWithValue("@house_no", branch.house_no);
                        command.Parameters.AddWithValue("@city", branch.city);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
