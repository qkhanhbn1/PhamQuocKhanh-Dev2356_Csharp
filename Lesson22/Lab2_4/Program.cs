namespace Lab2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check_i;
            Console.Write("Danh sách cac so nguyen to tu 2-100: ");
            for(int i = 2;i<=100;i++)
            {
                check_i = true;
                for (int j = 2; j <= i/2; j++)
                {
                    if(i % j ==0)
                    {
                        check_i = false;
                        break;
                    }    
                }
                if (check_i)
                    Console.Write("{0} ",i);
                    
            }    
        }
    }
}
