using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVP.Core.Views
{
    public interface IViewsManager
    {
        void ActivateView(string viewName);

        IView GetView(string viewName);
    }
}
