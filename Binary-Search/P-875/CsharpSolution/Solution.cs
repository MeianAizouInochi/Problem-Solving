namespace CsharpSolution
{
    public class Solution
    {
        //problem - 
        /*
            Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas. The guards have gone and will come back in h hours.

            Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of bananas and eats k bananas from that pile. If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.

            Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.

            Return the minimum integer k such that she can eat all the bananas within h hours.

            Link - {https://leetcode.com/problems/koko-eating-bananas/description/}
        */        
        public int MinEatingSpeed(int[] piles, int h) //1<=piles.Length<=10^4 and piles.Length <= h <= 10^9 and 1<=pile[i] <= 10^9
        {
            //T complexity = log(10^9)*10^4 = 9ln10 * 10^4 ~ 2*10^5 good Complexity.

            if(h == piles.Length)
            {
                return piles.Max();
            }
            else if(piles.Length < h)
            {
                int result = 1;

                int MaxElement = piles.Max();
                int MinElement = 1;
                
                int Range = MaxElement - MinElement +1;

                int LowerIndex = 0;
                int HigherIndex = Range -1;

                while(LowerIndex <= HigherIndex)
                {
                    if(LowerIndex==HigherIndex)
                    {
                        int EatingRate = MinElement+LowerIndex;
                        
                        int tempHours = 0;

                        foreach(int i in piles)
                        {
                            if(i%EatingRate==0)
                            {
                                tempHours+=i/EatingRate;
                            }
                            else
                            {
                                tempHours += (i/EatingRate)+1;
                            }

                            if(tempHours>h)
                            {
                                break;
                            }
                        }

                        return (tempHours > h ? result : EatingRate);
                    }
                    else
                    {
                        int mid = (LowerIndex+HigherIndex)/2;
                        
                        int EatingRate = MinElement + mid;

                        int tempHours = 0;

                        foreach(int i in piles)
                        {
                            if(i%EatingRate==0)
                            {
                                tempHours+=i/EatingRate;
                            }
                            else
                            {
                                tempHours+= (i/EatingRate)+1;
                            }

                            if(tempHours>h)
                            {
                                break;
                            }
                        }

                        if(tempHours > h)
                        {
                            LowerIndex = mid+1;
                        }
                        else
                        {
                            result = EatingRate;

                            HigherIndex = mid-1;
                        }
                    }
                }

                return result;

            }
            else{
                return -1;
            }
        }
    }
}