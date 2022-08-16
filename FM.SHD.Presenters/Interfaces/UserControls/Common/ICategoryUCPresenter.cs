using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface ICategoryUCPresenter
    {
        ICategoryTransactionUCView GetUserControlView();

        void SetText(string text);
    }
}