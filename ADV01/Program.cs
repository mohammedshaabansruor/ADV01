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
            int[] Numbers = { 1, 2, 3, 4, 5 };
            Helper.GetOddNumbers(Numbers);
            #endregion

        }
    }
}
