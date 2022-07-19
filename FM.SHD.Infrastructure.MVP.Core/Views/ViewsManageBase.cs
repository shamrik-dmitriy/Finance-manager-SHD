using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVPProcessor.Views
{
    public class ViewsManageBase : IViewsManager
    {
        public void ActivateView(string viewName)
        {
        }

        public IView GetView(string viewName)
        {
            return null;
        }
    }
}
