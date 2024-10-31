using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank.Model
{
    internal class TransactionModel : IModel
    {
        public int id { get; set; }
        public int from_account_id { get; set; }
        public string branch_id { get; set; }
        public DateTime date_of_trans { get; set; }
        public string house_no { get; set; }
        public double amount { get; set; }
        public int to_account_id { get; set; }
        public string employee_id { get; set; }
        //public string GetTransactionDetails()
        //{
        //    return $"Giao dịch ID: {id}, Tài khoản từ: {from_account_id}, Tài khoản đến: {to_account_id}, Số tiền: {amount}, Ngày giao dịch: {date_of_trans}";
        //}

        public bool IsValidate()
        {
            return true;
        }
    }
}
