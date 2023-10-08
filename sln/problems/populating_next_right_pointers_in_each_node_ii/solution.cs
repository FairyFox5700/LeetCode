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

    public class Solution
    {
        public Node Connect(Node root)
        {
            var queue = new Queue<Node>();
            if (root == null)
            {
                return null;
            }
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var currentCount = queue.Count;
                while (currentCount>0)
                {
                    currentCount--;
                    var pop = queue.Dequeue();
                    queue.TryPeek(out Node second);
                    if(currentCount != 0)
                    {
                        pop.next = second;
                    }
                    
                    if (pop.left != null)
                    {
                        queue.Enqueue(pop.left);
                    }
                    if (pop.right != null)
                    {
                        queue.Enqueue(pop.right);
                    }
                }
            }

            return root;
        }
    }
