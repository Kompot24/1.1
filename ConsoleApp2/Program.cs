namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Число: ");
            var numb = int.Parse(Console.ReadLine());
            
            int first = numb / 100;
            int second = (numb - 100 * first) / 10;
            int third = numb - (first * 100 + second * 10);
            if (first >= second && first >= third)
            {
                Console.WriteLine($"Наибольшее число - {first}");
            }
            else if (second >= first && second >= third)
            {
                Console.WriteLine($"Наибольшее число - {second}");
            }
            else if (third >= first && third >= second)
            {
                Console.WriteLine($"Наибольшее число - {third}");
            }
        }

    }
}
