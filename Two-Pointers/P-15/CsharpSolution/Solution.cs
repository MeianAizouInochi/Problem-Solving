namespace CsharpSolution
{
    public class Solution
    {
        //problem - 
        /*
            Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

            Notice that the solution set must not contain duplicate triplets.

            Link - {https://leetcode.com/problems/3sum/description/}
        */
        public IList<IList<int>> ThreeSum(int[] nums) 
        {
            Array.Sort(nums); //nlogn

            IList<IList<int>> result = new List<IList<int>>();

            int FirstPointer = 0;
            
            List<int> prevTriplet = null;

            while(FirstPointer<=nums.Length-3)
            {
                int MidPointer = FirstPointer+1;
                int EndPointer = nums.Length -1;

                while(MidPointer<EndPointer)
                {
                    int tempSum = nums[FirstPointer]+nums[MidPointer]+nums[EndPointer];

                    if(tempSum==0)
                    {
                        IList<int> triplet = new List<int>();
                        triplet.Add(nums[FirstPointer]);
                        triplet.Add(nums[MidPointer]);
                        triplet.Add(nums[EndPointer]);

                        if(prevTriplet==null)
                        {
                            result.Add(triplet);

                            prevTriplet = new List<int>();

                            prevTriplet.Add(nums[FirstPointer]);
                            prevTriplet.Add(nums[MidPointer]);
                            prevTriplet.Add(nums[EndPointer]);


                        }
                        else
                        {
                            if(!(prevTriplet[0]==nums[FirstPointer] && prevTriplet[1]==nums[MidPointer] && prevTriplet[2]==nums[EndPointer]))
                            {
                                prevTriplet[0] = nums[FirstPointer];
                                prevTriplet[1] = nums[MidPointer];
                                prevTriplet[2] = nums[EndPointer];

                                result.Add(triplet);
                            }
                        }

                        MidPointer++;
                        EndPointer--;
                    }
                    else if(tempSum>0)
                    {
                        EndPointer--;
                    }
                    else if(tempSum<0)
                    {
                        MidPointer++;
                    }
                    else
                    {
                        continue;
                    }
                }
                int temp = FirstPointer;

                while(temp<=nums.Length-1 && nums[temp]==nums[FirstPointer])
                {
                    temp++;
                }
                
                FirstPointer = temp;                
            }

            return result;
        }
    }
}