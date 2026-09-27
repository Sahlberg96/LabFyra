namespace LabFyra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _radie = 5;
            var circle = new Circle(_radie);

            var area = circle.GetArea();

            Console.WriteLine($"{area : .00}");
        }
    }
}
