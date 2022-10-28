namespace FM.SHD.Infrastructure.Dal
{
    public class ConnectionString
    {
        private string _prefix = "DataSource=";

        private string _filePath;

        public ConnectionString(string filePath)
        {
            _filePath = filePath;
        }

        public string GetConnectionString()
        {
            return $"{_prefix}{_filePath}";
        }

        public string GetPath()
        {
            return _filePath;
        }
    }
}