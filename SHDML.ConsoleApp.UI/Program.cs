using System;
using SHDML.Core.JSON;
using SHDML.CORE.MODEL.Receipt;

namespace SHDML.ConsoleApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First version UI of finance checker by Shamrik Dmitriy");
            JsonReceiptLoader t = new JsonReceiptLoader(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\receipt.json");
            var s = t.Load();

       //     var receipt = new ReceiptModel();
        }
    }
}