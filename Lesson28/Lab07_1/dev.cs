namespace Store
{
    public class StoreItem
    {
        public int ItemNo { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
    }
}
namespace Supply
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}