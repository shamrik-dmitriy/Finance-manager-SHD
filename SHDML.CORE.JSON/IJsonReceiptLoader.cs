using System.Collections.Generic;

namespace SHDML.Core.JSON
{
    public interface IJsonReceiptLoader
    {
        Dictionary<string, object> Load();
    }
}