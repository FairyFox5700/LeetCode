   public class Solution
    {

        private List<string> result = new List<string>();

        private int Length = 0;
        public IList<string> GenerateParenthesis(int n)
        {
            Length = n;
            Backtrack(n, "", 0, 0);
            return result;

        }

        //( 
        // (( 
        // (((
        //leftcount >n return
        // ((()
        // ((())
        // ((()))
        // add to result
        // ((())
        // ((()
        // ((
        //

        public void Backtrack(int n, string currentString, int rightCount, int leftCount)
        {
            if (currentString.Length == n * 2)
            {
                result.Add(currentString);
                return;
            }

            if (leftCount < n)
            {
                // still can add left braces
                Backtrack(n, currentString+"(", rightCount, leftCount +1);
                Console.WriteLine(currentString);
                //if(currentString.Length >0)
                    //currentString =  currentString.Substring(0, currentString.Length - 1);
            }
            // we can not start from ) because it will be invalid
            if (leftCount> rightCount)
            {
                // still can add right braces
                Backtrack(n, currentString+")", rightCount +1, leftCount);
                //if(currentString.Length >0)
                    //currentString =  currentString.Substring(0, currentString.Length - 1);
            }
        }
    }
