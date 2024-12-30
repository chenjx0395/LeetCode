namespace HashTableCode
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 快乐数
            // Case1();
            // 两数之和
            Case2();
        }


        public static void Case2()
        {
            new TwoSumCase().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        }

        public static void Case1()
        {
            IsHappyCase.IsHappy(19);
        }
    }
}