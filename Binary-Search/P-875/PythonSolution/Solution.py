class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        MaxElement = max(piles)

        if len(piles)==h:
            return MaxElement
        else:
            MinElement = 1
            Range = MaxElement - MinElement +1
            LowerIndex = 0
            HigherIndex = Range -1

            result =1

            while LowerIndex <= HigherIndex:

                if LowerIndex==HigherIndex:

                    tempHours = 0

                    EatingRate = MinElement + LowerIndex

                    for n in piles:

                        if n%EatingRate==0:
                            tempHours+= n/EatingRate
                        else:
                            tempHours+= (n//EatingRate)+1

                        if tempHours > h:
                            break
                    
                    return EatingRate if tempHours <= h else result
                else:

                    mid = (LowerIndex+ HigherIndex)//2

                    EatingRate = MinElement + mid

                    tempHours = 0

                    for n in piles:

                        if n%EatingRate==0:
                            tempHours+= n/EatingRate
                        else:
                            tempHours+= (n//EatingRate)+1
                        
                        if tempHours > h:
                            break
                    
                    if tempHours > h:
                        LowerIndex = mid+1
                    else:
                        result = EatingRate
                        HigherIndex = mid-1

            return result