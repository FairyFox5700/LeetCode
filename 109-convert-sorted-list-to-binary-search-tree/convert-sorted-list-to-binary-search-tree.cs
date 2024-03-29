    public class Solution
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            var list = MapListToValues(head);

            return BuildTreeRecursively(0, list.Count - 1, list);
        }

        private TreeNode BuildTreeRecursively(int left, int right, List<ListNode> nodes)
        {
            if (left > right)
            {
                return null;
            }

            var mid = left + (right - left) / 2;

            var root = new TreeNode(nodes[mid].val);
            root.left = BuildTreeRecursively(left, mid - 1, nodes);
            root.right = BuildTreeRecursively(mid + 1, right, nodes);

            return root;
        }

        private List<ListNode> MapListToValues(ListNode head)
        {
            List<ListNode> values = new List<ListNode>();
            while (head != null)
            {
                values.Add(head);
                head = head.next;
            }

            return values;
        }
    }
