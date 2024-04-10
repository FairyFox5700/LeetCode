using System.Threading;

public class FizzBuzz {
    private int n;
    private AutoResetEvent fizzARE = new AutoResetEvent(false);
    private AutoResetEvent buzzARE = new AutoResetEvent(false);
    private AutoResetEvent fizzbuzzARE = new AutoResetEvent(false);
    private AutoResetEvent numberARE = new AutoResetEvent(true); // Initialized as true to start with Number method
    
    public FizzBuzz(int n) {
        this.n = n;
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz) {
        for (int i = 3; i <= n; i += 3) {
            if (i % 5 != 0) {
                fizzARE.WaitOne();
                printFizz();
                numberARE.Set();
            }
        }
    }

    // printBuzz() outputs "buzz".
    public void Buzz(Action printBuzz) {
        for (int i = 5; i <= n; i += 5) {
            if (i % 3 != 0) {
                buzzARE.WaitOne();
                printBuzz();
                numberARE.Set();
            }
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz) {
        for (int i = 15; i <= n; i += 15) {
            fizzbuzzARE.WaitOne();
            printFizzBuzz();
            numberARE.Set();
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber) {
        for (int i = 1; i <= n; i++) {
            numberARE.WaitOne();
            if (i % 3 == 0 && i % 5 == 0) {
                fizzbuzzARE.Set();
            } else if (i % 3 == 0) {
                fizzARE.Set();
            } else if (i % 5 == 0) {
                buzzARE.Set();
            } else {
                printNumber(i);
                numberARE.Set();
            }
        }
    }
}
