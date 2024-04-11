/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

public class Solution : Relation {
    public int FindCelebrity(int n) {
        var candidate = 0;
        for(int i =1 ; i<n; i++)
        {
            if(Knows(candidate, i))
            {

                //if candiate knows smb, it can not be a FindCelebrity
                candidate = i;
            }
        }

        for(int i =0 ; i<n; i++)
        {
            if(candidate == i) continue;
            if(Knows(candidate, i) || !Knows(i, candidate))
            {
                return -1;
            }
        }

        return candidate;
    }
}