namespace FM.SHD.Presenters.Common
{
    public interface IPresenter
    {
        void Run();
    }

    public interface IPresenter<in T>
    {
        void Run(T accountDto);
    }
}