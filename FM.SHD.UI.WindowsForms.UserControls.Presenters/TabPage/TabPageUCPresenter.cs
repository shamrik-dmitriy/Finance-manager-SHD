namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.TabPage
{
    public class TabPageUCPresenter : ITabPageUCPresenter
    {
        private readonly ITabPageUCView _tabPageUCView;

        public TabPageUCPresenter(ITabPageUCView tabPageUCView)
        {
            _tabPageUCView = tabPageUCView;
        }

        public ITabPageUCView GetUserControlView()
        {
            return _tabPageUCView;
        }
    }
}