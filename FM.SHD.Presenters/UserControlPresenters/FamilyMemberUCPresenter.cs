using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
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