namespace CsharpSolution
{
    //Problem  -
    /*
        Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
        typically using all the original letters exactly once.

        Link - {https://leetcode.com/problems/valid-anagram/description/}
    */
    
    public class Solution
    {
        public bool IsAnagram(string s, string t) 
        {
            if(s.Length!=t.Length)
            {
                return false;
            }
            else
            {
                Dictionary<char,int> dict = new Dictionary<char,int>();

                foreach(char c in s)
                {
                    if(dict.ContainsKey(c))
                    {
                        dict[c]+=1;
                    }
                    else
                    {
                        dict.Add(c,1);
                    }
                }

                foreach(char c in t)
                {
                    if(dict.ContainsKey(c))
                    {
                        dict[c]-=1;
                        if(dict[c]<0)
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
}