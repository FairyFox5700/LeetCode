using System;

public class Solution
{
    public int LatestTimeCatchTheBus(int[] buses, int[] passengers, int capacity)
    {
        Array.Sort(buses);
        Array.Sort(passengers);
        int j = -1;
        var currentCapacity = 0;

        for (int i = 0; i < buses.Length; i++)
        {
            currentCapacity = capacity;
            while ((j + 1) < passengers.Length && buses[i] >= passengers[j + 1] && currentCapacity > 0)
            {
                j++;
                currentCapacity--;
            }
        }

        Console.WriteLine(j);

        if (j < 0 || (j >= 0 && currentCapacity > 0 && buses[^1] != passengers[j]))
        {
            return buses[^1]; // Assuming this returns the last bus time if no passengers could catch any bus
        }

        while ((j - 1) >= 0 && (passengers[j] - passengers[j - 1]) == 1)
        {
            j--;
        }

        return j >= 0 ? passengers[j] - 1 : 0; // Adjusting index and handling edge cases
    }
}
