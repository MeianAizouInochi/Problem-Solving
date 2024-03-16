import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("YO this works!");
    }

    public boolean searchMatrix(int[][] matrix, int target) 
    {
        int LowerIndex = 0;
        int HigherIndex = (matrix[0].length * matrix.length)-1;

        while(LowerIndex<=HigherIndex)
        {
            if(LowerIndex==HigherIndex)
            {
                int RowIndex = LowerIndex/matrix[0].length;
                int ColIndex = LowerIndex%matrix[0].length;

                if(matrix[RowIndex][ColIndex]==target)
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
                int mid  = (LowerIndex+HigherIndex)/2;
                int RowIndex = mid/matrix[0].length;
                int ColIndex = mid%matrix[0].length;

                if(matrix[RowIndex][ColIndex]==target)
                {
                    return true;
                }
                else if(target > matrix[RowIndex][ColIndex])
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
}