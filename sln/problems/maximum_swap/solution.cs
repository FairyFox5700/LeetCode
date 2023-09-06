    public class Solution
    {
        public int MaximumSwap(int num)
        {
            var lastOccurrence = new Dictionary<int, int>();
            var digits = num.ToString().ToCharArray();

            // Store the last occurrence of each digit in the number.
            for (int i = 0; i < digits.Length; i++)
            {
                lastOccurrence[digits[i] - '0'] = i;
            }

            // Iterate through each digit in the number.
            for (int i = 0; i < digits.Length; i++)
            {
                // Start from 9 (the largest digit) and go downwards.
                for (int j = 9; j > digits[i] - '0'; j--)
                {
                    // Check if a larger digit exists later in the number.
                    if (lastOccurrence.ContainsKey(j) && lastOccurrence[j] > i)
                    {
                        // Swap the digits.
                        (digits[i], digits[lastOccurrence[j]]) = (digits[lastOccurrence[j]], digits[i]);

                        // Convert the modified array of characters back to an integer.
                        return int.Parse(new string(digits));
                    }
                }
            }

            // If no swap is needed, return the original number.
            return num;
        }
    }