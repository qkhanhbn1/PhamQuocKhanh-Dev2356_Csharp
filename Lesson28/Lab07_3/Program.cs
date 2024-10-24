namespace Lab07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];
            //nhập mảng
            try
            {
                for (int i = 0;i<=5;i++)
                {
                    Console.Write("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());

                }    
            }
            catch(FormatException ex)
            {
                Console.WriteLine("khong duoc nhap ki tu cho mảng số!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("khong duoc nhap gia tri nam ngoai mien 0-255");
            } 
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Loi vượt quá phạm vi của mảng");
            }
            //in mảng
            Console.WriteLine("Noi dung mang");
            for (int i = 0; i<5;i++)
                Console.Write(" {0}", a[i]);
        }
    }
}
