/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
        public Node Connect(Node root)
        {
            // bst
            if (root == null)
            {
                return root;
            }

            var node = root;
            if (node.left != null)
            {
                node.left.next = node.right;
            }

            if (node.next != null && node.right !=null)
            {
                node.right.next = node.next.left;
            }
            Connect(node.left);
            Connect(node.right);
            return node;
        }
}