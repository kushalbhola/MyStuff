import sys
def main():
    input =[0,0,0,1]
    output = minCostClimbingStairs(input)
    print(output)
def minCostClimbingStairs(cost):
    DP = []
    print(len(cost))
    if(len(cost) == 0):
        return 0
    elif(len(cost) == 1 or len(cost)==2):
        return cost[0]
    DP.append(cost[0])
    DP.append(cost[1])
    for p in range(2, len(cost)):
        val = cost[p] + min(DP[p-1], DP[p-2])
        DP.append(val)
    return DP[len(DP) - 1]



if __name__ == '__main__':
    main()








