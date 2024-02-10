/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> BoundaryOfBinaryTree(TreeNode root) 
    {
        var result = new List<int>();
        result.Add(root.val);
        if(IsLeave(root))
        {
            return result;
        }
        // add left
        var left = root.left;
        while(left!=null)
        {
            if(!IsLeave(left))
            {
                result.Add(left.val);
            }

            if(left.left != null)
            {
                left = left.left;
            }
            else
            {
                left = left.right;
            }
        }

        AddLeaves(result, root);

        // right part
        var tempSteack = new Stack<int>(); // as we need to maintain 
        // reverse direction of elements
        var right = root.right;
        while(right!= null)
        {
            if(!IsLeave(right))
            {
                tempSteack.Push(right.val);
            }
            if(right.right != null)
            {
                right = right.right;
            }
            else{
                right = right.left;
            }
        }

        // populate result witj stack values
        while(tempSteack.Count > 0)
        {
            result.Add(tempSteack.Pop());
        }

        return result;
    }


    private void AddLeaves(IList<int> result, TreeNode root)
    {
        if(root == null)
        {
            return;
        }

        if(IsLeave(root))
        {
            result.Add(root.val);
            return;
        }

     
            AddLeaves(result, root.left);
            AddLeaves(result, root.right);
    }
    private bool IsLeave(TreeNode node)
    {
        return node.left == null && node.right == null;
    }
}