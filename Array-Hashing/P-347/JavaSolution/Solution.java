import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public int[] topKFrequent(int[] nums, int k) 
    {
        
        HashMap<Integer,Integer> hashMap = new HashMap<Integer,Integer>();

        for(int n:nums)
        {
            if(hashMap.containsKey(n))
            {
                hashMap.replace(n, hashMap.get(n)+1);
            }
            else
            {
                hashMap.put(n,1);
            }
        }

        ArrayList<ArrayList<Integer>> Freq_Array = new ArrayList<ArrayList<Integer>>(nums.length);

        for (int i = 0; i < nums.length; i++) 
        {
            Freq_Array.add(new ArrayList<>());
        }

        for(int Key : hashMap.keySet())
        {

            Freq_Array.get(hashMap.get(Key)-1).add(Key);

        }

        int[] result = new int[k];

        for(int index = nums.length -1 ; index > -1; index--)
        {
            if(Freq_Array.get(index).size()!=0)
            {
                for(int Freq_index = 0; Freq_index < Freq_Array.get(index).size(); Freq_index++)
                {
                    if(k<=0)
                    {
                        break;
                    }
                    else
                    {
                        result[k-1] = Freq_Array.get(index).get(Freq_index);
                        k--;
                    }
                }
            }
            else
            {
                continue;
            }

            if(k<=0)
            {
                break;
            }
        }
        
        return result;

    }
}