import java.util.*;
public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public int longestConsecutive(int[] nums) 
    {
        if(nums.length==0)
        {
            return 0;
        }

        HashSet<Integer> hashSet = new HashSet<Integer>();

        for(int num : nums)
        {
            hashSet.add(num);
        }

        ArrayList<Integer> StartingPoints = new ArrayList<Integer>();

        for(int num : hashSet)
        {
            if(!hashSet.contains(num-1))
            {
                StartingPoints.add(num);
            }
        }

        int Count = 1;

        for(int StartingPoint : StartingPoints)
        {
            int tempCount = 1;

            int tempPoint = StartingPoint;

            while(hashSet.contains(tempPoint+1))
            {
                tempCount++;
                tempPoint++;
            }

            Count = (tempCount>Count)?tempCount:Count;
        }

        return Count;
    }
}