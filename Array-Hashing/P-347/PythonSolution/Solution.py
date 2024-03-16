class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:

        dict = {}

        for n in nums:
            if n in dict:
                dict[n]+=1
            else:
                dict[n] =1
        
        Freq_List = [ [] for i in range(len(nums)) ]

        for n in dict.keys():
            Freq_List[dict[n]-1].append(n)

        result = []

        for index in range(len(nums)-1,-1,-1):

            if len(Freq_List[index])!=0:
                for inside_index,number in enumerate(Freq_List[index]):
                    if k!=0:
                        result.append(number)
                        k-=1
                    else:
                        break
            else:
                continue
            if k<=0:
                break
        
        return result
        