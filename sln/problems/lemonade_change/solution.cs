    public class Solution
    {
        public bool LemonadeChange(int[] bills)
        {
            var five = 0;
            var ten = 0;
            var twenty = 0;
            foreach (var bill in bills)
            {
                if (bill == 5)
                {
                    five++;
                }
                else if (bill == 10)
                {
                    if (five == 0)
                    {
                        return false;
                    }
                    five--;
                    ten++;
                }
                else if (bill == 20)
                {
                    if (five > 0 && ten > 0)
                    {
                        five--;
                        ten--;
                        twenty++;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                        twenty++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
