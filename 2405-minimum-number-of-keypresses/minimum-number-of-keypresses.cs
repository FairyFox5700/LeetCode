using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MinimumKeypresses(string s)
    {
        var counter = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!counter.ContainsKey(s[i]))
                counter.Add(s[i], 1);
            else
            {
                counter[s[i]]++;
            }
        }

        var result = counter.OrderByDescending(e => e.Value);
        var minCountPressed = 0;

        var currentPositionOfSlot = 1;
        var currentCharIndex = 0;

        foreach (var (key, val) in result)
        {
            minCountPressed += val * currentPositionOfSlot;

            currentCharIndex++;

            if (currentCharIndex % 9 == 0)
            {
                currentPositionOfSlot++;
            }
        }

        return minCountPressed;
    }
}
