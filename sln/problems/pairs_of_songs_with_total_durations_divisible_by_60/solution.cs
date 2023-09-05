    public class Solution
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            //(a + b) mod m = ((a mod m) + (b mod m)) mod m
            // hashset
            // (a % 60 + b % 60 ) % 60 = 0
            // b % 60 =

            var dict = new Dictionary<int, int>();
            var result = 0;
            for (int i = 0; i < time.Length; i++)
            {
                var remainder = time[i] % 60;

         

                var second = (60 - remainder) % 60; // basically means (a + b) % 60 = 0
                if(dict.ContainsKey(second))
                    result += dict[second];
                if (dict.ContainsKey(remainder))
                    dict[remainder]++;
                else
                    dict.Add(remainder, 1);
                // if sum is devided by 60 then sum of reminders by division values by 60 should also be devisable by 60
                // (a % 60 + b % 60 ) % 60 = 0
                /*
Logic -
Whenever we consider any number time[i] we can have 2 possibilities :

1) Number is divisible by 60.
2) Number is not divisible by 60.

We basically need to consider the time[i]%60 each time to know if it is==0 or not.
1) If modulo_val==0 we simply do count+=hash[modulo_val]
2) Else we need to find out how far is time[i] away from its next 60 multiple i.e 100 is 20 far from 120 which is a multiple of 60 so if we have a 20 alreay existing then (100,20) can make a valid pair.
3) To achieve this we first do time[i]%60 then subtract it from 60. Like 100 % 60=40 and 60-40=20. So count+=hash[20]

*/

            }
            return result;
        }
    }