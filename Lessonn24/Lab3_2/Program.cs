namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact ct1 = new Contact();

            // gan gia tri cho ct1
            ct1.Id = 6;
            ct1.Firstname = "Pham Quoc";
            ct1.Lastname = "Khanh";
            ct1.Address = "BN";
            ct1.Phone = "0123456789";
            ct1.Email = "a@gmail.com";

            //tao doi tuong contact voi constructor co tham so
            Contact ct2 = new Contact(5,"Pham Quoc","Khanh2","BN2","9876543210","b@gmail.com");

            //hienthi
            ct1.Display();
            ct2.Display();
        }
    }
}
