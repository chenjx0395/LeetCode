using LeetCodeCSharp.ArrayCode;

//2.移除元素

Case02();
void Case02()
{
    int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
    int value = 2;
    RemoveElementCase.RemoveElement(nums, value);
}


// 1.二分查找
//Case01();
void Case01()
{
    int[] arr01 = { -1, 0, 3, 5, 9, 12 };
    int target = 9;
    int result = BinarySearch.Search(arr01, target);
    Console.WriteLine(result);
}
