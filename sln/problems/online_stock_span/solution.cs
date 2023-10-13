 public class StockSpanner
 {
     public record Item(int Price, int CurrentDayCount);
     private Stack<Item>_monItems = new Stack<Item>();
     public StockSpanner()
     {

     }

     public int Next(int price)
     {
         if (_monItems.Count == 0)
         {
             _monItems.Push(new Item(price, 1));
             return 1;
         }

          var answwer = 1;
         //[[], [100], [80], [60], [70], [60], [75], [85]]
         // 100: 1, 80: 1, 60: 1, 70: 2, 60: 2

         while (_monItems.Count > 0 && _monItems.Peek().Price <= price)
         {
             var pop = _monItems.Pop();
             answwer += pop.CurrentDayCount;

         }
          _monItems.Push(new Item(price, answwer));
          return answwer;
     }
 }
