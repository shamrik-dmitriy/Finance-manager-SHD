using System;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace SHDML.CORE.JSON
{
    public class JsonReceiptParser
    {
        private string JsonPath { get; }

        public JsonReceiptParser(string path)
        {
            JsonPath = path;
        }

        public void Parse()
        {
            var tmp = File.ReadAllLines(JsonPath);
            var rawJson = JObject.Parse(string.Join("",tmp));
        }
    }
}