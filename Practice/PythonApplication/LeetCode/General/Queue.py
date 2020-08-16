
class Queue():
    def __init__(self):
        self.items = []
    def enqueue(self, item):
        self.items.append(item)
    def dequeue(self):
        return self.items.pop(0)
    def getQueue(self):
        return self.items
q = Queue()
q.enqueue("A")
q.enqueue("B")
q.enqueue("C")
q.enqueue("D")
test1 = q.dequeue()
test2 = q.getQueue()
print(test1)
print(test2)
