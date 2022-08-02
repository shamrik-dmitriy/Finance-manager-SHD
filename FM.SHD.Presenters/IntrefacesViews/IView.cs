namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface IView
    {
        void ShowDialog();
        void ShowDialog(string title);
        void Show();
    }
}