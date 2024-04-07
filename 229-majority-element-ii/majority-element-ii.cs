public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int? firstCandidate = null;
        int? secondCandidate = null;
        int firstCount = 0;
        int secondCount = 0;

        // Voting phase
        foreach (var num in nums) {
            if (firstCandidate.HasValue && num == firstCandidate) {
                firstCount++;
            } else if (secondCandidate.HasValue && num == secondCandidate) {
                secondCount++;
            } else if (!firstCandidate.HasValue) {
                firstCandidate = num;
                firstCount = 1;
            } else if (!secondCandidate.HasValue) {
                secondCandidate = num;
                secondCount = 1;
            } else {
                firstCount--;
                secondCount--;
                // Remove candidates that have a count of 0
                if (firstCount == 0) firstCandidate = null;
                if (secondCount == 0) secondCandidate = null;
            }
        }

        // Reset counts for the counting phase
        firstCount = secondCount = 0;

        // Counting phase to confirm majority
        foreach (var num in nums) {
            if (num == firstCandidate) firstCount++;
            else if (num == secondCandidate) secondCount++;
        }

        var result = new List<int>();
        var n = nums.Length;
        if (firstCount > n / 3) result.Add(firstCandidate.Value);
        if (secondCandidate.HasValue && secondCount > n / 3 && !result.Contains(secondCandidate.Value)) {
            result.Add(secondCandidate.Value);
        }

        return result;
    }
}
