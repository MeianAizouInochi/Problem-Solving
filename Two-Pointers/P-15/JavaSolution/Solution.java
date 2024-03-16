import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public List<List<Integer>> threeSum(int[] nums) 
    {
        
        Arrays.sort(nums);

        List<List<Integer>> result = new ArrrayList<List<Integer>>();

        int FirstPointer = 0;

        ArrayList<Integer> prevTriplet = null;

        while(FirstPointer<=nums.length-3)
        {
            int MidPointer = FirstPointer+1;
            int EndPointer = nums.length -1;

            while(MidPointer<EndPointer)
            {
                int tempSum = nums[FirstPointer] + nums[MidPointer] + nums[EndPointer];

                if(tempSum==0)
                {   
                    List<Integer> triplet = ArrayList<Integer>();
                    triplet.add(nums[FirstPointer]);
                    triplet.add(nums[MidPointer]);
                    triplet.add(nums[EndPointer]);

                    if(prevTriplet==null)
                    {
                        result.add(triplet);

                        prevTriplet = new ArrayList<Integer>();
                        prevTriplet.add(nums[FirstPointer]);
                        prevTriplet.add(nums[MidPointer]);
                        prevTriplet.add(nums[EndPointer]);
                    }
                    else
                    {
                        if(!(prevTriplet.get(0)==nums[FirstPointer] && prevTriplet.get(1)==nums[MidPointer] && prevTriplet.get(2)==nums[EndPointer]))
                        {
                            result.add(triplet)

                            prevTriplet.set(0,nums[FirstPointer]);
                            prevTriplet.set(1,nums[MidPointer]);
                            prevTriplet.set(2,nums[EndPointer]);
                        }
                    }

                    MidPointer++;
                    EndPointer--;
                }
                else if(tempSum<0)
                {
                    MidPointer++;
                }
                else //tempSum>0
                {
                    EndPointer--;
                }
            }

            int temp = FirstPointer;

            while(temp<=nums.length-1 && nums[temp]==nums[FirstPointer])
            {
                temp++;
            }

            FirstPointer = temp;
        }
        return result;
    }
}