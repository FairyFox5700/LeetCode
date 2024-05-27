 public class SQL
    {

        private Dictionary<string, Dictionary<int, List<string>>> _tableNames = new();

        private Dictionary<string, int> _indexes = new();
        public SQL(IList<string> names, IList<int> columns)
        {

            foreach (var name in names)
            {
                _tableNames.Add(name, new Dictionary<int, List<string>>());
                _indexes.Add(name, 0);
            }

        }

        public void InsertRow(string name, IList<string> row)
        {
            _indexes[name] += 1;
            _tableNames[name].Add(_indexes[name], row.ToList());
        }

        public void DeleteRow(string name, int rowId)
        {

            _tableNames[name][rowId] = new List<string>();

        }

        public string SelectCell(string name, int rowId, int columnId)
        {

           return _tableNames[name][rowId][columnId-1];

        }
    }