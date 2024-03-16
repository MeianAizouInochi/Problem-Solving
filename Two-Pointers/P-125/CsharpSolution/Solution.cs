namespace CsharpSolution
{
    public class Solution
    {
        //problem - 
        /*
            A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

            Given a string s, return true if it is a palindrome, or false otherwise.

            Link - {https://leetcode.com/problems/valid-palindrome/description/}
        */
        public bool IsPalindrome(string s) 
        {
            //a-z = 97-122
            //A-Z = 65 - 90 //not needed after conversion to all lowercase.
            //0-9 = 48 - 57

            s = s.ToLower();

            int LeftPointer = 0;
            int RightPointer = s.Length-1;

            while(LeftPointer<=RightPointer)
            {
                bool GoodCharLeft = (s[LeftPointer]>=97 && s[LeftPointer]<=122) || (s[LeftPointer]>=48 && s[LeftPointer]<=57);
                bool GoodCharRight =(s[RightPointer]>=97 && s[RightPointer]<=122) || (s[RightPointer]>=48 && s[RightPointer]<=57);

                if(GoodCharLeft && GoodCharRight)
                {
                    if(s[LeftPointer].Equals(s[RightPointer]))
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
}