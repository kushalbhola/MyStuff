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

s = Stack()
s.push("A")
s.push("B")
s.push("C")
s.push("D")
test1 = s.pop()
test2 = s.peek()
print(test1)
print(test2)
