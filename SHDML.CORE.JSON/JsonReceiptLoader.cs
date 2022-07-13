using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SHDML.Core.JSON
{
    public class JsonReceiptLoader : IJsonReceiptLoader
    {
        private string JsonPath { get; }

        public JsonReceiptLoader(string path)
        {
            JsonPath = path;
        }

        public Dictionary<string, object> Load()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(
                string.Join("",
                    File.ReadAllLines(JsonPath)));
        }
    }
}