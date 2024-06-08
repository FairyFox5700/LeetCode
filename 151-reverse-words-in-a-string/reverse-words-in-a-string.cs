public class Solution {
  public string ReverseWords(string s) {
    var stack = new Stack<string>();
    var sb = new StringBuilder();
    var temp = new StringBuilder();
    for (int i = 0; i < s.Length; i++) {
      if (s[i] == ' ') {
        if (temp.Length > 0) {
          stack.Push(temp.ToString());
          temp = new StringBuilder();
        }
      } else if (s[i] != ' ') {
        temp.Append(s[i]);
      }
    }

    if (temp.Length > 0) {
      stack.Push(temp.ToString());
      temp = new StringBuilder();
    }
    while (stack.Count > 0) {
      sb.Append(stack.Pop());
      if (stack.Count > 0) {
        sb.Append(" ");
      }
    }
    return sb.ToString();
  }
}