public class Solution {
    public string RemoveDuplicates(string s, int k)
    {
        var stack = new Stack<(char, int)>();
        foreach(var el in s)
        {
            if(stack.Count > 0 && stack.Peek().Item2 == k-1 &&  stack.Peek().Item1 == el)
            {
               stack.Pop();
            }
            else if(stack.Count > 0 && stack.Peek().Item1 == el)
            {
               var (ch, count) = stack.Pop();
               stack.Push((ch, count+1));
            }
            else
            {
                 stack.Push((el, 1));
            }
        }

        var sb = new StringBuilder();
        foreach(var (ch, count) in stack)
        {
            for (int i = 0; i < count; i++)
            {
                sb.Insert(0, ch);
            }
        }

        return sb.ToString();
    }
}