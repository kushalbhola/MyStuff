def main():
    input = [1,4,3,2]
    output = arrayPairSum(input)
    print(output)
def arrayPairSum(nums):
    nums = sorted(nums)
    maxSoFar = 0
    i = 1
    prev = 0
    if(len(nums) == 0):
        return 0
    if(len(nums) == 1):
        return nums[0]
    
    while(i<len(nums)):
        prev = i-1
        maxSoFar = min(nums[prev], nums[i]) + maxSoFar
        i += 2
    return maxSoFar
if __name__ == '__main__':
    main()



