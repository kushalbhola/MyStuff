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
    input = "hello"
    output = reverseVowels(input)
    print(output)
def reverseVowels(s):
    s = list(s)
    start =0
    end = len(s) - 1
    vowels = ['a', 'e', 'i','o','u']
    while(end >= start):
        if(s[start] in vowels  and s[end] in vowels):
            temp = s[start]
            s[start] = s[end]
            s[end] = temp
            start +=1
            end -=1
        elif(s[start] in vowels and s[end] not in vowels):
            end -= 1
        elif(s[start] not in vowels and s[end]  in vowels):
            start += 1
        else:
            start += 1
            end -= 1
    return s


if __name__ == '__main__':
    main()









