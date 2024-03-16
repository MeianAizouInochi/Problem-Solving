import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public int[] twoSum(int[] numbers, int target) 
    {
        int LeftPointer = 0;
        int RightPointer = numbers.length-1;

        while(LeftPointer<RightPointer)
        {
            int tempSum = numbers[LeftPointer]+numbers[RightPointer];

            if(tempSum==target)
            {
                return new int[]{LeftPointer+1,RightPointer+1};
            }
            else if(tempSum<target)
            {
                LeftPointer++;
            }
            else if(tempSum>target)
            {
                RightPointer--;
            }
            else
            {
                continue;
            }
        }

        return new int[] {-1,-1};
    }
}