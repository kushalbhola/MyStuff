# Definition for a binary tree node.

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None
class Queue():
    def __init__(self):
        self.items = []
    def enqueue(self, item):
        self.items.append(item)
    def dequeue(self):
        return self.items.pop(0)
    def getQueue(self):
        return self.items

def maxDepth(root):
    if (root == None):
        return 0
    else:
        return 1 + max(maxDepth(root.left), maxDepth(root.right))
def maxDepthUsingBFS(root):
    q = Queue()
    level = 0
    if(root == None):
        return 0
    q.enqueue(root)
    print(type(q.getQueue()))
    while(len(q.getQueue()) != 0):
        size = len(q.getQueue())
        for i in range(size):
            temp = q.dequeue()
            if temp.left != None : q.enqueue(temp.left)
            if temp.right != None : q.enqueue(temp.right)
        level += 1
    return level




#t = TreeNode(3)
#t.left = TreeNode(9)
#t.right = TreeNode(20)
#t.right.left = TreeNode(15)
#t.right.right = TreeNode(7)
t = TreeNode(1)
t.left = TreeNode(2)
output = maxDepth(t)
output = maxDepthUsingBFS(t)
print(output)