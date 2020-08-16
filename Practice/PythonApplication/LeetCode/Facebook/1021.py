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
    input = "(()())(()) (()(()))"
    size = 3
    output = ()
    output = removeOuterParentheses(input)
    print(output)
def removeOuterParentheses(input):
    s = Stack()
    output = []
    for i in input:
        if i == '(':
            if(len(s.getStack()) != 0):
                output.append('(')
            s.push(i)
        elif i == ')':
            s.pop()
            if(len(s.getStack()) != 0):
                output.append(')')
        else: 
            s = Stack()
    output = ''.join(output) 


if __name__ == '__main__':
    main()








