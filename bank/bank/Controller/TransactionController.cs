using bank.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace bank.Controller
{
    internal class TransactionController : IController
    {
        readonly string connectionString = "Server=NGANBUI2003;Database=Banking;Integrated Security=True;TrustServerCertificate=True;";
        List<IModel> transactions = new List<IModel>();
        public List<IModel> Items => transactions;

        public bool Create(IModel model)
        {
            if (model is TransactionModel transaction)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [TRANSACTION] (id, from_account_id, branch_id, date_of_trans, house_no, amount, to_account_id, employee_id) VALUES (@id, @from_account_id, @branch_id, @date_of_trans, @house_no, @amount, @to_account_id, @employee_id)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", transaction.id);
                        command.Parameters.AddWithValue("@from_account_id", transaction.from_account_id);
                        command.Parameters.AddWithValue("@branch_id", transaction.branch_id);
                        command.Parameters.AddWithValue("@date_of_trans", transaction.date_of_trans);
                        command.Parameters.AddWithValue("@house_no", transaction.house_no);
                        command.Parameters.AddWithValue("@amount", transaction.amount);
                        command.Parameters.AddWithValue("@to_account_id", transaction.to_account_id);
                        command.Parameters.AddWithValue("@employee_id", transaction.employee_id);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is TransactionModel transaction)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM [TRANSACTION] WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", transaction.id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }

        public bool IsExist(object model)
        {
            if (model is TransactionModel transaction)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM [TRANSACTION] WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", transaction.id);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            transactions.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [TRANSACTION] ORDER BY id ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TransactionModel transaction = new TransactionModel
                            {
                                id = reader.GetInt32(0),
                                from_account_id = reader.GetInt32(1),
                                branch_id = reader.GetString(2),
                                date_of_trans = reader.GetDateTime(3),
                                house_no = reader.GetString(4),
                                amount = reader.GetDouble(5),
                                to_account_id = reader.GetInt32(6),
                                employee_id = reader.GetString(7),
                            };
                            transactions.Add(transaction);
                        }
                    }
                }
            }
            return transactions.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM [TRANSACTION] WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TransactionModel transaction = new TransactionModel
                            {
                                id = reader.GetInt32(0),
                                from_account_id = reader.GetInt32(1),
                                branch_id = reader.GetString(2),
                                date_of_trans = reader.GetDateTime(3),
                                house_no = reader.GetString(4),
                                amount = reader.GetDouble(5),
                                to_account_id = reader.GetInt32(6),
                                employee_id = reader.GetString(7),
                            };
                            transactions.Clear();
                            transactions.Add(transaction);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is TransactionModel transaction)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [TRANSACTION] WHERE Id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", transaction.id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new TransactionModel
                                {
                                    id = reader.GetInt32(0),
                                    from_account_id = reader.GetInt32(1),
                                    branch_id = reader.GetString(2),
                                    date_of_trans = reader.GetDateTime(3),
                                    house_no = reader.GetString(4),
                                    amount = reader.GetDouble(5),
                                    to_account_id = reader.GetInt32(6),
                                    employee_id = reader.GetString(7),
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
            if (model is TransactionModel transaction)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [TRANSACTION] SET from_account_id = @from_account_id, branch_id = @branch_id, date_of_trans = @date_of_trans, house_no = @house_no, amount = @amount, to_account_id = @to_account_id, employee_id = @employee_id WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", transaction.id);
                        command.Parameters.AddWithValue("@from_account_id", transaction.from_account_id);
                        command.Parameters.AddWithValue("@branch_id", transaction.branch_id);
                        command.Parameters.AddWithValue("@date_of_trans", transaction.date_of_trans);
                        command.Parameters.AddWithValue("@house_no", transaction.house_no);
                        command.Parameters.AddWithValue("@amount", transaction.amount);
                        command.Parameters.AddWithValue("@to_account_id", transaction.to_account_id);
                        command.Parameters.AddWithValue("@employee_id", transaction.employee_id);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            return false;
        }
    }
}
