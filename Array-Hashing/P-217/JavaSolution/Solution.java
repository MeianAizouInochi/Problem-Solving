import java.util.*;
public class Solution
{
    /**
     * Problem - 
     * Given an integer array nums,
     *  return true if any value appears at least twice in the array, and return false if every element is distinct.
     * 
     * constraints:
     * 1<= nums.length <= 10^5
     * -10^9 <=nums[i] <=10^9
     * 
     * 
     * Problem Link :{https://leetcode.com/problems/contains-duplicate/description/}
     */

    public static void main(String[] args)
    {
        System.out.println("Yo it works!");
    }

    //Method for the Solution to the problem.
    public boolean containsDuplicate(int[] nums) {
        boolean result = false;

        HashSet<Integer> set = new HashSet<Integer>();

        for(int value:nums)
        {
            if(set.contains(value))
            {
                return !result;
            }
            else
            {
                set.add(value);
            }

        }

        return result;
    }
}