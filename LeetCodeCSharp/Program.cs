using LeetCodeCSharp.ArrayCode;


// 1.二分查找
Case01();
void Case01()
{
    int[] arr01 = { -1, 0, 3, 5, 9, 12 };
    int target = 9;
    int result = BinarySearch.Search(arr01, target);
    Console.WriteLine(result);
}
