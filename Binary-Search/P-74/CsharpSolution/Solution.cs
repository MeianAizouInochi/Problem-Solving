namespace CsharpSolution
{
    public class Solution
    {
        //problem -
        /*
            You are given an m x n integer matrix matrix with the following two properties:

            Each row is sorted in non-decreasing order.
            The first integer of each row is greater than the last integer of the previous row.
            Given an integer target, return true if target is in matrix or false otherwise.

            You must write a solution in O(log(m * n)) time complexity.
        */
        public bool SearchMatrix(int[][] matrix, int target) //I assume that the Jagged array has same array length in each row.
        {
            int LowerIndex = 0;
            int HigherIndex = (matrix.Length * matrix[0].Length)-1;

            while(LowerIndex<=HigherIndex)
            {
                if(LowerIndex==HigherIndex)
                {
                    int RowIndex = LowerIndex / matrix[0].Length;
                    int ColumnIndex = LowerIndex % matrix[0].Length;

                    if(matrix[RowIndex][ColumnIndex]==target)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    int mid = (LowerIndex+HigherIndex)/2;

                    int midRowIndex = mid / matrix[0].Length;
                    int midColumnIndex = mid % matrix[0].Length;

                    if(matrix[midRowIndex][midColumnIndex]==target)
                    {
                        return true;
                    }
                    else if(matrix[midRowIndex][midColumnIndex] < target)
                    {
                        LowerIndex = mid+1;
                    }
                    else
                    {
                        HigherIndex = mid-1;
                    }
                }
            }

            return false;

        }
        /*
        A more generalised solution is doable, where we do not assume that each row has same array size.
        The logic of this solution, is to run a binary search to first find the row in which the target might exist,
        Thereafter, we run a binary search in that specific row, to find the element, if found we return true, else false.
        */
        //Although both of these solution has O(log(m*n)) comlpexity, the generalised might perform better.
    }
}