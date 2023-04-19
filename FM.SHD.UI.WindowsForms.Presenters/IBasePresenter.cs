namespace FM.SHD.UI.WindowsForms.Presenters
{
    public interface IBasePresenter
    {
        void Run();
    }

    public interface IBasePresenter<in T>
    {
        void Run(T categoryDto);
    }
}