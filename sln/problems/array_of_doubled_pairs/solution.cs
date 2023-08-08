    public class Solution
    {
        public bool CanReorderDoubled(int[] arr)
        {
            var hashMapOfFrequencies = new Dictionary<int, int>();
            // initalized with frequencies of each element
            foreach (var ar in arr)
            {
                if (hashMapOfFrequencies.ContainsKey(ar))
                {
                    hashMapOfFrequencies[ar]++;
                }
                else
                {
                    hashMapOfFrequencies.Add(ar, 1);
                }
            }
              Array.Sort(arr);
            foreach (var ar in arr)
            {
                var doubleValue = ar * 2;
                if (hashMapOfFrequencies[ar] >0 && hashMapOfFrequencies.ContainsKey(doubleValue)  && hashMapOfFrequencies[doubleValue] > 0)
                {
                    hashMapOfFrequencies[ar]--;
                    hashMapOfFrequencies[doubleValue]--;
                }
            }

            foreach (var (key,val) in hashMapOfFrequencies)
            {
                if (val != 0)
                {
                    Console.WriteLine(key);
                    return false;
                }
            }

            return true;
        }
    }