    using System.Threading;
    public class Foo
    {

        private static AutoResetEvent _firsAutoResetEvent = new AutoResetEvent(true);
        private static AutoResetEvent _secondAutoResetEvent = new AutoResetEvent(false);
        private static AutoResetEvent _trirdAutoResetEvent = new AutoResetEvent(false);
        public Foo()
        {

        }

        public void First(Action printFirst)
        {
            _firsAutoResetEvent.WaitOne();
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            _secondAutoResetEvent.Set();
        }

        public void Second(Action printSecond)
        {
            _secondAutoResetEvent.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            _trirdAutoResetEvent.Set();
        }

        public void Third(Action printThird)
        {
            _trirdAutoResetEvent.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
            _firsAutoResetEvent.Set();
        }
    }
