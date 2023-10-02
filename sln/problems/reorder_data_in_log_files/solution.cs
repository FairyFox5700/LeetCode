    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
                        var digitLogs = logs.Where(e => Char.IsNumber(e.Split(' ')[1].First())).ToList();
            //Console.WriteLine("Digit logs: " + string.Join(",", digitLogs));
            var letterLogs = logs.Where(e => !Char.IsNumber(e.Split(' ')[1].First())).ToList();
            //Console.WriteLine("Letter logs: " + string.Join(",", letterLogs));
            letterLogs.Sort((a, b) =>
            {
                //["let1 art can","let3 art zero"
                var aSplit = a.Split(' ');
                var bSplit = b.Split(' ');
                var compA = a.Substring(aSplit[0].Length);
                var compB = b.Substring(bSplit[0].Length);

                var key1 = aSplit[0].Where(e => char.IsLetter(e)).ToArray();
                var key2 = bSplit[0].Where(e => char.IsLetter(e)).ToArray();
                var key1Str = new string(key1);
                var key2Str = new string(key2);

                var comp =compA.CompareTo(compB);
                if (comp != 0)
                {
                    return comp;
                }
                else
                {
                    return   key1Str.CompareTo(key2Str);
                }
            });

            letterLogs.AddRange(digitLogs);

            return letterLogs.ToArray();
        }
    }