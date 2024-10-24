using System;

namespace Bai07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object obj = "123";
                int num = (int)obj;  // Gây ra InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"InvalidCastException: {ex.Message}");
            }

            // IndexOutOfRangeException
            try
            {
                int[] array = new int[3];
                array[5] = 10;  // Gây ra IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
            }

            // ArrayTypeMismatchException
            try
            {
                object[] objArray = new string[3];
                objArray[0] = 100;  // Gây ra ArrayTypeMismatchException
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine($"ArrayTypeMismatchException: {ex.Message}");
            }
        }
    }
}
