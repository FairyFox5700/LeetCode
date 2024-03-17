public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        // Dictionary to store the frequency of each element
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        
        // Count the frequency of each element in arr
        foreach (int num in arr) {
            if (!frequencyMap.ContainsKey(num)) {
                frequencyMap[num] = 0;
            }
            frequencyMap[num]++;
        }

        var occ = new HashSet<int>(); // ocurrance store
        foreach(var(k,v) in frequencyMap)
        {
            if(!occ.Contains(v))
            {
                occ.Add(v);
            }
            else
            {
                return false;
            }
        }

        return true;
        
    }
}