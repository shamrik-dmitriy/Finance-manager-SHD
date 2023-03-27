using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Button
{
    public interface IButtonUCPresenter : IButtonUCView
    {
        IButtonUCView GetUserControlView();
    }
}