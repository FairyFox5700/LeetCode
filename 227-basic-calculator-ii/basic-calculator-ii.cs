public class Solution
{
    public int Calculate(string s)
    {
        var lastNumber = 0;
        var result = 0;
        var lastOperation = '+';
        var number = 0;

        //3+2*2
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (char.IsDigit(ch))
            {
                number = number * 10 + (ch - '0');
            }

            if (!char.IsDigit(ch) && !char.IsWhiteSpace(ch) || i == s.Length - 1)
            {
                switch (lastOperation)
                {
                    case '+':
                        result += lastNumber;
                        lastNumber = number;
                        break;
                    case '-':
                        result += lastNumber;
                        lastNumber = -number;
                        break;
                    case '*':
                        lastNumber = lastNumber * number;
                        break;
                    case '/':
                        lastNumber = lastNumber / number;
                        break;
                }

                lastOperation = ch;
                number = 0;
            }
        }

        result += lastNumber;
        return result;
    }
}
