import sys
def main():
    input = [3,3]
    output = maxProfit2(input)
    print(output)
def maxProfit2(prices):
    if len(prices) == 0:
        return 0

    peak = prices[0]
    valley = prices[0]
    i = 0
    max = 0
    while i <len(prices)-1:
            #find valleys
        while(i < len(prices)-1 and prices[i] > prices[i+1]):
            i += 1
        valley = prices[i]
        #find peaks
        while(i < len(prices)-1 and prices[i] < prices[i+1]):
            i+=1
        peak = prices[i]
        max += peak - valley
        i+=1
    return max


if __name__ == '__main__':
    main()







