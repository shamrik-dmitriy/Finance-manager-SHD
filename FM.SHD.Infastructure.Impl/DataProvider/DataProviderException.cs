using System;
using System.Data;
using System.Runtime.Serialization;

namespace FM.SHD.Infastructure.Impl.DataProvider
{
    [Serializable]
    public class DataProviderException : DataException
    {
        public DataProviderException() { }

        public DataProviderException(string message) : base(message) { }
        public DataProviderException(string message, Exception innerException) : base(message, innerException) { }

        public DataProviderException(SerializationInfo info, StreamingContext streamingContext) : base(info, streamingContext) { }
    }
}
