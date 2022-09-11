namespace FM.SHD.Presenters.Common
{
    public abstract class BasePresenter <TView> : IPresenter
        where TView : IView
    {
        protected TView View { get; private set; }

        protected BasePresenter(TView view)
        {
            View = view;
        }
        public abstract void SetTitle(string title);

        public void Run()
        {
            View.Show();
        }
    }
    public abstract class BasePresenter <TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView View { get; private set; }

        protected BasePresenter(TView view)
        {
            View = view;
        }

        public abstract void SetTitle(string title);

        public abstract void Run(TArg dto);
    }
}