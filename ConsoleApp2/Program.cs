namespace ConsoleApp2
{
    public class Logic
    {
        public static string Compare(int numb)
        {
            string outMessage = "";
            int first = numb / 100;
            int second = (numb - 100 * first) / 10;
            int third = numb - (first * 100 + second * 10);
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
            Console.WriteLine("Число: ");
            var numb = int.Parse(Console.ReadLine());

            var outMessage = Logic.Compare(numb);

            Console.WriteLine(outMessage);
        }

    }
}
