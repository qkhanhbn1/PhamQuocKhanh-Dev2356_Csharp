namespace Bai4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000);
            account.Deposit(500);
            account.WithDraw(200);
            Console.WriteLine($"Số dư tài khoản thường: {account.GetBalance()}");

            // Khởi tạo tài khoản tiết kiệm với lãi suất 5%
            SavingAccount savingAccount = new SavingAccount(1000, 0.05m);
            Console.WriteLine($"Tiền lãi của tài khoản tiết kiệm: {savingAccount.GetInterest()}");

            // Khởi tạo tài khoản vãng lai với phí giao dịch 10
            CheckAccount checkAccount = new CheckAccount(1000, 10);
            checkAccount.WithDraw(100);
            Console.WriteLine($"Số dư tài khoản vãng lai: {checkAccount.GetBalance()}");
        }
    }
}
