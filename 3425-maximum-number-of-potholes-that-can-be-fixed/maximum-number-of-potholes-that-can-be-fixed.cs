using System;
using System.Collections.Generic;

public class Solution
{
    public int MaxPotholes(string road, int budget)
    {
        var roads = road.ToCharArray();
        int maxPotholes = 0;
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        
        // Traverse the road string to find segments of potholes
        for (int i = 0; i < roads.Length; i++)
        {
            int sum = 0;
            while (i < roads.Length && roads[i] == 'x')
            {
                sum++;
                i++;
            }
            if (sum > 0)
            {
                pq.Enqueue(sum, sum);
            }
        }
        
        // Fix potholes while within the budget
        while (budget > 0 && pq.Count > 0)
        {
            var maxSegment = pq.Dequeue();
            var fixCount = Math.Min(budget-1, maxSegment);
            maxPotholes += fixCount;
            budget -= Math.Min(budget,maxSegment+1);
        }
        
        return maxPotholes;
    }
}
