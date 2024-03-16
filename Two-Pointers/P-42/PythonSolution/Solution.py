class Solution:
    def trap(self, height: List[int]) -> int:

        LeftMaxPos = []
        LeftMax = 0

        for index in range(len(height)):
            LeftMaxPos.append(LeftMax if LeftMax > height[index] else 0)
            LeftMax = LeftMax if height[index] < LeftMax else height[index]

        RightMaxPos = []
        RightMax = 0

        for index in range(len(height)-1, -1, -1):
            RightMaxPos.append(RightMax if RightMax > height[index] else 0)
            RightMax = RightMax if RightMax > height[index] else height[index]
        
        RightMaxPos.reverse()

        result = 0
        
        for index in range(len(height)):
            temp = LeftMaxPos[index] if LeftMaxPos[index] < RightMaxPos[index] else RightMaxPos[index]
            result+= (temp - height[index]) if temp > height[index] else 0
        
        return result