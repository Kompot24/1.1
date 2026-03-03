namespace ConsoleApp2
{
    public class Logic
    {
        public static string FindMaxDigit(int number)
        {
            string outMessage = "";
            int first = number / 100;
            int second = (number - 100 * first) / 10;
            int third = number - (first * 100 + second * 10);
            if (first >= second && first >= third)
            {
                outMessage = $"Наибольшее {first}";
            }
            else if (second >= first && second >= third)
            {
                outMessage = $"Наибольшее {second}";
            }
            else if (third >= first && third >= second)
            {
                outMessage = $"Наибольшее {third}";
            }
            return outMessage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1
            Console.WriteLine("Число: ");
            var numb = int.Parse(Console.ReadLine());

            var outMessage = Logic.FindMaxDigit(numb);

            Console.WriteLine(outMessage);
        }

    }
}
