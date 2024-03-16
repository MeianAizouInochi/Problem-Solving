class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:

        if len(nums)==0:
            return 0
        
        _set = set()

        for num in nums:
            _set.add(num)
        
        startpoints = []

        for num in _set:
            if num-1 in _set:
                continue
            else:
                startpoints.append(num)
        
        Count =1

        for num in startpoints:
            tempCount = 1
            tempPoint = num
            
            while tempPoint+1 in _set:
                tempCount+=1
                tempPoint+=1
            
            if Count<tempCount:
                Count = tempCount
        
        return Count