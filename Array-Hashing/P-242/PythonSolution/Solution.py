#Problem
"""
        Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
        typically using all the original letters exactly once.

        Link - {https://leetcode.com/problems/valid-anagram/description/}
"""
class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False
        else:
            dict = {}
            for c in s:
                if c in dict:
                    dict[c]+=1
                else:
                    dict[c]=1
            
            for c in t:
                if c in dict:
                    dict[c]-=1
                    if dict[c]<0:
                        return False
                else:
                    return False
        
        return True