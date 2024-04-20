public class Solution {
    public string RemoveDuplicates(string s) {
        var stack = new Stack<char>();
      
        for(int i=0; i< s.Length; i++)
        {
            if( stack.Count == 0 )
            {
                 stack.Push(s[i]);
            }
            else if(s[i]== stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        
       var sb = new StringBuilder();
        while(stack.Count > 0) {
            sb.Insert(0, stack.Pop());
        }
        return sb.ToString();
    }
}