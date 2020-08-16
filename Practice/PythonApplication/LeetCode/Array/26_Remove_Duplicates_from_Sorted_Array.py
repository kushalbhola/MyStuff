def main():
    input = [1,1,2]
    output = removeDuplicates(input)
    output2 = removeDuplicates2(input)
def removeDuplicates( nums):
    l = set()
    for n in nums:
        l.add(n)
    output = []
    for s in l:
        output.append(s)
    return  output
def removeDuplicates2(nums):
    if(len(str(nums)) == 0):
       return 0
    j=1
    count= 1
    for i,v in enumerate(nums):
        if(j< len(nums)):
            if(v != nums[j]):
                count += 1
        j+=1
    return count

if __name__ == '__main__':
    main()

