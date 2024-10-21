namespace Ex1
{
    /// <summary>
    /// Tạo ứng dụng C# và thực hiện những công việc sau.
    /// - Khởi tạo một mảng 1 chiều số nguyên gồm 10 phần tử.
    /// - Tìm phần tử nhỏ nhất của mảng.
    /// - Đảo ngược mảng.
    /// - Sắp xếp mảng tăng hoặc giảm.
    /// - Tìm phần tử là số nguyên tố.
    /// - In ra số lượng các số dương liên tiếp nhiều nhất.
    /// - Tính trung bình cộng các phần tử dương.
    /// - Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tạo ứng dụng C# và thực hiện những công việc sau.");
            int[] arrays = { 11, 21, -31, 42, 24, 55, -33, -32, 67, 98 };

            int chon = 0;

            do
            {
                menu();
                Console.Write("Mời bạn chọn từ 1-7:\n");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1- Tìm phần tử nhỏ nhất của mảng.");
                        int min = minArrays(arrays);
                        Console.WriteLine("Min: {0}", min);
                        break;
                    case 2:
                        Console.WriteLine("2- Đảo ngược mảng.");
                        //Console.WriteLine("Array:{0}", String.Join("  ", arrays));
                        //Array.Reverse(arrays);
                        //Console.WriteLine("Reverse:"+ String.Join("  ", arrays));
                        ReverseArray(arrays);
                        break;
                    case 3:
                        Console.WriteLine("3- Sắp xếp mảng tăng hoặc giảm.");
                        SortArray(arrays);
                        ReverseArray(arrays);
                        break;
                    case 4:
                        Console.WriteLine("4- Tìm phần tử là số nguyên tố.");
                        PrintPrime(arrays);
                        break;
                    case 5:
                        Console.WriteLine("5- In ra số lượng các số dương liên tiếp nhiều nhất.");
                        int max = MaxCountPositiveNumber(arrays);
                        Console.WriteLine("Max positive number:" + max);
                        break;
                    case 6:
                        Console.WriteLine("6- Tính trung bình cộng các phần tử dương.");
                        AveragePosition(arrays);
                        break;
                    case 7:
                        Console.WriteLine("7- Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.");
                        Bai7(arrays);
                        break;
                    case 8:
                        Console.WriteLine("8- Kết thúc.");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng!");
                        break;
                }
            } while (chon != 8);

        }
        // menu chức năng của ứng dụng
        static void menu()
        {
            Console.WriteLine("-------------");
            
        }

        /// <summary>
        /// 1- Tìm phần tử nhỏ nhất của mảng.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>int</returns>
        static int minArrays(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                    min = arr[i];
            }

            return min;
        }
        /// <summary>
        /// 2- Đảo ngược mảng.
        /// </summary>
        /// <param name="arr"></param>
        static void ReverseArray(int[] arr)
        {
            Console.WriteLine("Array:{0}", String.Join("  ", arr));
            Array.Reverse(arr);
            Console.WriteLine("Reverse:" + String.Join("  ", arr));
        }
        /// <summary>
        /// 3- Sắp xếp mảng tăng hoặc giảm.
        /// </summary>
        /// <param name="arr"></param>
        static void SortArray(int[] arr)
        {
            Console.WriteLine("Mảng trước khi sắp:{0}", String.Join("  ", arr));
            Array.Sort(arr);
            Console.WriteLine("Sorted:{0}", String.Join("  ", arr));
        }
        /// <summary>
        /// 4- Tìm phần tử là số nguyên tố.
        /// </summary>
        /// <param name="arr"></param>
        static void PrintPrime(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == true)
                {
                    Console.Write(" {0} ", arr[i]);
                }
            }
            Console.WriteLine();
        }
        /// <summary>
        /// IsPrime:
        /// </summary>
        /// <param name="number"></param>
        /// <returns>bool</returns>
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 5- In ra số lượng các số dương liên tiếp nhiều nhất.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>int</returns>
        static int MaxCountPositiveNumber(int[] arr)
        {
            int maxCount = 0;
            int currentCount = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0; // Reset đếm khi gặp số không dương
                }
            }

            return maxCount;
        }

        //6
        static void AveragePosition(int[] arr)
        {
            // Tính tổng và đếm số phần tử dương
            var positiveNumbers = arr.Where(x => x > 0).ToArray();

            if (positiveNumbers.Length > 0)
            {
                double average = positiveNumbers.Average();
                Console.WriteLine($"Trung bình cộng các phần tử dương là: {average}");
            }
            else
            {
                Console.WriteLine("Không có phần tử dương trong mảng.");
            }
        }
        static void Bai7(int[] arr)
        {
            bool isAlternating = IsAlternatingArray(arr);

            if (isAlternating)
            {
                Console.WriteLine("Mảng chứa các phần tử âm dương đan xen nhau.");
            }
            else
            {
                Console.WriteLine("Mảng không đan xen giữa số âm và dương.");
            }
        }
        static bool IsAlternatingArray(int[] arr)
        {
            // Nếu mảng có ít hơn 2 phần tử, không thể đan xen
            if (arr.Length < 2) return false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Kiểm tra nếu hai phần tử liên tiếp không khác dấu
                if ((arr[i] >= 0 && arr[i + 1] >= 0) || (arr[i] < 0 && arr[i + 1] < 0))
                {
                    return false;
                }
            }
            return true;
        }


    }
}