using FM.SHD.Presenters.Common;
using FM.SHD.Presenters.NewViews;

namespace FM.SHD.Presenters.NewPresenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        public MainPresenter(IMainView view) : base(view)
        {
        }

        public void Run()
        {
            View.Show();
        }
    }
}