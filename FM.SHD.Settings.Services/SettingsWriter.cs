using System.IO;
using Newtonsoft.Json;

namespace FM.SHD.Settings.Services
{
    public class SettingsWriter<T> where T : ISettings
    {
        private readonly T _settings;

        public SettingsWriter(T settings)
        {
            _settings = settings;
        }

        public void WriteSettings()
        {
            using var sw = new StreamWriter(_settings.Path);
            sw.Write(_settings.GetSettings());
        }
    }
}