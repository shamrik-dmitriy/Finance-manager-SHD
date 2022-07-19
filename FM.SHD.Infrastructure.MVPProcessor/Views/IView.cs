using FM.SHD.Infrastructure.MVPProcessor.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVPProcessor.Views
{
    public interface IView
    {
        /// <summary>
        ///     Презентер представления
        /// </summary>
        IPresenter Presenter { get; set; }

        /// <summary>
        ///     Имя представления
        /// </summary>
        string Name { get; set; }
    }
}
