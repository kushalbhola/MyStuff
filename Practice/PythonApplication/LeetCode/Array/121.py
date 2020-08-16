import sys
def main():
    input = [2,4,1]
    output = maxProfit(input)
    input2 = [7,1,5,3,6,4]
    output = maxProfit2(input)
    print(output)
def maxProfit(prices):
    minValue = sys.maxsize
    maxValue = -sys.maxsize
    profit = 0
    for p in prices:
        if(p < minValue):
            minValue = p
        elif(p > minValue and p - minValue > profit):
            maxValue = p
            profit = maxValue - minValue
    if maxValue == -sys.maxsize:
        return 0
    return profit


if __name__ == '__main__':
    main()






