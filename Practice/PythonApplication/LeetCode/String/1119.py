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
    input = "leetcodeisacommunityforcoders"
    output = removeVowels(input)
    print(output)
def removeVowels(S):
    vowels = ['a', 'e', 'i', 'o', 'u']
    S = list(S)
    output = []
    for i in S:
        if i not in vowels:
            output.append(i)
    return ''.join(S)


if __name__ == '__main__':
    main()










