using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVP.Core.Views
{
    public class ViewsManagerBase : IViewsManager
    {
        protected Hashtable views = new Hashtable();


        public void ActivateView(string viewName)
        {
        }

        public IView GetView(string viewName)
        {
            return null;
        }
    }
}
