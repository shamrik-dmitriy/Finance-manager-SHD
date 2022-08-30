using System.IO;

namespace FM.SHD.Settings.Services.Helpers
{
    public class SettingsReader<T> where T : ISettingsServices
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