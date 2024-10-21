namespace Lesson26
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao và khởi tạo mảng 1 chiều
            //int[] m = { 5,8,3,0,2,1,7,8 };
            int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
            //duyệt mảng và in dữ liệu
            Console.WriteLine("Các phần tử của mảng: ");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(" {0} ", m[i]);
            }
            //tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if(max < m[i])
                {
                    max = m[i];
                }
            }
            Console.WriteLine("\nPhan tu lon nhat la: {0}", max);
            //kiểm tra mảng có đối xứng không
         
            bool kt = true; //giả sử mảng là đối xứng
            int count = m.Length;
            for (int i = 0;i < count ; i++)
            {
                if(m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }    
            }
            if (kt == true)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");
            
        }
    }
}
