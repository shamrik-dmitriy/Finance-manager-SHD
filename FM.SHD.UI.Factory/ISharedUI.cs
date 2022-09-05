namespace FM.SHD.UI.Factory
{
    public interface ISharedUI
    {
        ISharedPresenter CreateSharedPresenter();
        ISharedView CreateSharedView();
    }
}