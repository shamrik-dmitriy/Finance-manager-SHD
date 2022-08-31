using System.Collections.Generic;

namespace SHDML.CORE.JSON
{
    public interface IJsonReceiptLoader
    {
        Dictionary<string, object> Load();
    }
}