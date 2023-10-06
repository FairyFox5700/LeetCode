/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

    public class Solution
    {

        private int max = 0;
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return Depth(root,0);

        }

        private int Depth(Node node, int level)
        {
            if (node == null)
            {
                return 0;
            }
            level ++;
            foreach (var child in node.children)
            {
                Depth(child, level);
                
            }
            max = Math.Max(max, level);
            return max;
        }
    }