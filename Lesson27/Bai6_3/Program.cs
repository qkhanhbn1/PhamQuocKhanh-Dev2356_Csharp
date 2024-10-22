namespace Bai6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
        {
            new Car("Car 1", "Red"),
            new Car("Car 2", "Blue"),
            new Car("Car 3", "Red"),
            new Car("Car 4", "Green"),
            new Car("Car 5", "Black"),
            new Car("Car 6", "Red"),
            new Car("Car 7", "White"),
            new Car("Car 8", "Yellow"),
            new Car("Car 9", "Red"),
            new Car("Car 10", "Blue")
        };

            // 1. Xóa các Car có màu Red
            cars.RemoveAll(car => car.Color.Equals("Red", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ô tô sau khi loại bỏ những chiếc có màu Red:");

            // 2. In danh sách các Car
            cars.ForEach(car => Console.WriteLine(car));
        }
    }
}
