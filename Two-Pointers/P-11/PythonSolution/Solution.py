class Solution:
    def maxArea(self, height: List[int]) -> int:
        result = 0

        LeftPointer = 0
        RightPointer = len(height)-1

        while LeftPointer<RightPointer:
            distance = RightPointer - LeftPointer
            Area = distance * (height[RightPointer] if height[RightPointer] < height[LeftPointer] else height[LeftPointer])

            result = Area if result < Area else result

            if height[RightPointer] < height[LeftPointer]:
                RightPointer-=1
            else:
                LeftPointer+=1
        
        return result