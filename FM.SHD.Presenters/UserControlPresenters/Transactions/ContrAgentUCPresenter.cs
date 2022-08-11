using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
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