    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            var strings = nums.Select(x => x.ToString()).ToList();
            strings.Sort((a, b) =>
            {
                var num1 = a + b;
                var num2 = b + a;
                return num2.CompareTo(num1);
            });


            if (strings[0] == "0")
            {
                return "0";
            }

            return string.Join("", strings);
        }
    }