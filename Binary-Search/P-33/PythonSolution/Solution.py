class Solution:
    def search(self, nums: List[int], target: int) -> int:
        LowerIndex = 0
        HigherIndex = len(nums)-1

        while LowerIndex <= HigherIndex:

            if LowerIndex==HigherIndex:
                if target!=nums[LowerIndex]:
                    return -1
                else:
                    return LowerIndex
            else:
                mid = (LowerIndex+HigherIndex)//2

                WRTmid = target <= nums[mid]

                LeftToMid = nums[LowerIndex] <= nums[mid]

                MidToRight = nums[mid] <= nums[HigherIndex]

                if target == nums[mid]:
                    return mid
                else:
                    if LeftToMid and MidToRight:
                        if target < nums[mid]:
                            HigherIndex = mid -1
                        else:
                            LowerIndex = mid+1
                    elif LeftToMid and not MidToRight:
                        if WRTmid:
                            if target >= nums[LowerIndex]:
                                HigherIndex = mid-1
                            else:
                                LowerIndex = mid+1
                        else:
                            LowerIndex = mid+1
                    elif not LeftToMid and MidToRight:
                        if WRTmid:
                            HigherIndex = mid-1
                        else:
                            if target <= nums[HigherIndex]:
                                LowerIndex = mid+1
                            else:
                                HigherIndex = mid -1
                    else:
                        return -1
        return -1