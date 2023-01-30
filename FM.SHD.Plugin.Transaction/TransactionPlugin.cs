using System;
using System.Windows.Forms;
using FM.SHD.Plugins.Infrastructure;

namespace FM.SHD.Plugin.Transaction
{
    public class TransactionPlugin : IPlugin
    {
        private string _connectionString;
        
        public string Name => "Плагин транзакций";
        public string Id => "Transaction";
        public string Description => "Плагин добавляет функциональность для работы с транзакциями";
        public bool IsAddDataToTab => true;
        public bool IsAddDataToMenu => false;

        public TransactionPlugin()
        {
        }

        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public TransactionPlugin(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public TabPage GetTab()
        {
            throw new NotImplementedException();
        }

        public ToolStripMenuItem GetMenuItem()
        {
            throw new NotImplementedException();
        }
    }
}