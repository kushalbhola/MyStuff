class Stack():
    def __init__(self):
        self.items =[]
    def push(self, item):
        self.items.append(item)
    def pop(self):
        return self.items.pop()
    def peek(self):
        return self.items[len(self.items) - 1]
    def getStack(self):
        return self.items

import sys
def main():
    input = "[[1,1],2,[1,1]]"
    size = 3
    output = ()
    output = removeOuterParentheses(input)
    print(output)
def depthSum(nestedList):
    #Algo: split it over comma you will get all the elem at levelsadas
    return nestedList 
def dfs(nestedList, level):
    sum = 0
    for item in nestedList:
        if(item.isInteger()):
            sum += item.getInteger() * level
        else:
            sum += dfs(self, item.getList(), level+1)



if __name__ == '__main__':
    main()









