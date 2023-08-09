    public class Solution
    {
        public string RemoveKdigits(string num, int k)
        {
            var minStack = new Stack<char>();
            foreach (var n in num)
            {
                while(k > 0 && minStack.Count > 0 && minStack.Peek() > n)
                {
                    minStack.Pop();
                    k--;
                }
                minStack.Push(n);
            }

            var strBuilder = new StringBuilder();
            while(k>0)
            {
                minStack.Pop();
                k--;
            }
            while (minStack.Count > 0)
            {
                strBuilder.Insert(0, minStack.Pop());
            }

            return (strBuilder.ToString().TrimStart('0')) == string.Empty ? "0":
             strBuilder.ToString().TrimStart('0') ;
        }
    }