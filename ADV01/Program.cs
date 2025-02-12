namespace ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q02
            int[] Numbers = { 1, 2, 3, 4, 5 };
            Helper<int>.Reverse(Numbers);
            #endregion

            #region Q03
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //Helper.GetOddNumbers(Numbers);
            #endregion

            #region Q04
            FixedSizeList<int> numbers = new FixedSizeList<int>(3);

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            #endregion

        }
    }
}
