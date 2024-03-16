namespace CsharpSolution
{
    public class Solution
    {
        //problem
        /*
            Given an array of strings strs, group the anagrams together. You can return the answer in any order.

            An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
            typically using all the original letters exactly once.

            Link - {https://leetcode.com/problems/group-anagrams/description/}
        */
        public IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

            //O(n(m + mlogm + m + 1 +1) = > O(nm + nmlogm + nm + n + n)) =>O(nmlogm)
            foreach(string str in strs)
            {
                char[] Temp = str.ToCharArray();

                Array.Sort(Temp);

                string hash = new string(Temp);

                if(dict.ContainsKey(hash))
                {
                    dict[hash].Add(str);
                }
                else
                {
                    dict.Add(hash, new List<string> {str});
                }
            }

            IList<IList<string>> result = new List<IList<string>>();

            //O(n)
            foreach(string s in dict.Keys)
            {
                result.Add(dict[s]);
            }
            
            //total => O(nmlogm)
            return result;
        }
    }
}