using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    private class LargerNumberComparer : IComparer<string> {
        public int Compare(string a, string b) {
            // Compare two strings by their potential concatenated results without creating new strings
            return (b + a).CompareTo(a + b);
        }
    }

    public string LargestNumber(int[] nums) {
        // Early check for a scenario where all numbers could be zero
        if (nums.All(n => n == 0)) {
            return "0";
        }

        // Convert all numbers to strings
        var strings = nums.Select(x => x.ToString()).ToList();

        // Sort the strings using a custom comparer
        strings.Sort(new LargerNumberComparer());

        // After sorting, if the first item is "0", return "0" because all others must be zero too
        if (strings[0] == "0") {
            return "0";
        }

        // Join all strings to form the largest number
        return string.Join("", strings);
    }
}

