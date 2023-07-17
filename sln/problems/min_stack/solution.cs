    public class MinStack
    {
        public Stack<int> Stack;
        public Stack<int> MinStackS;
        public MinStack()
        {
            MinStackS = new Stack<int>();
            Stack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (!MinStackS.Any())
            {
                MinStackS.Push(val);
            }
            else
            {
                MinStackS.Push(Math.Min(MinStackS.Peek(), val));
            }
            Stack.Push(val);
        }

        public void Pop()
        {
            if (Stack.Any())
            {
                Stack.Pop();
                MinStackS.Pop();
            }
        }

        public int Top()
        {
            if (Stack.Any())
            {
                return Stack.Peek();
            }

            return -1;
        }

        public int GetMin()
        {
            if (MinStackS.Any())
            {
                return MinStackS.Peek();
            }
            return -1;
        }
    }