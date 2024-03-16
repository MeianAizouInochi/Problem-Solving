import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public int[] productExceptSelf(int[] nums) 
    {
        int Pi = 1;

        int[] result = new int[nums.length];

        for(int index = 0; index< nums.length; index++)
        {
            result[index] = Pi;
            Pi*=nums[index];
        }

        Pi = 1;

        for(int index = nums.length -1; index>-1; index--)
        {
            result[index]*=Pi;
            Pi*=nums[index];
        }

        return result;
    }
}