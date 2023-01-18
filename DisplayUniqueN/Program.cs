namespace DisplayUniqueN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listN = new List<int>();
            Console.WriteLine("Type numbers, type QUIT to end.");
            do
            {
                Console.WriteLine("Enter N: ");
                var input = Console.ReadLine();
                if(input == "QUIT")
                {
                    Console.WriteLine("Shut down!");
                    break;
                } else
                {
                    var number = int.Parse(input);
                    listN.Add(number);
                }
            } while (true);
            foreach(var i in listN.Distinct().ToList())
            {
                Console.WriteLine(i);
            }
        }
    }
}