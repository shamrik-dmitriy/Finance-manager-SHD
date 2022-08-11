using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
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