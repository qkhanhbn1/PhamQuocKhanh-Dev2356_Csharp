namespace Bai2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số tiền gốc (VNĐ): ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập lãi suất năm (%): ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số tháng gửi: ");
            int months = Convert.ToInt32(Console.ReadLine());

            // Tính lãi suất tháng
            double monthlyInterestRate = (annualInterestRate / 12) / 100;

            Console.WriteLine("\nTháng\tTiền gốc + Lãi\t\tLãi Tháng");
            Console.WriteLine("------------------------------------------------");

            double totalInterest = 0; 

            for (int i = 1; i <= months; i++)
            {
                // Tính lãi tháng hiện tại
                double interest = principal * monthlyInterestRate;

                // Cộng lãi vào tiền gốc
                principal += interest;

                // Cộng lãi vào tổng tiền lãi tích lũy
                totalInterest += interest;

                // Hiển thị thông tin từng tháng
                Console.WriteLine($"{i}\t{principal:F2}\t\t{interest:F2}");
            }

            // Hiển thị tổng tiền lãi cuối kỳ
            Console.WriteLine("\nTổng tiền lãi cuối kỳ: " + totalInterest.ToString("F2") + " VNĐ");
            Console.WriteLine("Số dư cuối kỳ: " + principal.ToString("F2") + " VNĐ");
        }
    }
}
