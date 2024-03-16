namespace CsharpSolution
{

    //problem
    /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.

        Link - {https://leetcode.com/problems/two-sum/description/}
    */

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            for(int index = 0; index< nums.Length; index++)
            {
                if(dict.ContainsKey(target-nums[index]))
                {
                    return new int[]{dict[target-nums[index]], index};
                }
                else
                {
                    if(dict.ContainsKey(nums[index]))
                    {
                        dict[nums[index]] = index;
                    }
                    else
                    {
                        dict.Add(nums[index],index);
                    }
                }
            }
            return new int[] {-1,-1};            
        }
    }
}