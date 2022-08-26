using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FM.SHD.Settings.Services
{
    [Serializable]
    public class SystemSettings : ISettings
    {
        [JsonIgnore]
        string ISettings.Path =>
            $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\recent-settings.dat";

        public SystemSettings()
        {
            RecentOpen = new List<(string FileName, string FilePath)>();
        }

        public List<(string FileName, string FilePath)> RecentOpen { get; set; }

        string ISettings.GetSettings()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        void ISettings.SetSettings(string settings)
        {
            var deserializeObject = JsonConvert.DeserializeObject<SystemSettings>(settings);
            this.RecentOpen = deserializeObject.RecentOpen;
        }
    }
}