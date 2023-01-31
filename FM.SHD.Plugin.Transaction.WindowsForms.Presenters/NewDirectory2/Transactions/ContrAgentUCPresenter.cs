using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory2.Transactions
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