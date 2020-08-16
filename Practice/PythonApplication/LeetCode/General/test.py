import collections
def main():
    input = [1,2,1,1,2,2,4,4,5,4,3,6,7,7]
    output = testing(input)
    print(output)
def testing(A):
    num_counter = collections.Counter(A)
    test ="hello"
    top = num_counter.most_common(2)
    print(top)
    

if __name__ == '__main__':
    main()











