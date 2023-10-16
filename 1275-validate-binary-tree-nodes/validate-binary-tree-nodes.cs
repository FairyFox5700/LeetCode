    public class Solution
    {
        public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            var root = FindRoot(n, leftChild, rightChild);
            Console.WriteLine(root);
            if (root == -1)
            {

                //1. Check if root exists
                return false;
            }

            // root, left and right
            var queue = new Queue<(int,int,int)>();
            var hashSet = new HashSet<int>();
            queue.Enqueue((root, leftChild[root], rightChild[root]));

            while (queue.Count>0)
            {
                var (poppedRoot, popLeft, popRight) = queue.Dequeue();
                if(hashSet.Contains(poppedRoot)) return false;
                //2. Detect a loop
                hashSet.Add(poppedRoot);
                if (popLeft != -1 && !hashSet.Contains(popLeft))
                {
                    queue.Enqueue((popLeft, leftChild[popLeft], rightChild[popLeft]));
                }

                if (popRight != -1 && !hashSet.Contains(popRight))
                {
                    queue.Enqueue((popRight, leftChild[popRight], rightChild[popRight]));
                }
            }


            //3.Check if it is 1 component, if we were not able to reach all nodes via BFS, it means it is not 1 component
            return hashSet.Count == n;
        }


        private int FindRoot(int n, int[] leftClild, int[] rightChild)
        {
            var set = leftClild.Union(rightChild);
            for (int i = 0; i < n; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }

            return -1;
        }

    }