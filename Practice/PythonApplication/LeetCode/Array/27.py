def main():
    input = [0,1,2,2,3,0,4,2]
    output = removeElement(input, 2)
    print(output)
def removeElement(nums, val):
    #slow = -1
    #fast = 0
    #while(fast < len(nums) and len(nums) > 1):
    #    if(nums[fast] == val):
    #        fast += 1
    #    else:
    #        slow+=1
    #        if(slow != fast):
    #            temp = nums[fast]
    #            nums[fast] = nums[slow]
    #            nums[slow] = temp
    #        else:
    #            fast += 1
    #for i in range(len(nums)):
    #    if nums[i] == val:
    #        nums.remove(nums[i])
    #return nums
    i = 0
    while(i<len(nums)):
        if(nums[i] == val):
            nums.remove(nums[i])
            i -= 1
        i += 1
    return len(nums)
 
if __name__ == '__main__':
    main()





