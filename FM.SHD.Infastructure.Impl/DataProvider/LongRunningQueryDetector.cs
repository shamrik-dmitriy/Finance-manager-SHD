using FM.SHD.Infrastructure.Dal.Providers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infastructure.Impl.DataProvider
{
    // TODO: Завести сюда логирование
    internal class LongRunningQueryDetector : IDisposable
    {
        private readonly Func<string> _getSql;
        private readonly Func<DataParameter[]> _parameters;
        private Stopwatch _stopwatch;
        private bool _isDisposed = false;

        public LongRunningQueryDetector(Func<string> getSql, Func<DataParameter[]> parameters)
        {
            _getSql = getSql;
            _parameters = parameters;
            _stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                _stopwatch.Stop();

                if (_stopwatch.Elapsed.TotalSeconds > 2)
                {
                    Console.WriteLine("Время выполнения запроса = {2} of \"{0}\", с параметрами \"{1}\"", _getSql(),
                        string.Join(" # ", _parameters().Select(o =>
                            string.Format("{0}={1}", o.Name, o.Value))), _stopwatch.Elapsed);
                }
            }
        }
    }
}
