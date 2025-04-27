#TLE

class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

class BinarySearchTree:
    def __init__(self):
        self.root = None

    def insert(self, value):
        if self.root is None:
            self.root = Node(value)
        else:
            self._insert(self.root, value)

    def _insert(self, root, value):
        if value < root.value:
            if root.left is None:
                root.left = Node(value)
            else:
                self._insert(root.left, value)
        elif value > root.value:
            if root.right is None:
                root.right = Node(value)
            else:
                self._insert(root.right, value)

    def preorder(self, root):
        if root:
            print(root.value, end=" ")
            self.preorder(root.left)
            self.preorder(root.right)

    def inorder(self, root):
        if root:
            self.inorder(root.left)
            print(root.value, end=" ")
            self.inorder(root.right)

    def postorder(self, root):
        if root:
            self.postorder(root.left)
            self.postorder(root.right)
            print(root.value, end=" ")

def main():
    C = int(input())
    
    for case_num in range(1, C + 1):
        N = int(input())
        values = list(map(int, input().split()))
        
        bst = BinarySearchTree()
        for value in values:
            bst.insert(value)
        
        print(f"Case {case_num}:")
        
        bst.preorder(bst.root)
        print()
        
        bst.inorder(bst.root)
        print()
        
        bst.postorder(bst.root)
        print()
        print()

if __name__ == "__main__":
    main()