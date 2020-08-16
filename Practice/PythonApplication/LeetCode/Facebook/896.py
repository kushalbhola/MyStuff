def main():
    input = [1,3,2]
    output = isMonotonic(input)
    print(output)
def isMonotonic(A):
    if(len(A) == 0):
        return False
    if(len(A) == 1):
        return True
    return monotonicIncreasing(A) or monotonicDecreasing(A)
def monotonicIncreasing(A):
    prev = 0
    for i in range(1, len(A)):
        if(A[prev] > A[i]):
            return False
        prev+=1
    return True
def monotonicDecreasing(A):
    prev = 0
    for i in range(1, len(A)):
        if(A[prev] < A[i]):
            return False
        prev += 1
    return True

if __name__ == '__main__':
    main()











