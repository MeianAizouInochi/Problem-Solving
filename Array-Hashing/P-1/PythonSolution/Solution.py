"""
//problem
    /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.

        Link - {https://leetcode.com/problems/two-sum/description/}
    */
"""
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        dict = {}

        for index,value in enumerate(nums):
            if (target - value) in dict:
                return [dict[target - value], index]
            else:
                if value in dict:
                    dict[value] = index
                else:
                    dict[value] = index
        
        return [-1,-1]