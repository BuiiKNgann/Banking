    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using bank.Model;
using System.Windows.Forms;

namespace bank.Controller
{
    internal class AccountController : IController
    {
        readonly string connectionString = "server=NGANBUI2003; Initial Catalog=Banking; Integrated Security=True; TrustServerCertificate=True;";
        List<IModel> accounts = new List<IModel>();

        public List<IModel> Items => accounts;

        public bool IsExist(object model)
        {
            if (model is AccountModel account)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM ACCOUNT WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", account.id);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            return false;
        }

        public bool Load()
        {
            accounts.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ACCOUNT ORDER BY id ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountModel account = new AccountModel
                        {
                            id = reader.GetInt32(0),
                            customerid = reader.GetString(1),
                            date_opened = reader.GetDateTime(2),
                            balance = reader.GetDouble(3)
                        };
                        accounts.Add(account);
                    }
                }
            }
            return accounts.Count > 0;
        }

        public bool Load(object id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ACCOUNT WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            AccountModel account = new AccountModel
                            {
                                id = reader.GetInt32(0),
                                customerid = reader.GetString(1),
                                date_opened = reader.GetDateTime(2),
                                balance = reader.GetDouble(3)
                            };
                            accounts.Clear();
                            accounts.Add(account);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public IModel Read(IModel id)
        {
            if (id is AccountModel account)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ACCOUNT WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", account.id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new AccountModel
                                {
                                    id = reader.GetInt32(0),
                                    customerid = reader.GetString(1),
                                    date_opened = reader.GetDateTime(2),
                                    balance = reader.GetDouble(3)
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
            if (model is not AccountModel account)
            {
                Console.WriteLine("Model không hợp lệ.");
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE ACCOUNT SET customerid = @customerid, date_opened = @date_opened, balance = @balance WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", account.id);
                        command.Parameters.AddWithValue("@customerid", account.customerid);
                        command.Parameters.AddWithValue("@date_opened", account.date_opened);
                        command.Parameters.AddWithValue("@balance", account.balance);

                        return command.ExecuteNonQuery() > 0;
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
            if (model is AccountModel account)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ACCOUNT (id, customerid, date_opened, balance) VALUES (@id, @customerid, @date_opened, @balance)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", account.id);
                        command.Parameters.AddWithValue("@customerid", account.customerid);
                        command.Parameters.AddWithValue("@date_opened", account.date_opened);
                        command.Parameters.AddWithValue("@balance", account.balance);

                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            return false;
        }

        public bool Delete(IModel id)
        {
            if (id is AccountModel account)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM ACCOUNT WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", account.id);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            return false;
        }

        public double GetBalance(string accountId)
        {
            double balance = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT balance FROM ACCOUNT WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", accountId);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            balance = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return balance;
        }

        public bool Deposit(string accountId, double amount)
        {
            if (amount <= 0) return false;

            double currentBalance = GetBalance(accountId);
            double newBalance = currentBalance + amount;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE ACCOUNT SET balance = @balance WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", accountId);
                    command.Parameters.AddWithValue("@balance", newBalance);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Withdraw(string accountId, double amount)
        {
            if (amount <= 0) return false;

            double currentBalance = GetBalance(accountId);
            if (currentBalance < amount) return false;

            double newBalance = currentBalance - amount;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE ACCOUNT SET balance = @balance WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", accountId);
                    command.Parameters.AddWithValue("@balance", newBalance);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Transfer(string fromAccountId, string toAccountId, double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid transfer amount.");
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        double senderBalance = GetBalance(fromAccountId);
                        if (senderBalance < amount)
                        {
                            Console.WriteLine("Số Dư Không Đủ.");
                            return false;
                        }

                        double recipientBalance = GetBalance(toAccountId);

                        string updateSenderQuery = "UPDATE ACCOUNT SET balance = @balance WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(updateSenderQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@id", fromAccountId);
                            command.Parameters.AddWithValue("@balance", senderBalance - amount);
                            command.ExecuteNonQuery();
                        }

                        string updateRecipientQuery = "UPDATE ACCOUNT SET balance = @balance WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(updateRecipientQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@id", toAccountId);
                            command.Parameters.AddWithValue("@balance", recipientBalance + amount);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Console.WriteLine("Chuyển Thành công.");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Transfer failed: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public List<AccountModel> GetAllAccounts()
        {
            List<AccountModel> accountList = new List<AccountModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ACCOUNT ORDER BY id ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AccountModel account = new AccountModel
                        {
                            id = reader.GetInt32(0),
                            customerid = reader.GetString(1),
                            date_opened = reader.GetDateTime(2),
                            balance = reader.GetDouble(3)
                        };
                        accountList.Add(account);
                    }
                }
            }
            return accountList;
        }
    }
}
