public class Solution {
    public bool IsValidSerialization(string preorder) {
        var str = preorder.Split(",");
        int slotsCount = 1;
        if(str[0] == "#" && str.Count()>1) return false;
        foreach(var s in str)
        {
            if(s!="#")
            {
                slotsCount--; // 1 incoming
                if(slotsCount<0)
                {
                    return false;
                }
                slotsCount+=2; // 2 outgoing
            }
            else
            {
                slotsCount--;
            }

            if(slotsCount<0)
            {
                return false;
            }
        }

        return slotsCount == 0;
    }
}