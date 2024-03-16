namespace CsharpSolution
{
    public class Solution
    {
        //problem
        /*
            Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
            
            Link - {https://leetcode.com/problems/top-k-frequent-elements/description/}
        */
        public int[] TopKFrequent(int[] nums, int k) 
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();

            foreach(int n in nums)
            {
                if(dict.ContainsKey(n))
                {
                    dict[n]+=1;
                }
                else
                {
                    dict.Add(n,1);
                }
            }

            List<int>[] FrequencyArray = new List<int>[nums.Length];

            foreach(int Key in dict.Keys)
            {
                if(FrequencyArray[dict[Key]-1]==null)
                {
                    FrequencyArray[dict[Key]-1] = new List<int>();
                    FrequencyArray[dict[Key]-1].Add(Key);
                }
                else
                {
                    FrequencyArray[dict[Key]-1].Add(Key);
                }
            }

            int[] result = new int[k];

            for(int index = nums.Length -1; index > -1; index-- )
            {
                if(FrequencyArray[index]!=null)
                {
                    for(int Freq_index = 0; Freq_index < FrequencyArray[index].Count;Freq_index++)
                    {
                        if(k<=0)
                        {
                            break;
                        }
                        else
                        {
                            result[k-1] = FrequencyArray[index][Freq_index];
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
}