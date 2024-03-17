import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("YO this works!");
    }

    public int findMin(int[] nums) 
    {
        if(nums[0] < nums[nums.length-1])
        {
            return nums[0];
        }
        else
        {
            int LowerIndex = 0;
            int HigherIndex = nums.length-1;

            while(LowerIndex<=HigherIndex)
            {
                if(LowerIndex==HigherIndex)
                {
                    return nums[LowerIndex];
                }
                else
                {
                    int mid = (LowerIndex+HigherIndex)/2;

                    boolean LefttoMid = nums[LowerIndex] <= nums[mid];

                    boolean MidtoRight = nums[mid] <= nums[HigherIndex];

                    if(LefttoMid && MidtoRight)
                    {
                        return nums[LowerIndex];
                    }
                    else if(LefttoMid && !MidtoRight)
                    {
                        LowerIndex = mid+1;
                    }
                    else if(!LefttoMid && MidtoRight)
                    {
                        HigherIndex = mid;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

            return -1;
        }
    }
}