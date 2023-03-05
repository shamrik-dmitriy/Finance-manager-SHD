using System;

namespace FM.SHD.Infrastructure.Dal.Providers.Interfaces
{
    public interface IConnection : IDisposable
    {
        /// <summary>
        ///     Получить провайдер для выполнения работ с БД
        /// </summary>
        IDataProvider DataProvider { get; }

        /// <summary>
        ///     Создать транзакцию и работать с ней
        /// </summary>
        ITransaction BeginTransaction();
    }
}
