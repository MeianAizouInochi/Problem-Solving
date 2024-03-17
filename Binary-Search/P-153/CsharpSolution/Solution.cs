namespace CsharpSolution
{
    public class Solution
    {
        //problem - 
        /*
                Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:

                [4,5,6,7,0,1,2] if it was rotated 4 times.
                [0,1,2,4,5,6,7] if it was rotated 7 times.
                Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

                Given the sorted rotated array nums of unique elements, return the minimum element of this array.

                You must write an algorithm that runs in O(log n) time.

                Link - {https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/}
        */
        public int FindMin(int[] nums) 
        {
            if(nums[0] < nums[nums.Length-1])
            {
                return nums[0];
            }
            else
            {
                int LowerIndex = 0;
                int HigherIndex = nums.Length-1;

                while(LowerIndex<=HigherIndex)
                {
                    if(LowerIndex==HigherIndex)
                    {
                        return nums[LowerIndex];
                    }
                    else
                    {
                        int mid = (LowerIndex+HigherIndex)/2;
                        bool LeftToMid = nums[LowerIndex] <= nums[mid];
                        bool MidToRight = nums[mid] <= nums[HigherIndex];

                        if(LeftToMid && MidToRight)
                        {
                            return nums[LowerIndex];
                        }
                        else if(LeftToMid && !MidToRight)
                        {
                            LowerIndex = mid+1;
                        }
                        else if(!LeftToMid && MidToRight)
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
}