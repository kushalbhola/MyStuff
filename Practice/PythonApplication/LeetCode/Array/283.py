def main():
    input = [1,0]
    output = moveZeroes(input)
    print(output)
def moveZeros(nums):
    slow = -1
    fast =0
    while(fast < len(nums)):
        if(nums[fast] == 0):
            fast += 1
        else:
            slow+=1
            if(slow != fast):
                nums[slow] = nums[fast]
                nums[fast] = 0
            else:
                fast += 1

if __name__ == '__main__':
    main()




