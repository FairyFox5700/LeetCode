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
        public IList<int> Postorder(Node root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            var list = new List<int>();
            // left right root
            var stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count>0)
            {
                var el = stack.Pop();
                list.Add(el.val);
                for (int i = 0; i < el.children.Count; i++)
                {
                    stack.Push(el.children[i]);
                }
            }
            
            var reversed = list.ToArray();
            Array.Reverse(reversed);
            return reversed;
        }
    }
        