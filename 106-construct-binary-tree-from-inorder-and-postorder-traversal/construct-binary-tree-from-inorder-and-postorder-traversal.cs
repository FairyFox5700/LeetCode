public class Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        // Create a map to quickly find the index of any value in inorder
        var inorderIndexMap = new Dictionary<int, int>();
        for (var i = 0; i < inorder.Length; i++) {
            inorderIndexMap[inorder[i]] = i;
        }

        // Call the recursive method to build the tree
        return BuildTreeRecursively(0, inorder.Length - 1, postorder.Length - 1, inorderIndexMap, postorder);
    }

    private TreeNode BuildTreeRecursively(int inStart, int inEnd, int postEnd, Dictionary<int, int> inorderIndexMap, int[] postorder) {
        if (inStart > inEnd) {
            return null;
        }

        // Create the current root and find its index in inorder
        TreeNode root = new TreeNode(postorder[postEnd]);
        int inIndex = inorderIndexMap[root.val];

        // Calculate remaining elements in the right subtree to adjust postorder index for left subtree
        int rightSubtreeSize = inEnd - inIndex;

        // Recursively build left and right subtrees
        root.left = BuildTreeRecursively(inStart, inIndex - 1, postEnd - rightSubtreeSize - 1, inorderIndexMap, postorder);
        root.right = BuildTreeRecursively(inIndex + 1, inEnd, postEnd - 1, inorderIndexMap, postorder);

        return root;
    }
}
