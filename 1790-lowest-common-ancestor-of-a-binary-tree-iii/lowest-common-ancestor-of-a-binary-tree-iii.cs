/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution
{
    public Node LowestCommonAncestor(Node p, Node q)
    {
        if (p == null || q == null)
            return null;

        // Find the depth of both nodes
        int depthP = GetDepth(p);
        int depthQ = GetDepth(q);

        // Bring both nodes to the same level
        while (depthP > depthQ)
        {
            p = p.parent;
            depthP--;
        }

        while (depthQ > depthP)
        {
            q = q.parent;
            depthQ--;
        }

        // Move both nodes up together until we find the common ancestor
        while (p != q)
        {
            p = p.parent;
            q = q.parent;
        }

        return p;
    }

    private int GetDepth(Node node)
    {
        int depth = 0;
        while (node != null)
        {
            node = node.parent;
            depth++;
        }
        return depth;
    }
}
