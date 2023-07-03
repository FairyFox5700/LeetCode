public class MyQueue {

    private Stack<int> _first;
    private Stack<int> _second;
    private int _count;
    public MyQueue() {
        _first = new Stack<int>(); // 5
        _second = new Stack<int>();//4 3 2 1
    }
    
    public void Push(int x) {
        while(_second.Count >0) //2 3 4 
        {
           _first.Push( _second.Pop());
        }
        _first.Push(x);
        _count++;
    }
    
    // fist in fist out
    public int Pop() {
        while(_first.Count >0)
        {
            _second.Push(_first.Pop());
        }
       return  _second.Pop();// 4 3 2
    }
    
    public int Peek() {
        while(_first.Count >0)
        {
            _second.Push(_first.Pop());
        }
       return _second.Peek();
    }
    
    public bool Empty() {
       return _first.Count == 0 && _second.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */