class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        Pi = 1

        result = [1 for i in range(len(nums))]

        for index in range(len(nums)):
            result[index] = Pi
            Pi*=nums[index]
        
        Pi = 1

        for index in range(len(nums)-1,-1,-1):
            result[index]*=Pi
            Pi*=nums[index]

        return result