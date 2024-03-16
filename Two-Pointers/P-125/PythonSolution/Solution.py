class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = s.lower()

        LeftPointer = 0
        RightPointer = len(s) -1

        while LeftPointer<=RightPointer:
            
            GoodCharLeft = (ord(s[LeftPointer])>=97 and ord(s[LeftPointer])<=122) or (ord(s[LeftPointer])>=48 and ord(s[LeftPointer])<=57)
            GoodCharRight = (ord(s[RightPointer])>=97 and ord(s[RightPointer])<=122) or (ord(s[RightPointer])>=48 and ord(s[RightPointer])<=57)

            if GoodCharLeft and GoodCharRight:
                if s[LeftPointer]==s[RightPointer]:
                    LeftPointer+=1
                    RightPointer-=1
                    continue
                else:
                    return False
            elif not GoodCharLeft:
                LeftPointer+=1
            elif not GoodCharRight:
                RightPointer-=1
            else:
                continue
        return True
