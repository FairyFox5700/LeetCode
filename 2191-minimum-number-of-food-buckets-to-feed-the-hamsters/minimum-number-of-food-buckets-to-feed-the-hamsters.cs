public class Solution {
    public int MinimumBuckets(string hamsters) {
        StringBuilder sb = new StringBuilder(hamsters);
        int res = 0;
        for(int i = 0; i < sb.Length;i++){
            char prev = (i > 0) ?  sb[i -1] : 'H';
            char next = (i < sb.Length - 1) ? sb[i + 1] : 'H';            

            if(sb[i] == 'H'){
                if( prev == 'H' && next == 'H') return -1;
                if(prev == 'O') continue;
                if(next == '.') sb[i + 1] = 'O';
                res++;
            }

        }
        return res;
    }
}