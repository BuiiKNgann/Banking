using bank.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace bank.Controller
{
    internal class CustomerController : IController
    {
        readonly string connectionString = "Server=NGANBUI2003; Initial Catalog=Banking; Integrated Security=true; TrustServerCertificate=True;";
        List<IModel> customers = new List<IModel>();

        public List<IModel> Items => customers;

        public bool IsExist(object model)
        {
            if (model is CustomerModel customer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM CUSTOMER WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", customer.id);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            customers.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM CUSTOMER ORDER BY id ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerModel customer = new CustomerModel
                            {
                                id = reader.GetString(0),
                                name = reader.GetString(1),
                                phone = reader.GetString(2),
                                email = reader.GetString(3),
                                house_no = reader.GetString(4),
                                city = reader.GetString(5)
                            };
                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM CUSTOMER WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CustomerModel customer = new CustomerModel
                            {
                                id = reader.GetString(0),
                                name = reader.GetString(1),
                                phone = reader.GetString(2),
                                email = reader.GetString(3),
                                house_no = reader.GetString(4),
                                city = reader.GetString(5)
                            };
                            customers.Clear();
                            customers.Add(customer);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is CustomerModel customer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM CUSTOMER WHERE Id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", customer.id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new CustomerModel
                                {
                                    id = reader.GetString(0),
                                    name = reader.GetString(1),
                                    phone = reader.GetString(2),
                                    email = reader.GetString(3),
                                    house_no = reader.GetString(4),
                                    city = reader.GetString(5)
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
            if (model is not CustomerModel customer)
            {
                Console.WriteLine("Model không hợp lệ.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE CUSTOMER SET name = @name, phone = @phone, email=@email, house_no = @house_no, city = @city WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", customer.id);
                        command.Parameters.AddWithValue("@name", customer.name);
                        command.Parameters.AddWithValue("@phone", customer.phone);
                        command.Parameters.AddWithValue("@email", customer.email);
                        command.Parameters.AddWithValue("@house_no", customer.house_no);
                        command.Parameters.AddWithValue("@city", customer.city);

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

        public bool Create(IModel model)
        {
            if (model is CustomerModel customer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO CUSTOMER (id, name, phone, email, house_no, city) VALUES (@id, @name, @phone, @email, @house_no, @city)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", customer.id);
                        command.Parameters.AddWithValue("@name", customer.name);
                        command.Parameters.AddWithValue("@phone", customer.phone);
                        command.Parameters.AddWithValue("@email", customer.email);
                        command.Parameters.AddWithValue("@house_no", customer.house_no);
                        command.Parameters.AddWithValue("@city", customer.city);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is CustomerModel customer)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM CUSTOMER WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", customer.id);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }
    }
}
