using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_1
{
    internal class Account
    {
        protected decimal Balance;

        // Constructor khởi tạo với số tiền ban đầu
        public Account(decimal initialBalance)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Số tiền ban đầu không thể âm.");
            Balance = initialBalance;
        }

        // Phương thức gửi tiền
        public void Deposit(decimal money)
        {
            if (money <= 0)
                Console.WriteLine("Số tiền gửi phải lớn hơn 0.");
            else
            {
                Balance += money;
                Console.WriteLine($"Gửi thành công {money} vào tài khoản.");
            }
        }

        // Phương thức rút tiền
        public void WithDraw(decimal money)
        {
            if (money <= 0)
                Console.WriteLine("Số tiền rút phải lớn hơn 0.");
            else if (money > Balance)
                Console.WriteLine("Số dư không đủ để rút.");
            else
            {
                Balance -= money;
                Console.WriteLine($"Rút thành công {money} từ tài khoản.");
            }
        }

        // Phương thức lấy số dư
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
