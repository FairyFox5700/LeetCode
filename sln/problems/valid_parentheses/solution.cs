public class Solution {

private Dictionary<char, char> dict = new Dictionary<char, char>()
{
    { '(', ')' },
    //{ ')', '(' },
    { '{', '}' },
    //{ '}', '{' },
    { '[', ']' },
    //{ ']', '[' }
};

    public bool IsValid(string s) {
        var ch = s.ToCharArray();
        var st = new Stack<char>();
        for(int i = 0; i< ch.Count(); i ++)
        {
            if(dict.Keys.ToList().Contains(ch[i]))
            {
                    st.Push(ch[i]);
            }
            else 
            {
                if(st.Count <=0)
                {
                    return false;
                }
                // start popping
                if(dict[st.Pop()] == ch[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }

            }
        }
        return  true && st.Count <=0;
    }
}