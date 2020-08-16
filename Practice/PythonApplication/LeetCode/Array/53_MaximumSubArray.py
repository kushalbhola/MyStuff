import json
def main():
    input = [-2,1,-3,4,-1,2,1,-5,4]
    output = maxSubArray(input)
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
if __name__ == '__main__':
    main()


