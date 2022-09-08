using System.Collections.Generic;

namespace FM.SHD.JsonLoader.Services
{
    public interface IJsonReceiptLoader
    {
        Dictionary<string, object> Load();
    }
}