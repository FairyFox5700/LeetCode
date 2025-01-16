public class Solution {
    public int Candy(int[] ratings) {
        var initialSum = ratings.Count();
        // 1, 0, 2
        // 1 1 1 -- first distribution
        // round 2, check that i+1 > i ( previos neighbor has lower rank)
        // 1 1 2 -- last get one more to satisfy last condition
        // round 3, check that i > i+1 in reverse direction
        //  [1,3,4,5,2]
        var candies = new int[ratings.Count()];
        for( int i = 0; i< ratings.Count(); i++)
        {
            candies[i]= 1;
        }

        // 1 1 1 1 1
        for( int i = 0; i< ratings.Count()-1; i++)
        {
            if( ratings[i+1] > ratings[i] )
            {
                candies[i+1]= candies[i]+1; // give 1 more then previous one
            }
        }
       
        // 1 2 3 4 1
       
        for( int i = ratings.Count()-1; i>0; i--)
        {
            if(ratings[i-1]> ratings[i])
            {
                // if previos assignment retured already bigger valuem then simply assign the previos one
                candies[i-1] =Math.Max(candies[i]+1, candies[i-1]);
            }
        }

        // 1 2 3 4 1

        return candies.Sum();
    }
}