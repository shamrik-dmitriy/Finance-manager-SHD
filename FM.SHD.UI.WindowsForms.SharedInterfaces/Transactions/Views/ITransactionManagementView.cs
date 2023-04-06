using System;
using FM.SHD.UI.WindowsForms.Presenters;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Views
{
    public interface ITransactionManagementView : IBaseView
    {
        void Clear();
        bool ShowMessageDelete(string title, string message);
    }
}