class Solution {
    public int MinMoves(int target, int maxDoubles) {
        int c=0;
        while(target>1 && maxDoubles>0)
        {
            if(target%2==0)
            {
                maxDoubles-=1;
                target/=2;
                c+=1;
            }
            else
            {
                target-=1;
                c+=1;
            }
        }
        return c+(target-1);
    }
}