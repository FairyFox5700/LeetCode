    public class Solution
    {
        public int Maximum69Number(int num)
        {
            var theLatestVal6 = -1;
            var indeyof6Poistion = 0;
            var currentNum = num;
            while (currentNum!= 0)
            {
                var divisin = currentNum/ 10;
                var reminder = currentNum % 10;
                if (reminder == 6)
                {
                    theLatestVal6 = indeyof6Poistion;
                }

                currentNum = divisin;
                indeyof6Poistion++;
            }

            if (theLatestVal6 == -1)
            {
                return num;
            }
            else
            {
                return num + (int)Math.Pow(10, theLatestVal6) * 3; // 3 is the difference between 9 and 6
                // means, if index = 2 for number 9669, then val = 9669 + 10^2 * 3 = 9969
            }
        }
    }