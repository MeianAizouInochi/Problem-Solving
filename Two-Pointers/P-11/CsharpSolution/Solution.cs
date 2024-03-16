namespace CsharpSolution
{
    public Solution
    {

        //problem - 
        /*
            You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

            Find two lines that together with the x-axis form a container, such that the container contains the most water.

            Return the maximum amount of water a container can store.

            Notice that you may not slant the container.
        */

        public int MaxArea(int[] height) 
        {
            int result=0;

            int LeftPointer = 0;
            int RightPointer = height.Length-1;

            while(LeftPointer<RightPointer)
            {
                int Distance = RightPointer - LeftPointer;
                int Area = Distance * (height[RightPointer]<height[LeftPointer]?height[RightPointer]:height[LeftPointer]);

                result = result > Area ? result : Area;

                if(height[RightPointer]<height[LeftPointer])
                {
                    RightPointer--;
                }
                else if(height[RightPointer]>height[LeftPointer])
                {
                    LeftPointer++;
                }
                else
                {
                    LeftPointer++;
                }
            }

            return result;
        }
    }
}