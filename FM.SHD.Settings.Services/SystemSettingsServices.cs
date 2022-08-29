using System;
using System.Collections.Generic;
using FM.SHDML.Core.Models.Dtos.UIDto;
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
            RecentOpen = new List<RecentOpenFilesDto>();
        }

        public List<RecentOpenFilesDto> RecentOpen { get; set; }

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