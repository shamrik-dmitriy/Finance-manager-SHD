using FM.SHD.Infrastructure.MVP.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVP.Core.Presenters
{
    public interface IPresenter
    {
        IView View { get; set; }
    }
}
