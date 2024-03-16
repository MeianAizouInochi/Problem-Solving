import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public int minEatingSpeed(int[] piles, int h) 
    {

        int MaxElement = Arrays.stream(piles).max().getAsInt();

        if(piles.length == h)
        {
            return MaxElement;
        }
        else if(piles.length < h)
        {
            int MinElement = 1;

            int Range = MaxElement - MinElement +1;

            int LowerIndex = 0;

            int HigherIndex = Range -1;

            int result = 1;

            while(LowerIndex<=HigherIndex)
            {
                if(LowerIndex == HigherIndex)
                {
                    int EatingRate = MinElement + LowerIndex;

                    int tempHours = 0;

                    for(int n : piles)
                    {
                        if(n%EatingRate==0)
                        {
                            tempHours+=(n/EatingRate);
                        }
                        else
                        {
                            tempHours+= (n/EatingRate)+1;
                        }

                        if(tempHours > h)
                        {
                            break;
                        }
                    }

                    return (tempHours>h)?result:EatingRate;
                }
                else
                {
                    int tempHours = 0;
                    int mid = (LowerIndex+HigherIndex)/2;
                    int EatingRate = MinElement + mid;

                    for(int n : piles)
                    {
                        if(n%EatingRate==0)
                        {
                            tempHours+=(n/EatingRate);
                        }
                        else
                        {
                            tempHours+=(n/EatingRate)+1;
                        }

                        if(tempHours>h)
                        {
                            break;
                        }
                    }

                    if(tempHours>h)
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
        else
        {
            return -1;
        }
    }
}