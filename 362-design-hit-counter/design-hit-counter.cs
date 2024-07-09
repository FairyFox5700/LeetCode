 public class HitCounter
 {
     private Queue<(int,int)> dequeu = new();
     private int count = 0;
     public HitCounter()
     {

     }

     public void Hit(int timestamp)
     {
        if (dequeu.Count > 0 && dequeu.Peek().Item1 == timestamp)
        {
            var item = dequeu.Dequeue();
            dequeu.Enqueue((item.Item1, item.Item2 + 1));
        }
        else
         {
             dequeu.Enqueue((timestamp, 1));
         }
         count++;
     }

    public int GetHits(int timestamp)
    {
        while (dequeu.Count > 0 && timestamp - dequeu.Peek().Item1 >= 300)
        {
            var item = dequeu.Dequeue();
            count -= item.Item2;
        }

        return count;
    }
 }