using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FM.SHD.Settings.Services
{
    public class SettingServices : ISettingServices
    {
        private Settings Settings { get; set; }

        private string Path => $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\settings.dat";

        public SettingServices()
        {
            if (!File.Exists(Path))
            {
                using StreamWriter sw = new StreamWriter(Path);
                sw.Write(JsonConvert.SerializeObject(Settings ?? new Settings(), Formatting.Indented));
             //   sw.Write(JsonSerializer.Serialize<Settings>(Settings ?? new Settings(),
             //       new JsonSerializerOptions() { WriteIndented = true }));
            }

            using var reader =
                new StreamReader(File.Open(Path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None));
            var settings = reader.ReadToEnd();
            Settings = JsonConvert.DeserializeObject<Settings>(settings) ?? new Settings();
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
            return Settings.RecentOpen;
        }

        public void Save()
        {
            var saveData = JsonConvert.SerializeObject(Settings, Formatting.Indented);
                           //JsonSerializer.Serialize<Settings>(Settings, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(Path, saveData);
        }
    }
}