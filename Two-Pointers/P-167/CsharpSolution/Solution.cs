namespace CsharpSolution
{
    public class Solution
    {
        //problem -
        /*
            Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

            Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

            The tests are generated such that there is exactly one solution. You may not use the same element twice.

            Your solution must use only constant extra space.

            Link - {https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/}
        */
        public int[] TwoSum(int[] numbers, int target) 
        {
            int LeftPointer = 0;
            int RightPointer = numbers.Length -1;

            while(LeftPointer<RightPointer)
            {
                int tempSum = numbers[LeftPointer]+numbers[RightPointer];

                if(tempSum==target)
                {
                    return new int[] {LeftPointer+1,RightPointer+1};
                }
                else if(tempSum>target)
                {
                    RightPointer--;
                }
                else if(tempSum<target)
                {
                    LeftPointer++;
                }
                else
                {
                    continue;
                }
            }

            return new int[] {-1,-1};
        }
    }
}