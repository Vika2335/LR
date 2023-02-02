namespace jfkjg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            double a = Math.Abs(double.Parse(Console.ReadLine()));
            double x = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56);
            Console.Write("Введите x:");
            double x1 = Math.Abs(double.Parse(Console.ReadLine()));
            double y = Math.Sin((3.2 + Math.Sqrt(1 + x1)) / Math.Abs(5 * x1));
            Console.WriteLine($"Функция x равна {x:0.000}");
            Console.WriteLine($"Функция y равна {y:0.000}");
        }
    }
}

