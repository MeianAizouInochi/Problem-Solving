import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("YO this works!");
    }

    public int search(int[] nums, int target) 
    {
        int LowerIndex = 0;
        int HigherIndex = nums.length-1;

        while(LowerIndex <=  HigherIndex)
        {
            if(LowerIndex==HigherIndex)
            {
                if(target!=nums[LowerIndex])
                {
                    return -1;
                }
                else
                {
                    return LowerIndex;
                }
            }
            else
            {
                int mid = (LowerIndex+HigherIndex)/2;

                boolean WRTmid = target <= nums[mid];

                boolean LeftToMid = nums[LowerIndex] <= nums[mid];

                boolean MidToRight = nums[mid] <= nums[HigherIndex];

                if(target==nums[mid])
                {
                    return mid;
                }
                else
                {
                    if(LeftToMid && MidToRight)
                    {
                        if(target > nums[mid])
                        {
                            LowerIndex = mid+1;
                        }
                        else
                        {
                            HigherIndex = mid-1;
                        }
                    }
                    else if(LeftToMid && !MidToRight)
                    {
                        if(WRTmid)
                        {
                            if(target >= nums[LowerIndex])
                            {
                                HigherIndex = mid-1;
                            }
                            else
                            {
                                LowerIndex = mid+1;
                            }
                        }
                        else
                        {
                            LowerIndex = mid+1;
                        }
                    }
                    else if(!LeftToMid && MidToRight)
                    {
                        if(WRTmid)
                        {
                            HigherIndex = mid-1;
                        }
                        else
                        {
                            if(target <= nums[HigherIndex])
                            {
                                LowerIndex = mid+1;
                            }
                            else
                            {
                                HigherIndex = mid-1;
                            }
                        }
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
        return -1;
    }
}