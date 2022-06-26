namespace StudentsApp.Data
{
    public class ModalParameters
    {
        private Dictionary<string,object> _parameters { get; set; }

        public ModalParameters()
        {
            _parameters = new Dictionary<string,object>();
        }
        public void Add(string parameterName, object value)
        {
            _parameters[parameterName] = value;
        }
        public T Get<T>(string parameterName)
        {
            if (!_parameters.ContainsKey(parameterName))
            {
                throw new KeyNotFoundException("Not Exist.");
            }
            return (T)_parameters[parameterName];
        }

        public T TryGet<T>(string parameterName)
        {
            if (_parameters.ContainsKey(parameterName))
            {
                return (T)_parameters[parameterName];
            }
            return default;
        }
    }
}
