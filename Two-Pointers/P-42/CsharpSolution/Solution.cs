namespace CsharpSolution
{
    public class Solution
    {
        //problem - 
        /*
            Given n non-negative integers representing an elevation map where the width of each bar is 1,
            compute how much water it can trap after raining.
        */
        public int Trap(int[] height) 
        {
            int[] LeftMaxPos = new int[height.Length];
            int LeftMax = 0;
            for(int index = 0; index < height.Length; index++)
            {
               LeftMaxPos[index] = LeftMax > height[index] ? LeftMax : 0;
               LeftMax = LeftMax >= height[index] ? LeftMax : height[index];
            }
            int[] RightMaxPos = new int[height.Length];
            
            int RightMax = 0;
            
            for(int index = height.Length -1; index > -1; index--)
            {
               RightMaxPos[index] = RightMax > height[index] ? RightMax : 0;
               RightMax = RightMax >= height[index] ? RightMax : height[index];
            }
            int result = 0;
        
            for(int index = 0; index < height.Length; index++)
            {
               int reqMax = LeftMaxPos[index] > RightMaxPos[index] ? RightMaxPos[index] : LeftMaxPos[index];
               result+= height[index] < reqMax ? reqMax - height[index] : 0;
            }
            return result;


        }
    }
}