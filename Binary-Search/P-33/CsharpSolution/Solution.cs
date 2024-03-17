namespace CsharpSolution
{
    public class Solution
    {
        //problem-
        /*
            There is an integer array nums sorted in ascending order (with distinct values).

            Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

            Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

            You must write an algorithm with O(log n) runtime complexity.

            Link - {https://leetcode.com/problems/search-in-rotated-sorted-array/description/}
        */

        public int Search(int[] nums, int target) 
        {
            // if(nums[0] < nums[nums.Length-1])
            // {
            //     return BinarySearch(0,nums.Length-1,nums,target);
            // }
            // else
            // {
            //     int LowerIndex = 0;
            //     int HigherIndex = nums.Length-1;

            //     int PivotIndex = -1;

            //     while(LowerIndex<=HigherIndex)
            //     {
            //         if(LowerIndex == HigherIndex)
            //         {
            //             PivotIndex = LowerIndex;
            //             break;
            //         }
            //         else
            //         {
            //             int mid = (LowerIndex+HigherIndex)/2;

            //             bool LeftToMid = nums[LowerIndex] <= nums[mid];

            //             bool MidToRight = nums[mid] <= nums[HigherIndex];

            //             if(LeftToMid && MidToRight)
            //             {
            //                 PivotIndex = LowerIndex;
            //                 break;
            //             }
            //             else if(!LeftToMid && MidToRight)
            //             {
            //                 HigherIndex = mid;
            //             }
            //             else if(LeftToMid && !MidToRight)
            //             {
            //                 LowerIndex = mid+1;
            //             }
            //             else
            //             {
            //                 PivotIndex = -1;
            //             }
            //         }
                    
            //     }

            //     if(target >= nums[PivotIndex] && target <= nums[nums.Length-1])
            //     {
            //         return BinarySearch(PivotIndex,nums.Length-1,nums,target);
            //     }
            //     else if(target <= nums[PivotIndex-1] && target >= nums[0])
            //     {
            //         return BinarySearch(0,PivotIndex-1,nums,target);
            //     }
            //     else
            //     {
            //         return -1;
            //     }

            // }


            //Different Approach Without Finding the Pivot:

            int LowerIndex = 0;

            int HigherIndex = nums.Length-1;

            
        }

        public int BinarySearch(int LowerIndex, int HigherIndex, int[] nums,int target)
        {
            while(LowerIndex <= HigherIndex)
            {
                if(LowerIndex==HigherIndex)
                {
                    if(target==nums[LowerIndex])
                    {
                        return LowerIndex;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    int mid = (LowerIndex+HigherIndex)/2;

                    if(target==nums[mid])
                    {
                        return mid;
                    }
                    else if(target > nums[mid])
                    {
                        LowerIndex = mid+1;
                    }
                    else
                    {
                        HigherIndex = mid-1;
                    }
                }
            }

            return -1;
        }
    }
}