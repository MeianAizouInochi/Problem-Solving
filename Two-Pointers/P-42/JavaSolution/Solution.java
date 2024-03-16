import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("YO this works!");
    }

    public int trap(int[] height) 
    {
        int[] LeftMaxPos = new int[height.length];
        int LeftMax = 0;

        for(int index = 0; index<height.length; index++)
        {
            LeftMaxPos[index] = (LeftMax>height[index]) ? LeftMax:0;
            LeftMax = (LeftMax>height[index])?LeftMax:height[index];
        }

        int[] RightMaxPos = new int[height.length];
        int RightMax = 0;

        for(int index = height.length-1; index>-1; index--)
        {
            RightMaxPos[index] = (RightMax > height[index])?RightMax:0;
            RightMax = (RightMax>height[index])?RightMax:height[index];
        }

        int result = 0;

        for(int index = 0; index < height.length; index++)
        {
            int temp = (LeftMaxPos[index] > RightMaxPos[index])? RightMaxPos[index]:LeftMaxPos[index];

            result += (height[index]>temp)?0:temp-height[index];
        }

        return result;
    }
}