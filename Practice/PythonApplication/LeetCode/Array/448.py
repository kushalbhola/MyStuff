def main():
    input = [1,1]
    output = findDisappearedNumbers(input)
    print(output)
def findDisappearedNumbers(nums):
    if len(nums) == 0:
        return []
    hash = {}
    for n in nums:
        if n in hash:
            hash[n] += 1
        else:
            hash[n] = 1
    output =[]
    for i in range(1, len(nums)+1):
        if i not in hash:
            output.append(i)
    return output

if __name__ == '__main__':
    main()





