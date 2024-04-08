using System.Threading;

public class H2O {
    private readonly SemaphoreSlim semaphoreH = new SemaphoreSlim(2);
    private readonly SemaphoreSlim semaphoreO = new SemaphoreSlim(1);

    private readonly object _locker = new object();
    private int _numberH;

    public void Hydrogen(Action releaseHydrogen)
    {
        semaphoreH.Wait();

        lock (_locker)
        {
            // releaseHydrogen() outputs "H". Do not change or remove this line.
            releaseHydrogen();

            if (++_numberH % 2 == 0)
            {
                semaphoreO.Release();
            }
        }
    }

    public void Oxygen(Action releaseOxygen)
    {
        semaphoreO.Wait();
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();

        semaphoreH.Release(2);
    }
}