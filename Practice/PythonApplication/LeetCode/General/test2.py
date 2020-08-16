
def main():
    input = [['A', 'B'], ['A', 'C'], ['B', 'D'], ['B', 'C'], ['R', 'M'],['S'], ['P'], ['A']]
    output = commonChars(input)
    print(output)
def commonChars(A):
    hash = {}
    for a in A:
        if(a[0] not in hash):
            tempList = []
            tempList.append(a[1:])
            hash[a[0]]  = tempList
        else:
            hash[a[0]].append(a[1:])
    return hash


if __name__ == '__main__':
    main()












