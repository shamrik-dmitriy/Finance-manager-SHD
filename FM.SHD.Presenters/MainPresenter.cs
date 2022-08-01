using System;

namespace FM.SHD.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _mainView;
        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
        }

        public IMainView GetMainView()
        {
            return _mainView;
        }
    }
}