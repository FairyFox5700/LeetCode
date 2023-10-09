    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var stack = new Stack<string>();
            var el = path.Split("/").ToArray();
            foreach (var val in el)
            {
                if (val == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (val == "." || val == "")
                {
                    continue;
                }
                else
                {
                    stack.Push(val);
                }
            }
            if(stack.Count == 0)
            {
                return "/";
            }
            var sb = new StringBuilder();
            while (stack.Count > 0)
            {

                sb.Insert(0, stack.Pop());
                sb.Insert(0, "/");
            }

            return sb.ToString();

        }
    }