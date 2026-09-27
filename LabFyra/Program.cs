namespace LabFyra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vad är radien på den första cirkeln?");
            int _radie = int.Parse(Console.ReadLine());
            Console.WriteLine("Och vad är radien på den andra cirkeln?");
            int _radie2 = int.Parse(Console.ReadLine());
            var circle1 = new Circle(_radie);
            var circile2 = new Circle(_radie2);

            var area = circle1.GetArea();
            var area2 = circile2.GetArea();

            Console.WriteLine($"första cikelns area: {area : .00}");
            Console.WriteLine($"andra cirkelns area: {area2 : .00}");
        }
    }
}
