def main():
    input = [-4,-1,0,3,10]
    output = sortedSquares(input)
    print(output)
def sortedSquares(A):
    newArr = []
    for a in A:
        newArr.append(abs(a))
    newArr = sorted(newArr)
    output = []
    for n in newArr:
        output.append(n * n)
    return output
if __name__ == '__main__':
    main()


