using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters
{
    public class IdentityUCPresenter : IIdentityUCPresenter
    {
        private readonly IIdentityUCView _familyMemberUcView;

        public IdentityUCPresenter(IIdentityUCView familyMemberUcView)
        {
            _familyMemberUcView = familyMemberUcView;
        }

        public IIdentityUCView GetUserControlView()
        {
            return _familyMemberUcView;
        }
    }
}