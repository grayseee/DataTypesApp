using System.Net.Http.Headers;

namespace DataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the pieces of Apple");
            int pieces;
            pieces = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Total price of Apple");
            double price;
            price = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Total price of {pieces} apple(s) is {price}" );
            int convert = (int)price;
            Console.WriteLine($"The Value of original price is {price}");
            Console.WriteLine($"The Value of converted price is {convert}");
            Console.WriteLine("Press amy key to Exit.....");
            Console.ReadKey();





        }
    }
}