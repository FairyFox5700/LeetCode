public class Solution {
    public long NumberOfWeeks(int[] milestones) {
        

        /*
        If the sum of the other projects (otherSum) is greater than or equal to the largest project’s milestones, then you can continue alternating without constraint, and the maximum weeks will be the sum of all milestones (totalSum).
If the largest project has more milestones than the sum of the other projects, you can only work for 2 * otherSum + 1 weeks because, once the smaller projects run out, you won't have anything left to alternate with.*/
    long max = milestones.Max();
    long totalSum = milestones.Sum(e=>(long)e);
    var otherSum = totalSum - max;

    if (otherSum >= max) {
        return (long)totalSum;
    }

    return 2 * (long)otherSum + 1;
}
}
