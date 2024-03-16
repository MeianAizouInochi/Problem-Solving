class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:

        nums.sort()

        result = []

        FirstPointer = 0

        prevList = []

        while FirstPointer<=len(nums)-3:

            MidPointer = FirstPointer+1
            EndPointer = len(nums)-1

            while MidPointer<EndPointer:
                tempSum = nums[FirstPointer] + nums[MidPointer] + nums[EndPointer]

                if tempSum==0:
                    triplet = []
                    triplet.append(nums[FirstPointer])
                    triplet.append(nums[MidPointer])
                    triplet.append(nums[EndPointer])

                    if len(prevList)==0:
                        
                        result.append(triplet)

                        prevList.append(nums[FirstPointer])
                        prevList.append(nums[MidPointer])
                        prevList.append(nums[EndPointer])
                    else:
                        if not (prevList[0]==nums[FirstPointer] and prevList[1]==nums[MidPointer] and prevList[2] == nums[EndPointer]):
                            result.append(triplet)

                            prevList[0] = nums[FirstPointer]
                            prevList[1] = nums[MidPointer]
                            prevList[2] = nums[EndPointer]
                    
                    MidPointer+=1
                    EndPointer-=1
                elif tempSum<0:
                    MidPointer+=1
                else: #tempSum > 0
                    EndPointer-=1
            
            temp = FirstPointer
            while temp<=len(nums)-1 and nums[temp]==nums[FirstPointer]:
                temp+=1
            
            FirstPointer = temp
        
        return result