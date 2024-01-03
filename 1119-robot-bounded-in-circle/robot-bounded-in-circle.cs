public class Solution {
    public bool IsRobotBounded(string instructions)
    {
        var dX = 0;
        var dY = 1;
        var x = 0;
        var y = 0;

        foreach(var i in instructions)
        {
            if(i=='G')
            {
                x = x+dX;
                y = y+dY;
            }
            else if (i=='L')
            {
               (dX, dY) = ((-1)*dY, dX);
            }
            else 
            {
               (dY,dX) = ((-1)*dX, dY);
            }
        }
        

        return (x==0 && y==0) || !(dX==0 && dY==1);
    }
}