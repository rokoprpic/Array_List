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
                    Console.WriteLine("0 likes for post");
                    break;
                case 1:
                    Console.WriteLine($"{names[0]} likes your post");
                    break;
                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} like your post");
                    break;
                default:
                    Console.WriteLine($"{names[0]}, {names[1]} and {counter-2} people like your post");
                    break;
            }
            Console.WriteLine(counter);
        }
    }
}