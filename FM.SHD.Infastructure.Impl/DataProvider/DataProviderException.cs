using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
