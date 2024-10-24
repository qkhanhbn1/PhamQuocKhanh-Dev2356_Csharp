namespace Bai07_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bo = new AnCo.Bo(1, "Bò", 500);
            var trau = new AnCo.Trau(2, "Trâu", 700);
            var de = new AnCo.De(3, "Dê", 60);
            var caSau = new AnThit.CaSau(4, "Cá Sấu", 250);
            var ho = new AnThit.Ho(5, "Hổ", 200);
            var suTu = new AnThit.SuTu(6, "Sư Tử", 190);

            Console.WriteLine($"id:{bo.ID} {bo.Name}: {bo.Weight}kg");
            Console.WriteLine($"id:{trau.ID} {trau.Name}: {trau.Weight}kg");
            Console.WriteLine($"id:{de.ID} {de.Name}: {de.Weight}kg");
            Console.WriteLine($"id:{caSau.ID} {caSau.Name}: {caSau.Weight}kg");
            Console.WriteLine($"id:{ho.ID} {ho.Name}: {ho.Weight}kg");
            Console.WriteLine($"id:{suTu.ID} {suTu.Name}: {suTu.Weight}kg");
        }
    }
}
