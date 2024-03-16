namespace CsharpSolution
{
    public class Solution
    {
        //problem -
        /*
            Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

            You must write an algorithm that runs in O(n) time.
        */
        public int LongestConsecutive(int[] nums) 
        {
            if(nums.Length == 0)
            {
                return 0;
            }

            HashSet<int> hashSet = new HashSet<int>();

            foreach(int i in nums)
            {
                hashSet.Add(i);
            }

            HashSet<int> StartsPoints = new HashSet<int>();

            foreach(int i in hashSet)
            {
                if(!hashSet.Contains(i-1))
                {
                    StartsPoints.Add(i);
                }
            }

            int Count = 1;

            foreach(int i in StartsPoints)
            {
                int tempCount = 1;
                int temp = i;

                while(hashSet.Contains(temp+1))
                {
                    tempCount++;
                    temp++;
                }

                Count = tempCount > Count ? tempCount : Count;
            }

            return result;
        }
    }
}