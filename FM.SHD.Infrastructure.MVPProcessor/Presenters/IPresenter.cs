using FM.SHD.Infrastructure.MVPProcessor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVPProcessor.Presenters
{
    public interface IPresenter
    {
        IView View { get; set; }
    }
}
