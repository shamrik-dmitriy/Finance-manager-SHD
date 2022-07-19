using FM.SHD.Infrastructure.MVP.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVP.Core.Presenters
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
