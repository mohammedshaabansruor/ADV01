namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            Range<int> range = new Range<int>(1, 10);
            Console.WriteLine(range.IsInRange(5)); // True
            Console.WriteLine(range.IsInRange(15)); // False
            Console.WriteLine(range.Length());

            #endregion
        }
    }
}
