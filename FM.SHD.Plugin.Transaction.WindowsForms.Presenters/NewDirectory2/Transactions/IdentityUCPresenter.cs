using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
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