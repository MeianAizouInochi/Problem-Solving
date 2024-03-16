class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        LowerIndex = 0
        HigherIndex = (len(matrix)*len(matrix[0]))-1

        while LowerIndex<=HigherIndex:
            if LowerIndex==HigherIndex:
                RowIndex = LowerIndex//len(matrix[0])
                ColIndex = LowerIndex%len(matrix[0])

                if matrix[RowIndex][ColIndex] == target:
                    return True
                else:
                    return False
            else:
                mid = (LowerIndex+HigherIndex)//2
                RowIndex = mid//len(matrix[0])
                ColIndex = mid%len(matrix[0])

                if matrix[RowIndex][ColIndex]==target:
                    return True
                elif target > matrix[RowIndex][ColIndex]:
                    LowerIndex = mid+1
                else:
                    HigherIndex = mid-1
        
        return False