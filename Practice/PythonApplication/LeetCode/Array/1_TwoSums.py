def main():
    print("python main function")
    nums = [230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789]
    target = 542
    nums = [2,2,2,2]
    target = 4
    print("hello")
    result = twoSum(nums, target)
    print("Result : " , result)
    try:
        result = two_Sume_Two_Pointers(nums, target)
    except expression as identifier:
        print(identifier)
    print(result)

def twoSum(nums, target):

    dict = {}
    """
    Algorithm: 
    1. create a dictionay and have all the element of nums in it 
    2. Loop thru the dictionary and look for target - dict[i]
    """
    dict = {}
    i = 0
    # nums.sort()
    for n in nums:
        if n not in dict:
            dict[n] = i
            i+=1
    for i,v in enumerate(nums):
        # if(v not in dict):
            dict[nums[i]] = i
    j=0

    dict = {}
    for i,v in enumerate(nums):
        dict[v]=i
    for i in range(len(nums)):
        complement=target - nums[i]
        if complement in dict and (i!=dict[complement]):
            val = [i,dict[complement]]
            return val
    return[]
        
    ###
    # dict = {}
    # for i,v in enumerate(nums):
    #     if(i not in dict):
    #         dict[i] = v
    # for i in range(len(nums)):
    #     complement = target - nums[i]
    #     #create a new dictionary with unique nums
    #     dict2 = {}
    #     if(i not in dict.keys()):
    #         dict2[i] = nums[i]

    ####
    for m in nums:
       complement = target-m
       if complement in dict and (j != dict[complement]):
           return [j, dict[complement]]
           j+=1
    for i in range(len(nums)):
        complement = target - nums[i]
        if complement in dict and (i != dict[complement]):
            return [i, dict[complement]]
    return []
def two_Sume_Two_Pointers(nums, target):
    nums.sort()
    left_index = 0
    right_index = len(nums) - 1
    while(right_index > left_index):
        total = nums[left_index] + nums[right_index]
        if(total > target):
            right_index =  right_index - 1
        elif (total < target):
            left_index = left_index + 1
        elif (total == target):
            return True
        else:
            return False
if __name__ == '__main__':
    main()