//Problem  -
    /*
        Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
        typically using all the original letters exactly once.

        Link - {https://leetcode.com/problems/valid-anagram/description/}
    */
import java.util.*;

public class Solution
{
    public static void main(String[] args)
    {
        System.out.println("Yo this works!");
    }

    public boolean isAnagram(String s, String t) {
        
        if(s.length()!=t.length())
        {
            return false;
        }
        else
        {
            HashMap<Character,Integer> hashMap = new HashMap<Character,Integer>();

            for(char c : s.toCharArray())
            {
                if(hashMap.containsKey(c))
                {
                    hashMap.replace(c, hashMap.get(c)+1);
                }
                else
                {
                    hashMap.put(c,1);
                }
            }

            for(char c : t.toCharArray())
            {
                if(hashMap.containsKey(c))
                {
                    hashMap.replace(c,hashMap.get(c)-1);

                    if(hashMap.get(c)<0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}