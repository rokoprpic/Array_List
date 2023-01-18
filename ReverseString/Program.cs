using System.Text;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");
            var name = Console.ReadLine();
            var arrayName = name.ToCharArray();
            Array.Reverse(arrayName);
            var reverseName = new string(arrayName);
            Console.WriteLine(reverseName);
        }
    }
}