using System.IO;

namespace FM.SHD.Settings.Services.Helpers
{
    public class SettingsWriter<T> where T : ISettingsServices
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