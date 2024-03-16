class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        LeftPointer = 0
        RightPointer = len(numbers)-1

        while LeftPointer<RightPointer:
            tempSum = numbers[LeftPointer]+numbers[RightPointer]
            
            if tempSum==target:
                return [LeftPointer+1,RightPointer+1]
            elif tempSum<target:
                LeftPointer+=1
            elif tempSum>target:
                RightPointer-=1
            else:
                continue
        return [-1,-1]