   public class Solution
    {
        //iterative
        private Dictionary<Node, Node> Hash = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {
            Node item = AddNode(head);
            if(item == null)
                return null;
            var current = head;
            while (current != null)
            {
                if (item.next == null)
                {
                    item.next = AddNode(current.next);
                }

                if (item.random == null)
                {
                    item.random = AddNode(current.random);
                }
                current = current.next;
                item = item.next;
            }

            return Hash[head];
        }

        private Node AddNode(Node node)
        {
            if(node == null)
                return null;
            if (Hash.ContainsKey(node))
                return Hash[node];

            var newNode = new Node(node.val);
            Hash.Add(node, newNode);
            return newNode;
        }

        /* recursive
        private Dictionary<Node, Node> Hash = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {
            if(head == null)
                return null;

            if(Hash.ContainsKey(head))
                return Hash[head];


            Hash.Add(head, head);
            head.next = CopyRandomList(head.next);
            head.random = CopyRandomList(head.random);

            return head;
        }

        */
    }