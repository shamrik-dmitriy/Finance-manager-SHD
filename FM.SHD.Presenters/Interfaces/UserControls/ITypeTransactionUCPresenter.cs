using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.Interfaces.UserControls
{
    public interface ITypeTransactionUCPresenter 
    {
        ITypeTransactionUCView GetSelectTypeTransactionUserControlView();
        ITypeTransactionUCView GetUserControlView();
    }
}