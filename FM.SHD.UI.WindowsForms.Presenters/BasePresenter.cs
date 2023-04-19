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
    public abstract class BasePresenter <TView, TArg> : IBasePresenter<TArg>
        where TView : IBaseView
    {
        protected TView ManagementView { get; private set; }

        protected BasePresenter(TView managementView)
        {
            ManagementView = managementView;
        }
        
        public abstract void Run(TArg categoryDto);
        public abstract void Run(string title, TArg transactionDto = default(TArg));
    }
}