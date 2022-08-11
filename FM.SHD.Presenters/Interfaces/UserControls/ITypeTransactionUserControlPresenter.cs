using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.Interfaces.UserControls
{
    public interface ITypeTransactionUserControlPresenter
    {
        ITypeTransactionUserControlView GetSelectTypeTransactionUserControlView();
        ITypeTransactionUserControlView GetUserControlView();
    }
}
