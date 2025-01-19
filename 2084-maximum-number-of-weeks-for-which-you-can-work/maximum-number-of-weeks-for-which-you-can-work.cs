public class Solution {
    public long NumberOfWeeks(int[] milestones) {
        
    long max = milestones.Max();
    long totalSum = milestones.Sum(e=>(long)e);
    var otherSum = totalSum - max;

    if (otherSum >= max) {
        return (long)totalSum;
    }

    return 2 * (long)otherSum + 1;
}
}
