using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.UserControls
{
    public class ContrAgentUCPresenter : IContrAgentUCPresenter
    {
        private readonly IContrAgentUCView _contrAgentTUCView;

        public ContrAgentUCPresenter(IContrAgentUCView contrAgentTucView)
        {
            _contrAgentTUCView = contrAgentTucView;
        }

        public IContrAgentUCView GetUserControlView()
        {
            return _contrAgentTUCView;
        }
    }
}