public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(magazine.Count() < ransomNote.Count())
        {
            return false;
        }
        var dict = new Dictionary<char, int>();
        var notes = ransomNote.ToCharArray();
        for(int i = 0; i < notes.Count(); i++)
        {
            if(dict.ContainsKey(notes[i]))
            {
                dict[notes[i]]++;
            }
            else
            {
                dict.Add(notes[i],1);
            }
        }
        var sum = dict.Values.ToList().Sum();
        var magazineChar = magazine.ToCharArray();
        for(int i = 0; i< magazineChar.Count(); i++ )
        {
            if(dict.ContainsKey(magazineChar[i]))
            {
                if(sum == 0)
                {
                   return true;
                }
                if(dict[magazineChar[i]]!=0)
                {
                    dict[magazineChar[i]]--;
                    sum--;
                }
            }
        }

        sum = dict.Values.ToList().Sum();
        if(sum == 0)
        {
            return true;
        }
        return false;
    }
}