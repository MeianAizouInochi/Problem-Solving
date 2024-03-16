class Solution:
    def search(self, nums: List[int], target: int) -> int:
        
        #ITERATIVE APPROACH
        LowerIndex = 0
        HigherIndex = len(nums)-1

        while LowerIndex<=HigherIndex:
            if LowerIndex == HigherIndex:
                if nums[LowerIndex]==target:
                    return LowerIndex
                else:
                    return -1
            else:
                mid = (LowerIndex+HigherIndex)//2

                if target == nums[mid]:
                    return mid
                elif target < nums[mid]:
                    HigherIndex = mid-1
                else:
                    LowerIndex = mid+1
            
        return -1

        #RECURSIVE APPROACH
        #return self.Rsearch(LowerIndex,HigherIndex,nums,target)
    
    def Rsearch(self,LowerIndex: int, HigherIndex: int, nums: List[int], target: int) -> int:
        if LowerIndex==HigherIndex:
            if nums[LowerIndex]==target:
                return LowerIndex
            else:
                return -1
        elif LowerIndex<HigherIndex:
            mid = (LowerIndex+HigherIndex)//2

            if target == nums[mid]:
                return mid
            elif target < nums[mid]:
                return self.Rsearch(LowerIndex,mid-1,nums,target)
            else:
                return self.Rsearch(mid+1,HigherIndex,nums,target)
        else:
            return -1