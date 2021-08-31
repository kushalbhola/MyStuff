import json
import math
def main():
    input = [-2,1,-3,4,-1,2,1,-5,4]
    #DP: [-2, 1, -2, ]
    # output = maxSubArray(input)
    output = maxSubArray5(input)
    print(output)
def maxSubArray(nums) -> int:
    ### Algo:
    DP = {}
    DP[0] = nums[0]
    for i in range(1, len(nums)):
        test = DP[0]
        DP[i] = max(DP[i-1] + nums[i], nums[i])
    globalMax = -10000
    for d in DP:
        if DP[d] > globalMax:
            globalMax = DP[d]
    return globalMax
def maxSubArray2(nums) -> int:
    maxSubarray=-math.inf 
    for i in range(len(nums)):
        currentSubarray=0
        for j in range(i,len(nums)):
            currentSubarray+=nums[j]
            if(currentSubarray > maxSubarray):
                maxSubarray=currentSubarray
    return maxSubarray
def maxSubArray3(nums):
    DP={}
    DP[0]=nums[0]
    for i in range(1, len(nums)):
        DP[i]=max(DP[i-1]+nums[i], nums[i])
    return max(value for key, value in DP.items())
def maxSubArray4(nums):
    currentSubarray=maxSubarray=nums[0]
    for num in nums[1:]:
        currentSubarray = max(num, currentSubarray+num)
        maxSubarray=max(maxSubarray, currentSubarray)
    return maxSubarray


def maxSubArray5(nums) -> int:
        def findBestSubarray(nums, left, right):
            # Base case - empty array.
            if left > right:
                return -math.inf

            mid = (left + right) // 2
            curr = best_left_sum = best_right_sum = 0

            # Iterate from the middle to the beginning.
            for i in range(mid - 1, left - 1, -1):
                curr += nums[i]
                best_left_sum = max(best_left_sum, curr)

            # Reset curr and iterate from the middle to the end.
            curr = 0
            for i in range(mid + 1, right + 1):
                curr += nums[i]
                best_right_sum = max(best_right_sum, curr)

            # The best_combined_sum uses the middle element and
            # the best possible sum from each half.
            best_combined_sum = nums[mid] + best_left_sum + best_right_sum

            # Find the best subarray possible from both halves.
            left_half = findBestSubarray(nums, left, mid - 1)
            right_half = findBestSubarray(nums, mid + 1, right)

            # The largest of the 3 is the answer for any given input array.
            return max(best_combined_sum, left_half, right_half)
        
        # Our helper function is designed to solve this problem for
        # any array - so just call it using the entire input!
        return findBestSubarray(nums, 0, len(nums) - 1)


if __name__ == '__main__':
    main()


