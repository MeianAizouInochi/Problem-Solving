import java.util.*;
public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public int maxArea(int[] height) 
    {
        int result = 0;

        int LeftPointer = 0;

        int RightPointer = height.length -1;

        while(LeftPointer<RightPointer)
        {
            int Distance = RightPointer - LeftPointer;
            int Area = Distance * ((height[RightPointer]<height[LeftPointer])?height[RightPointer]:height[LeftPointer]);

            result = (Area<result)?result:Area;

            if(height[RightPointer]<height[LeftPointer])
            {
                RightPointer--;
            }
            else if(height[RightPointer] > height[LeftPointer])
            {
                LeftPointer++;
            }
            else
            {
                LeftPointer++;
            }
        }

        return result;     
    }
}