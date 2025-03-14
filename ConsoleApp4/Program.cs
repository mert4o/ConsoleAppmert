namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(7);
            numbers.AddLast(42);
            numbers.AddLast(19);
            numbers.AddLast(56);
            numbers.AddLast(88);
            numbers.AddLast(33);
            List<int> sortednumbers = new List<int>(numbers);
            sortednumbers.Sort();
            LinkedList<int> sortedList = new LinkedList<int>(sortednumbers);
            Console.WriteLine("Podreden spisyk");
            foreach (int num in sortedList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
