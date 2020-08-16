def main():
    print("python main function")
    nums = [230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789]
    target = 542
    result = twoSum(nums, target)

def twoSum(nums, target):
    dict = {}
    """
    Algorithm: 
    1. create a dictionay and have all the element of nums in it 
    2. Loop thru the dictionary and look for target - dict[i]
    """
    dict = {}
    i = 0
    for n in nums:
        if n not in dict:
            dict[n] = i
            i+=1
    for i,v in enumerate(nums):
        if(v not in dict):
            dict[nums[i]] = i
    j=0
    #for m in nums:
    #    complement = target-m
    #    if complement in dict and (j != dict[complement]):
    #        return [j, dict[complement]]
    #        j+=1
    for i in range(len(nums)):
        complement = target - nums[i]
        if complement in dict and (i != dict[complement]):
            return [i, dict[complement]]
    return []
if __name__ == '__main__':
    main()