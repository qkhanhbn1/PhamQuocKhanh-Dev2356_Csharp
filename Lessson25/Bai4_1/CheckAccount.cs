using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_1
{
    internal class CheckAccount:Account
    {
        private decimal FeeTransfer; // Phí giao dịch

        // Constructor khởi tạo với số tiền ban đầu và phí giao dịch
        public CheckAccount(decimal initialBalance, decimal fee) : base(initialBalance)
        {
            if (fee < 0)
                throw new ArgumentException("Phí giao dịch không thể âm.");
            FeeTransfer = fee;
        }

        // Ghi đè phương thức rút tiền để trừ phí giao dịch
        public new void WithDraw(decimal money)
        {
            decimal totalAmount = money + FeeTransfer;
            if (totalAmount > Balance)
                Console.WriteLine("Số dư không đủ để rút và trả phí giao dịch.");
            else
            {
                Balance -= totalAmount;
                Console.WriteLine($"Rút thành công {money} từ tài khoản (phí giao dịch {FeeTransfer}).");
            }
        }
    }
}
