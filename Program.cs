namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine().Trim();
            int length = 0;

            if (input.Length > 0)
            {
                int lastIndex = input.LastIndexOf(' ');
                length = input.Length - lastIndex - 1;
            }
            Console.WriteLine("Length of the last word: " + length);
        }
    }
}
