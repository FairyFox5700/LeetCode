    public class OrderedStream
    {
        private string[] _resutlInts;
        private int _pointer = 0;
        private List<string> _result = new List<string>();
        public OrderedStream(int n)
        {
            _resutlInts = new string[n+1];
        }

        public IList<string> Insert(int idKey, string value)
        {
            var responce = new List<string>();
            if (idKey -1== _pointer)
            {
                 _resutlInts[idKey - 1] = value;
                while (_resutlInts[_pointer]!=null && _pointer< _resutlInts.Count())
                {
                    responce.Add(_resutlInts[_pointer]);
                    _pointer++;
                }
               
            }
            else{
                _resutlInts[idKey - 1] = value;
               
            }
            

            return responce;
        }
    }