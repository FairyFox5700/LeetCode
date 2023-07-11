public class Solution {
    public int EvalRPN(string[] tokens) {
       var stack = new Stack<string>();
       if(tokens.Count() < 2)
       {
           return int.Parse(tokens[0]);
       }
       foreach(var token in tokens)
       {
           if( token == "+" || token == "-"
            || token == "*" || token == "/")
            {
                var right = int.Parse(stack.Pop());
                var left = int.Parse(stack.Pop());
                int result = token switch
                {
                    "*" => left * right,
                    "-" => left - right,
                    "+" => left + right,
                    "/" => left / right,
                    _ => 0
                };
                stack.Push(result.ToString());     
            }
            else
            {
               stack.Push(token);     
            }
        }
        return int.Parse(stack.Pop());
    }
}