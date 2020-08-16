def main():
    input = [1,1,4,2,1,3]
    output = heightChecker(input)
    print(output)
def heightChecker(heights):
    count = 0
    sorted_heights = sorted(heights)
    for i in range(len(heights)):
        if(heights[i] != sorted_heights[i]):
            count += 1
    return count

if __name__ == '__main__':
    main()



