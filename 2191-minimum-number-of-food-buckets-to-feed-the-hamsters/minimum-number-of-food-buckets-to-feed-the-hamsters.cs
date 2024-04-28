public class Solution {
    public int MinimumBuckets(string hamsters) {
        StringBuilder sb = new StringBuilder(hamsters);
        int res = 0;
        for(int i = 0; i < sb.Length;i++){
            if(sb[i] == 'H'){
                if(!CanFeed(hamsters, i)) 
                    return -1;
                if(i < hamsters.Length - 2 && hamsters[i + 1] == '.' && hamsters[i + 2] == 'H')
                    i += 2;
                res++;
            }

        }
        return res;
    }

    // can feed only if H surrounded by .
    private bool CanFeed(string hamsters, int idx) {
        return (idx > 0 && hamsters[idx - 1] == '.') 
            || (idx < hamsters.Length - 1 && hamsters[idx + 1] == '.');
    }
}