using System.Collections;

namespace Bai6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Tạo một hashtable lưu danh sách các ngày trong tuần với key từ 1-8
            Hashtable daysOfWeek = new Hashtable
        {
            {1, "Sunday"},
            {2, "Monday"},
            {3, "Tuesday"},
            {4, "Wednesday"},
            {5, "Thursday"},
            {6, "Friday"},
            {7, "Saturday"}
        };

            // 2. Tìm ngày "Tuesday", in ra thông báo nếu tìm thấy
            bool foundTuesday = daysOfWeek.ContainsValue("Tuesday");
            if (foundTuesday)
            {
                Console.WriteLine("Tuesday được tìm thấy.");
            }
            else
            {
                Console.WriteLine("không tìm thấy TueDay.");
            }

            // 3. In ra các ngày trong tuần bao gồm cả key và value
            Console.WriteLine("Các ngày trong tuần:");
            foreach (DictionaryEntry day in daysOfWeek)
            {
                Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
            }
        }
    }
}
