namespace EnterUniqueN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfN = new List<int>();
            do
            {
                Console.WriteLine("Enter five numbers \n");
                Console.WriteLine($"Enter number 1: ");
                var number = int.Parse(Console.ReadLine());
                listOfN.Add(number);
                for (int j = 2; j <= 5;)
                {
                    Console.WriteLine($"Enter number {j}: ");
                    number = int.Parse(Console.ReadLine());
                    if (listOfN.Contains(number))
                    {
                        Console.WriteLine("Re-enter...");
                    }
                    else
                    {
                        listOfN.Add(number);
                        j++;
                    }
                } break;
            } while (true);
            listOfN.Sort();
            Console.WriteLine(String.Join(", ", listOfN));
        }
    }
}