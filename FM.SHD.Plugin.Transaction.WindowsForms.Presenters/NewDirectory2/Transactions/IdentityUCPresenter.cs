using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory2.Transactions
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