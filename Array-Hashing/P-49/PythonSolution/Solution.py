class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        dict = {}
        
        for str in strs:
            char_array = [char for char in str];
            char_array.sort()
            temp_string = ''.join(char_array)
            if temp_string in dict:
                dict[temp_string].append(str)
            else:
                dict[temp_string] = []
                dict[temp_string].append(str)
        
        result = []

        for Key in dict.keys():
            result.append(dict[Key])
        
        return result
    