using System.IO;
using Newtonsoft.Json;

namespace FM.SHD.Settings.Services
{
    public class SettingsReader<T> where T : ISettings
    {
        private readonly T _settings;

        public SettingsReader(T settings)
        {
            _settings = settings;
        }

        public string ReadSettings()
        {
            using var reader =
                new StreamReader(File.Open(_settings.Path, FileMode.OpenOrCreate, FileAccess.ReadWrite,
                    FileShare.None));
            return reader.ReadToEnd();
        }
    }
}