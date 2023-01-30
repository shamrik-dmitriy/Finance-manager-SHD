namespace FM.SHD.UI.WindowsForms.Presenters
{
    public abstract class BaseBasePresenter <TView> : IBasePresenter
        where TView : IBaseView
    {
        protected TView BaseView { get; private set; }

        protected BaseBasePresenter(TView baseView)
        {
            BaseView = baseView;
        }
        public abstract void SetTitle(string title);

        public void Run()
        {
            BaseView.Show();
        }
    }
    public abstract class BaseBasePresenter <TView, TArg> : IBasePresenter<TArg>
        where TView : IBaseView
    {
        protected TView BaseView { get; private set; }

        protected BaseBasePresenter(TView baseView)
        {
            BaseView = baseView;
        }

        public abstract void SetTitle(string title);

        public abstract void Run(TArg dto);
    }
}