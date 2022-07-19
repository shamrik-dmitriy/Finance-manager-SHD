using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.MVPProcessor.Views
{
    /// <summary>
    ///     Если представление реализует этот интерфейс, то менеджер представлений
    ///     уведомит соответствующий объект представления о событии активации или 
    ///     инициализации через операции данного интерфейса
    /// </summary>
    public interface INotifiedView
    {
        /// <summary>
        ///     Уведомление представления об активации
        /// </summary>
        /// <param name="isActive">True - активно, False - не активно</param>
        void Activate(bool isActive);

        /// <summary>
        ///     Уведомление представления о инициализации
        /// </summary>
        void Initialize();
    }
}
