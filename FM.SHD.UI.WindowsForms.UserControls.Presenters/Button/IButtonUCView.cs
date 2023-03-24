using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Button
{
    public interface IButtonUCView : IUserControlView
    {
        void SetText(string text);
        void SetVisible(bool visible);
        void SetEnabled(bool enable);
    }
}