using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Button
{
    public class ButtonUCPresenter : IButtonUCPresenter
    {
        private readonly IButtonUCView _buttonUCView;

        public ButtonUCPresenter(IButtonUCView buttonUCView)
        {
            _buttonUCView = buttonUCView;
        }

        public void SetText(string text)
        {
            _buttonUCView.SetText(text);
        }

        public void SetVisible(bool visible)
        {
            _buttonUCView.SetVisible(visible);
        }

        public void SetEnabled(bool enable)
        {
            _buttonUCView.SetEnabled(enable);
        }

        public IButtonUCView GetUserControlView()
        {
            return _buttonUCView;
        }
    }
}