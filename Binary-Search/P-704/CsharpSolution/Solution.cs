namespace CsharpSolution
{
    public class Solution
    {
        //problem -
        /*
            Given an array of integers nums which is sorted in ascending order, and an integer target,
            write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

            You must write an algorithm with O(log n) runtime complexity.
        */
        public int Search(int[] nums, int target) //array is sorted.
        {
           /*-----------ITERATIVE APPROACH---------------*/
            int LowerIndex = 0;
            int HigherIndex = nums.Length-1;

            while(LowerIndex<=HigherIndex)
            {
                int mid = (LowerIndex+HigherIndex)/2;

                if(nums[mid]==target)
                {
                    return mid;
                }
                else if(target > nums[mid])
                {
                    LowerIndex = mid+1;
                }
                else if(target < nums[mid])
                {
                    HigherIndex = mid-1;
                }
                else
                {
                    break;
                }
            }

            return -1;


            /*----------RECURSIVE APPROACH-----------------*/
            //return RSearch(LowerIndex, HigherIndex,target,nums);

        }

        public int RSearch(int LowerIndex, int HigherIndex, int target,int[] nums)
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
            else if(LowerIndex < HigherIndex)
            {
                int mid = (LowerIndex+HigherIndex)/2;

                if(nums[mid]==target)
                {
                    return mid;
                }
                else if(target > nums[mid])
                {
                    return RSearch(mid+1,HigherIndex,target,nums);
                }
                else
                {
                    return RSearch(LowerIndex,mid-1,target,nums);
                }
            }
            else
            {
                return -1;
            }
        }
    }
}