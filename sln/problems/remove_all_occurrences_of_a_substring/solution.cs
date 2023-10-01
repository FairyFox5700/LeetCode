    public class Solution
    {
        public string RemoveOccurrences(string s, string part)
{
	StringBuilder sb = new StringBuilder(s);
	while (true)
	{
		if (part.Length > sb.Length)
			return sb.ToString();

		var index = sb.ToString().IndexOf(part);
		if (index == -1)
			return sb.ToString();

		sb.Remove(index, part.Length);
	}
}
/*
        public string RemoveOccurrences(string s, string part)
        {
            var stack = new Stack<char>();
            foreach (var ch in s)
            {
                stack.Push(ch);
                if (stack.Count >= part.Length && stack.Peek() == part[^1])
                {
                    var l = new StringBuilder();
                    for (int i = part.Length - 1; i >= 0; i--)
                    {
                        var stackCh = stack.Pop();
                        l.Append(stackCh);
                        Console.WriteLine(l.ToString());
                       
                    }
                      var stackArray = l.ToString().ToCharArray();
                            Array.Reverse(stackArray);
                     if (new string(stackArray)!=part)
                        {
                          
                            foreach (var chk in stackArray)
                            {
                                // push it back as no maching was found
                                stack.Push(chk);
                            }
                        }
                }
            }

            var answer = new StringBuilder();
            Console.WriteLine(stack.Count);
            while(stack.Count > 0)
            {
                answer.Append(stack.Pop());
            }
            var arr = answer.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        */
    }
