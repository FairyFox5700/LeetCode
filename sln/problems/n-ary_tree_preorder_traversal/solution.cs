/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

    public class Solution
    {
        public IList<int> Preorder(Node root)
        {
            // root left right
            var stack = new Stack<Node>();
            if (root == null)
            {
                return new List<int>();
            }
            var result = new List<int>();
            stack.Push(root);

            while (stack.Count>0)
            {
                var pop = stack.Pop();
                var reversedList = pop.children.ToArray();
                Array.Reverse(reversedList);
                for (int i = 0; i < reversedList.Count(); i++)
                {
                    var kid =reversedList[i];
                    if(kid !=null)
                    {
                       stack.Push(kid);
                    }
                }

                result.Add(pop.val);
            }

            return result;
        }
    }