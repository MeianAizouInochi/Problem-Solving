using System;
using System.Collections.Generic;
namespace CsharpSolution
{
    
    //problem:
    /*
        Given an integer array nums,
        return true if any value appears at least twice in the array, and return false if every element is distinct.

        Link - {https://leetcode.com/problems/contains-duplicate/description/}
    */

    public class Solution
    {
        public bool ContainsDuplicate(int[] nums) {
            
            bool result = false;

            HashSet<int> _set = new HashSet<int>();

            foreach(int i in nums)
            {
                if(_set.Contains(i))
                {
                    return !result;
                }
                else
                {
                    _set.Add(i);
                }
            }

            return result;
        }
    }
}