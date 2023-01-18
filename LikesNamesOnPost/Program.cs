namespace LikesNamesOnPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var names = new List<string>();
            do
            {
                Console.WriteLine("Enter name: ");
                string input = Console.ReadLine();
                if (input != "")
                {
                    counter++;
                    names.Add(input);
                }
                else
                    break;
            } while (true);
            switch (counter)
            {
                case 0:
                    Console.WriteLine("No one likes you!");
                    break;
                case 1:
                    Console.WriteLine($"{names[0]} likes you");
                    break;
                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} like you");
                    break;
                default:
                    Console.WriteLine($"{names[0]}, {names[1]} and {counter-2} people like you");
                    break;
            }
            Console.WriteLine(counter);
        }
    }
}