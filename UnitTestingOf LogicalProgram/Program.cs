namespace UnitTestingOf_LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs :\n");
            LogicalPrograms logicalPrograms = new LogicalPrograms();
            logicalPrograms.FibonacciSeries(7);
            logicalPrograms.PerfectNumber(29);
            logicalPrograms.PrimeNumber(42);
            logicalPrograms.ReverseNumber(49);
        }
    }
}