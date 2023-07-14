public class TimeMap {
    public Dictionary<string, List<TimeMapNode>> Dict = new Dictionary<string, List<TimeMapNode>> ();
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if(Dict.ContainsKey(key))
        {
             Dict[key].Add(new TimeMapNode 
                {
                    Time =timestamp,
                    Value = value, 
                });
        }
        
            else 
            {
                Dict.Add(key, new List<TimeMapNode > {
                new TimeMapNode 
                {
                    Time =timestamp,
                    Value = value, 
                }});
            
        }
    }
    
    public string Get(string key, int timestamp) {
        if(!Dict.ContainsKey(key))
        {
            return "";
        }
        else
        {
            var vals = Dict[key];
            // binary search to search time wich is less or equal
          
            var left = 0;
            var right = vals.Count() -1;
            string result = "";
            while (left <= right)
            {
                var mid = (left + right)/2;
                if(vals[mid].Time <= timestamp)
                {
                    left = mid  + 1;
                    result = vals[mid].Value;
                }
                else{
                    right = mid -1;
                }
            }
            return result;
        }
    }
}

public class TimeMapNode
{
    public int Time {get; set;}
    public string Value {get; set;}
  
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */