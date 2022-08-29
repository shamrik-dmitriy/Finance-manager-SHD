using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FM.SHD.Settings.Services
{
    [Serializable]
    public class SystemSettingsServices : ISettingsServices
    {
        [JsonIgnore]
        string ISettingsServices.Path =>
            $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\recent-settings.dat";

        public SystemSettingsServices()
        {
            RecentOpen = new List<(string FileName, string FilePath)>();
        }

        public List<(string FileName, string FilePath)> RecentOpen { get; set; }

        string ISettingsServices.GetSettings()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        void ISettingsServices.SetSettings(string settings)
        {
            var deserializeObject = JsonConvert.DeserializeObject<SystemSettingsServices>(settings);
            this.RecentOpen = deserializeObject.RecentOpen;
        }
    }
}