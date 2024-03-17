class Solution:
    def findMin(self, nums: List[int]) -> int:

        if nums[0]==nums[len(nums)-1]:
            return nums[0]
        else:
            LowerIndex = 0
            HigherIndex = len(nums)-1
            while LowerIndex<=HigherIndex:
                if LowerIndex==HigherIndex:
                    return nums[LowerIndex]
                else:
                    mid = (LowerIndex+HigherIndex)//2

                    LeftToMid = nums[LowerIndex] <= nums[mid]
                    MidtoRight = nums[mid] <= nums[HigherIndex]

                    if LeftToMid and MidtoRight:
                        return nums[LowerIndex]
                    elif LeftToMid and not MidtoRight:
                        LowerIndex = mid+1
                    elif not LeftToMid and MidtoRight:
                        HigherIndex = mid
                    else:
                        return -1
            return -1