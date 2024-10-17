using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_1
{
    internal class SavingAccount: Account
    {
        private decimal Rate; // Lãi suất

        // Constructor khởi tạo với số tiền ban đầu và lãi suất
        public SavingAccount(decimal initialBalance, decimal rate) : base(initialBalance)
        {
            if (rate < 0)
                throw new ArgumentException("Lãi suất không thể âm.");
            Rate = rate;
        }

        // Phương thức lấy tiền lãi
        public decimal GetInterest()
        {
            return Balance * Rate;
        }
    }
}
