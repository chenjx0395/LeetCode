using System.Data;

namespace ArrayCode
{
    public class GenerateMatrixCase
    {
        public static int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            var count = 1;
            int top = 0, right = n - 1, bottom = n - 1, left = 0;
            int rowP = -1, colP = 0;

            //向右走
            return ToRight(rowP, right, top, colP, bottom, left, result, count);
        }

        private static int[][] ToRight(int rowP, int right, int top, int colP, int bottom, int left, int[][] result, int count)
        {
            while (true)
            {
                if (rowP + 1 > right)
                {
                    //走到头后要改变边界
                    top += 1;
                    //向下走 
                    return ToBottom(colP, bottom, right, rowP, left, top, result, count);
                }
                else
                {
                    rowP += 1;
                    result[colP][rowP] = count++;
                }
            }
        }

        private static int[][] ToBottom(int colP, int bottom, int right, int rowP, int left, int top, int[][] result, int count)
        {
            while (true)
            {
                if (colP + 1 > bottom)
                {
                    //走到头后要改变边界
                    right -= 1;
                    //向左走 
                    return ToLeft(rowP, left, bottom, colP, top, right, result, count);
                }
                else
                {
                    colP += 1;
                    result[colP][rowP] = count++;
                }
            }
        }

        private static int[][] ToLeft(int rowP, int left, int bottom, int colP, int top, int right, int[][] result, int count)
        {
            while (true)
            {
                if (rowP - 1 < left)
                {
                    //走到头后要改变边界
                    bottom -= 1;
                    //向上走
                    return ToTop(bottom,colP, top, left, rowP, right, result, count);
                }
                else
                {
                    rowP -= 1;
                    result[colP][rowP] = count++;
                }
            }
        }

        private static int[][] ToTop(int bottom,int colP, int top, int left, int rowP, int right, int[][] result, int count)
        {
            //向上走 
            while (true)
            {
                if (colP - 1 < top)
                {
                    //走到头后要改变边界
                    left += 1;
                    //判断是否还可以向右走
                    if (rowP + 1 > right)
                    {
                        return result;
                    }
                    //向右走 
                    return ToRight(rowP, right, top, colP, bottom, left, result, count);
                }
                else
                {
                    colP -= 1;
                    result[colP][rowP] = count++;
                }
            }
        }
    }
}