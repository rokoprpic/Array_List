namespace ValidOrInvalidList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            var list = new List<int>();
            do
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                list.Add(int.Parse(input));
            } while (true);
            if (list.Count < 5)
            {
                Console.WriteLine("Invalid List");
            }
            else
            {
                list.Sort();
                for (int i = 0; i < list[2]; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}