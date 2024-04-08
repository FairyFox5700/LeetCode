using System;
using System.Threading;

public class H2O
{
    private SemaphoreSlim hydrogenSemaphore = new SemaphoreSlim(2, 2); // Allows up to 2 hydrogens to proceed
    private SemaphoreSlim oxygenSemaphore = new SemaphoreSlim(0, 1); // Initially blocks oxygen
    private int hydrogenCount = 0;
    private object lockObject = new object(); // For atomic operations

    public void Hydrogen(Action releaseHydrogen)
    {
        hydrogenSemaphore.Wait(); // Wait for the semaphore to be available
 
        lock (lockObject)
        {
            releaseHydrogen(); // Release hydrogen

            hydrogenCount++;
            if (hydrogenCount == 2) // If this is the second hydrogen, allow oxygen to proceed
            {
                oxygenSemaphore.Release();
            }
        }
    }

    public void Oxygen(Action releaseOxygen)
    {
        oxygenSemaphore.Wait(); // Wait for two hydrogens to be released

        lock (lockObject)
        {
            releaseOxygen(); // Release oxygen
            hydrogenCount = 0; // Reset hydrogen count for the next molecule
            hydrogenSemaphore.Release(2); // Allow next two hydrogens to proceed
        }
    }
}
