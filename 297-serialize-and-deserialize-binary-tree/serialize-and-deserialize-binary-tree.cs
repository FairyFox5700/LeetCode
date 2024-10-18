public class Codec
{

    // Encodes a tree to a single string.
    private int index = 0;
    private StringBuilder sb = new StringBuilder();
    public string serialize(TreeNode root)
    {
        preOrder(root);

        Console.WriteLine(sb.ToString());
        return sb.ToString();
    }

    private void preOrder(TreeNode root)
    {
        if (root == null)
        {
            sb.Append("null,");
            return;
        }
        else
        {
            sb.Append(root.val + ",");
        }
        preOrder(root.left);
        preOrder(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var dataArr = data.Split(",");
        return getTree(dataArr);
    }

    private TreeNode getTree(string[] data)
    {

        if(data[index] == "null" || index > data.Length)
        {
            index++;
            return null;
        }
        else{
            var node = new TreeNode(int.Parse(data[index]));
            index++;
            node.left = getTree(data);
            node.right = getTree(data);
            return node;
        }
    }
}