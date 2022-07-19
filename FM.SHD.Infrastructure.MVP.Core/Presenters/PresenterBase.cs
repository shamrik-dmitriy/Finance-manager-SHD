using FM.SHD.Infrastructure.MVPProcessor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVPProcessor.Presenters
{
    public class PresenterBase : IPresenter
    {
        private IView view;

        public virtual IView View
        {
            get { return view; }
            set { view = value; }
        }
    }
}
