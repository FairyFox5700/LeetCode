public class Solution 
{
    public bool DifferByOne(string[] dict)
    {
            if(dict.Length == 2)
        {
            //without this part "Runtime Error" - out of memory
            
            var skip = 0;
            for(int i = 0; i < dict[0].Length; i ++)
            {
                if(skip > 1)
                    return false;
                
                if(dict[0][i] == dict[1][i])
                    continue;
                
                skip++;
            }
            
            if(skip <= 1)
                return true;
        }
        
        var dictionary = new HashSet<string>();

        // Iterate through each string in the dictionary
        for (int k = 0; k < dict.Length; k++)
        {
            var val = dict[k];
            // Generate each pattern by replacing one character with '*'
            for (int i = 0; i < val.Length; i++)
            {
                // Create a new pattern with the i-th character replaced by '*'
                var newPattern = new StringBuilder(val);
                newPattern[i] = '*'; // Replace character at i with '*'

                var patternStr = newPattern.ToString();
                
                // Check if this pattern is already in the set
                if (dictionary.Contains(patternStr))
                {
                    return true; // If found, strings differ by exactly one character
                }
                
                // Add the pattern to the dictionary
                dictionary.Add(patternStr);
            }
        }

        return false; // No such pair of strings was found
    }
}
