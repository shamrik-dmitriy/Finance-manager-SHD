using FM.SHD.Presenters.IntrefacesViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Presenters.Interfaces.Views
{
    internal interface ILoginPresenter
    {
        ILoginView GetView();
    }
}
