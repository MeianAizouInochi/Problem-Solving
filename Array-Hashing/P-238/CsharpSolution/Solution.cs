namespace CsharpSolution
{
    public class Solution
    {
        //problem -
        /*
            Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

            The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

            You must write an algorithm that runs in O(n) time and without using the division operation.
        */
        public int[] ProductExceptSelf(int[] nums) 
        {
            int[] result = new int[nums.Length];

            int Pi = 1;

            for(int index = 0; index < nums.Length; index++)
            {
                result[index] = Pi;

                Pi*=nums[index];

            }

            Pi = 1;

            for(int index = nums.Length-1; index>-1; index--)
            {
                result[index]*=Pi;
                Pi*=nums[index];
            }

            return result;
        }
    }
}