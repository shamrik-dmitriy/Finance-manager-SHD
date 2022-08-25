using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface ILoginView : IView
    {
        void AddUserControl(IUserControlView userControlView);
    }
}
