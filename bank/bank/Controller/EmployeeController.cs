using bank.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bank.Controller
{
    internal class EmployeeController : IController
    {
        readonly string connectionString = "Server=NGANBUI2003; Initial Catalog=Banking; Integrated Security=true; TrustServerCertificate=True;";
        List<IModel> employees = new List<IModel>();
        public EmployeeModel CurrentUser { get; private set; }

        public List<IModel> Items => employees;

        public string Login(string id, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT role FROM EMPLOYEE WHERE id = @id AND password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@password", password);

                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show("Đăng nhập thành công với quyền: " + role);
                        return role;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin.");
                        return null;
                    }
                }
            }
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public bool Create(IModel model)
        {
            if (model is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO EMPLOYEE (id, password, role) VALUES (@id, @password, @role)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", employee.id);
                        command.Parameters.AddWithValue("@password", employee.password);
                        command.Parameters.AddWithValue("@role", employee.role);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Deposit(int accountId, float amount, string employeeId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var checkEmployeeCommand = new SqlCommand("SELECT 1 FROM EMPLOYEE WHERE id = @EmployeeId", connection, transaction);
                        checkEmployeeCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                        var employeeExists = checkEmployeeCommand.ExecuteScalar() != null;

                        if (!employeeExists)
                        {
                            throw new Exception("Employee ID does not exist.");
                        }

                        var command = new SqlCommand("sp_Deposit", connection, transaction)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@AccountId", accountId);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        command.ExecuteNonQuery();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Giao dịch không thành công: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Delete(IModel id)
        {
            if (id is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM EMPLOYEE WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", employee.id);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool IsExist(object model)
        {
            if (model is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", employee.id);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            employees.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM EMPLOYEE ORDER BY id ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeModel employee = new EmployeeModel
                            {
                                id = reader.GetString(0),
                                password = reader.GetString(1),
                                role = reader.GetString(2),
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM EMPLOYEE WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            EmployeeModel employee = new EmployeeModel
                            {
                                id = reader.GetString(0),
                                password = reader.GetString(1),
                                role = reader.GetString(2),
                            };
                            employees.Clear();
                            employees.Add(employee);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is EmployeeModel employee)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM EMPLOYEE WHERE Id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", employee.id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new EmployeeModel
                                {
                                    id = reader.GetString(0),
                                    password = reader.GetString(1),
                                    role = reader.GetString(2),
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
            if (model is not EmployeeModel employee)
            {
                Console.WriteLine("Model không hợp lệ.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE EMPLOYEE SET password = @password, role = @role WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", employee.id);
                        command.Parameters.AddWithValue("@password", employee.password);
                        command.Parameters.AddWithValue("@role", employee.role);

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
