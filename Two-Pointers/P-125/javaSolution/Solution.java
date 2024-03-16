import java.util.*;

public class Solution
{
    public static void main(string[] args)
    {
        System.out.println("Yo this works!");
    }

    public boolean isPalindrome(String s) 
    {
        
        //97-122
        //48-57

        s = s.toLowerCase();

        int LeftPointer = 0;
        int RightPointer = s.length()-1;

        while(LeftPointer<=RightPointer)
        {
            boolean GoodCharLeft = (s.charAt(LeftPointer)>=97 && s.charAt(LeftPointer)<=122)||(s.charAt(LeftPointer)>=48 && s.charAt(LeftPointer)<=57);
            boolean GoodCharRight = (s.charAt(RightPointer)>=97 && s.charAt(RightPointer)<=122)||(s.charAt(RightPointer)>=48 && s.charAt(RightPointer)<=57);

            if(GoodCharLeft && GoodCharRight)
            {
                if(s.charAt(LeftPointer)==s.charAt(RightPointer))
                {
                    LeftPointer++;
                    RightPointer--;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            else if(!GoodCharLeft)
            {
                LeftPointer++;
            }
            else if(!GoodCharRight)
            {
                RightPointer--;
            }
        }
        return true;
    }
}