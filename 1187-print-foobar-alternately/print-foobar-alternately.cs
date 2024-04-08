using System.Threading;

public class FooBar {
    private int n;
    private AutoResetEvent AREFoo = new AutoResetEvent(true);
    private AutoResetEvent AREBar = new AutoResetEvent(false);

    public FooBar(int n) {
        this.n = n;
    }

    public void Foo(Action printFoo) {
        
        for (int i = 0; i < n; i++) {
            
            AREFoo.WaitOne();
        	// printFoo() outputs "foo". Do not change or remove this line.
        	printFoo();
            AREBar.Set();
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
            
            AREBar.WaitOne();
            // printBar() outputs "bar". Do not change or remove this line.
        	printBar();
            AREFoo.Set();
        }
    }
}