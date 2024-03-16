import java.util.*;

public class Solution
{

    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }


    //problem
        /*
            Given an array of strings strs, group the anagrams together. You can return the answer in any order.

            An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
            typically using all the original letters exactly once.

            Link - {https://leetcode.com/problems/group-anagrams/description/}
        */

    public List<List<String>> groupAnagrams(String[] strs) 
    {
        HashMap<String, List<String>> hashMap = new HashMap<String,List<String>>();

        for(String str:strs)
        {
            char[] Temp = str.toCharArray();

            Arrays.sort(Temp);

            String s = new String(Temp);

            if(hashMap.containsKey(s))
            {
                hashMap.get(s).add(str);
            }
            else
            {
                hashMap.put(s,new ArrayList<String>());
                hashMap.get(s).add(str);
            }
        }

        List<List<String>> result = new ArrayList<List<String>>();

        for(String key : hashMap.keySet())
        {
            result.add(hashMap.get(key));
        }

        return result;
    }
}