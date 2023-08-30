public class Solution {
    public int CountOdds(int low, int high) {
        int ret = (high - low ) / 2;
        if(high%2 == 0 && low%2 == 0){
            return ret;
        }
        return ret+1;
    }
}