    public class Solution
    {
        // using Floy Cycle detection
        public bool IsHappy(int n)
        {
            var current = n;
            var fast = Square(n);
            while (current != 1 && current!=fast)
            {
                current = Square(current);
                fast = Square(Square(fast));
            }

            return current == 1;
        }

        private int Square(int n)
        {
            // use a modulo operation to get the last digit
            var squeredResult = 0;
            while (n > 0)
            {
                var lastDigit = n % 10;
                squeredResult += (int)Math.Pow(lastDigit, 2);
                n = n / 10;
            }
            return squeredResult;
        }
    }


    /*  using hash map
      public class Solution
    {
        public bool IsHappy(int n)
        {
            var hasSetCycleDetection = new HashSet<int>();
            var current = Square(n);
            while (current != 1)
            {
                current = Square(current);
                if (!hasSetCycleDetection.Contains(current))
                {
                    hasSetCycleDetection.Add(current);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private int Square(int n)
        {
            // use a modulo operation to get the last digit
            var squeredResult = 0;
            while (n > 0)
            {
                var lastDigit = n % 10;
                squeredResult+= (int)Math.Pow(lastDigit, 2);
                n = n / 10;
            }
            return squeredResult;
        }
    }
*/