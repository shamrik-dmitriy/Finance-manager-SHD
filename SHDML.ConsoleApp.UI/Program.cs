using System;
using SHDML.Core.JSON;

namespace SHDML.ConsoleApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First version UI of finance checker by Shamrik Dmitriy");
            JsonReceiptParser t = new JsonReceiptParser(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\receipt.json");
            t.Parse();
        }
    }
}