import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("YO this Works!");
    }

    //problem
    /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.

        Link - {https://leetcode.com/problems/two-sum/description/}
    */
    public int[] twoSum(int[] nums, int target) 
    {
        HashMap<Integer,Integer> hashMap = new HashMap<Integer,Integer>();

        for(int index = 0; index < nums.length;index++)
        {
            if(hashMap.containsKey(target-nums[index]))
            {
                return new int[] {hashMap.get(target-nums[index]), index};
            }
            else
            {
                if(hashMap.containsKey(nums[index]))
                {
                    hashMap.replace(nums[index],index);
                }
                else
                {
                    hashMap.put(nums[index],index);
                }
            }
        }

        return new int[] {-1,-1};
    }
}