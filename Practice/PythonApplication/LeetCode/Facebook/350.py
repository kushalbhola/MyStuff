def main():
    num1 = [1,2,2,1]
    nums2 = [2,2]
    output = intersect(num1, nums2)
    print(output)
def intersect(nums1, nums2):
    if(len(nums1) > len(nums2)):
        big = nums1
        small = nums2
    else:
        big = nums2
        small=nums1
    #Convert big into dictionary
    hash = {}
    for b in big:
        if b in hash:
            hash[b] += 1
        else:
            hash[b] = 1
    output = []
    for s in small:
        if s in hash:
            output.append(s)
            hash[s] -= 1
            if(hash[s] == 0):
                del hash[s]
if __name__ == '__main__':
    main()










