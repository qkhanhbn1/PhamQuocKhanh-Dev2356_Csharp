namespace LAb01_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Viết chương trình thực hiện các yc");
            //khai báo 
            string maNV;
            string hoVaTen;
            DateTime ngaySinh;
            string diaChi;
            string dienThoai;
            string email;

            //gán giá trị
            maNV = "NV001";
            hoVaTen = "Khánh";
            ngaySinh = DateTime.Now;
            diaChi = "399 qt";
            dienThoai = "432492348329";
            email = "a@gmail.com";

            //hiển thị thoog tin 
            Console.WriteLine("==== THÔNG TIN CÁ NHÂN");
            Console.WriteLine("Mã nhân viên:"+ maNV);
            Console.WriteLine("Họ và tên: "+ hoVaTen);
            Console.WriteLine("Ngày sinh:{0}", ngaySinh);
            Console.WriteLine("Địa chỉ :" + diaChi);
            Console.WriteLine("ĐIện thoại :" + dienThoai);
            Console.WriteLine("Email : "+ email);

        }
    }
}
