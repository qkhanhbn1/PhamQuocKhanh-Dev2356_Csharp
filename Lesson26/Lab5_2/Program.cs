namespace Lab5_2
{
    /// <summary>
    /// Mảng 2 chiều
    /// - Khởi tạo mảng 2 chiều 4x3
    /// - Duyệt mảng và in theo ma trận hàng cột
    /// - In ra các phần tử có chỉ số hàng bằng chỉ số cột
    /// - In ra phần tử lớn nhất trên mỗi hàng
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mảng 2 chiều");
            int[,] arrays =
            {
                {4,6,8 },
                {2,4,6 },
                {9,2,6 },
                {1,6,3 }
            };

            // Duyệt mảng và in
            printArray(arrays);
            // Các phần tử trên chéo chính
            printArrayXY(arrays);
            // Max row
            printMaxRow(arrays);
        }

        static void printArray(int[,] arrays)
        {
            Console.WriteLine("Các phần tử trong mảng\n");
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arrays.GetUpperBound(1); j++)
                {
                    Console.Write(" {0} ", arrays[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Tìm các phần tử có chỉ số hàng bằng chỉ số cột
        /// (Đường chéo chính)
        /// </summary>
        /// <param name="arrays"></param>
        static void printArrayXY(int[,] arrays)
        {
            Console.WriteLine("Cac phan tu co chi so hang bang chi so cot:");
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arrays.GetUpperBound(1); j++)
                {
                    if (j == i)
                    {
                        Console.Write(" {0} ", arrays[i, j]);
                    }
                    else
                    {
                        Console.Write(" {0} ", "   ");
                    }

                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Các phần tử lớn nhất trên mỗi hàng
        /// </summary>
        /// <param name="arrays"></param>
        static void printMaxRow(int[,] arrays)
        {
            Console.WriteLine("Cac phan tu lon nhat tren hang\n");
            int maxRow = 0;
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                maxRow = arrays[i, 0];
                for (int j = 1; j <= arrays.GetUpperBound(1); j++)
                {
                    if (maxRow < arrays[i, j])
                    {
                        maxRow = arrays[i, j];
                    }
                }
                Console.WriteLine("{0}: {1}", i, maxRow);
            }
        }
    }
}
