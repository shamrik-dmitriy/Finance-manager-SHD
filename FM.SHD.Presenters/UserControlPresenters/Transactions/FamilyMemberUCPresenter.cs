using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class FamilyMemberUCPresenter : IFamilyMemberUCPresenter
    {
        private readonly IFamilyMemberUCView _familyMemberUcView;

        public FamilyMemberUCPresenter(IFamilyMemberUCView familyMemberUcView)
        {
            _familyMemberUcView = familyMemberUcView;
        }

        public IFamilyMemberUCView GetUserControlView()
        {
            return _familyMemberUcView;
        }
    }
}