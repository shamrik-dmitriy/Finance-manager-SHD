using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FM.SHD.Settings.Services
{
    public class SettingServices<T> where T : ISettings
    {
        private readonly T _settings;
        private SettingsWriter<T> _writer;
        private SettingsReader<T> _reader;

        public SettingServices(T settings)
        {
            _settings = settings;
            
            _writer = new SettingsWriter<T>(_settings);
            _reader = new SettingsReader<T>(_settings);

            if (!File.Exists(_settings.Path))
                _writer.WriteSettings();

            var readSettings = _reader.ReadSettings();
            _settings.SetSettings(readSettings);
        }

        public void Save()
        {
            _writer.WriteSettings();
        }

        public T Extract()
        {
            return _settings;
        }
    }

    public class SettingServices : ISettingServices
    {
        private SystemSettings SystemSettings { get; set; }

        private string Path => $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\settings.dat";

        public SettingServices()
        {
            if (!File.Exists(Path))
            {
                using StreamWriter sw = new StreamWriter(Path);
                sw.Write(JsonConvert.SerializeObject(SystemSettings ?? new SystemSettings(), Formatting.Indented));
                //   sw.Write(JsonSerializer.Serialize<Settings>(Settings ?? new Settings(),
                //       new JsonSerializerOptions() { WriteIndented = true }));
            }

            using var reader =
                new StreamReader(File.Open(Path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None));
            var settings = reader.ReadToEnd();
            SystemSettings = JsonConvert.DeserializeObject<SystemSettings>(settings) ?? new SystemSettings();
        }

        public void GetSettings()
        {
        }

        public void SetSettings()
        {
        }

        //public Dictionary<string, string> GetRecentOpenFiles()
        public List<(string FileName, string FilePath)> GetRecentOpenFiles()
        {
            return SystemSettings.RecentOpen;
        }

        public void Save()
        {
            var saveData = JsonConvert.SerializeObject(SystemSettings, Formatting.Indented);
            //JsonSerializer.Serialize<Settings>(Settings, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(Path, saveData);
        }
    }
}