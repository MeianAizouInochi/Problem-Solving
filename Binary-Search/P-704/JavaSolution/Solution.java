import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public int search(int[] nums, int target) 
    {
        /*------------ITERATIVE APPROACH------------ */

        int LowerIndex = 0;
        int HigherIndex = nums.length-1;

        while(LowerIndex<=HigherIndex)
        {
            int mid = (LowerIndex+HigherIndex)/2;

            if(nums[mid]==target)
            {
                return mid;
            }
            else if(target < nums[mid])
            {
                HigherIndex  = mid-1;
            }
            else
            {
                LowerIndex = mid+1;
            }
        }
        return -1;

        /*--------------------RECURSIVE APPROACH-------------- */

        //return RSearch(LowerIndex,HigherIndex,target,nums);
    }

    public int RSearch(int LowerIndex, int HigherIndex, int target, int[] nums)
    {
        if(LowerIndex==HigherIndex)
        {
            if(nums[LowerIndex]==target)
            {
                return LowerIndex;
            }
            else
            {
                return -1;
            }
        }
        else if(LowerIndex<HigherIndex)
        {
            int mid = (LowerIndex+HigherIndex)/2;

            if(nums[mid]==target)
            {
                return mid;
            }
            else if(target < nums[mid])
            {
                return RSearch(LowerIndex,mid-1,target,nums);
            }
            else
            {
                return RSearch(mid+1,HigherIndex,target,nums);
            }
        }
        else
        {
            return -1;
        }
    }
}