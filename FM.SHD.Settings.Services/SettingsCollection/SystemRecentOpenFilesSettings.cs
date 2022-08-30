using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FM.SHD.Settings.Services.SettingsCollection
{
    [Serializable]
    public class SystemRecentOpenFilesSettings : ISettingsServices
    {
        [JsonIgnore]
        string ISettingsServices.Path =>
            $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\recent-settings.dat";

        public SystemRecentOpenFilesSettings()
        {
            RecentOpen = new List<(string FileName, string FilePath)>();
        }

        public List<(string FileName, string FilePath)> RecentOpen { get; set; }

        string ISettingsServices.GetSettings()
        {
            RecentOpen.RemoveAll(x => string.IsNullOrWhiteSpace(x.FileName) ||
                                      string.IsNullOrWhiteSpace(x.FilePath));
         
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        void ISettingsServices.SetSettings(string settings)
        {
            var deserializeObject = JsonConvert.DeserializeObject<SystemRecentOpenFilesSettings>(settings);
            this.RecentOpen = deserializeObject.RecentOpen;
        }
    }
}