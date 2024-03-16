# Problem -
"""
Given an integer array nums,
 return true if any value appears at least twice in the array, and return false if every element is distinct.

 Link - {https://leetcode.com/problems/contains-duplicate/description/}
"""

class Solution:
    def containsDuplicate(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """
        Result = False

        Set = set()

        for i in nums:
            if i in Set:
                return not Result
            else:
                Set.add(i)
        return Result
