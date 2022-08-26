using System.Collections.Generic;

namespace FM.SHD.Settings.Services
{
    public interface ISettingServices
    {
        public List<(string FileName, string FilePath)> GetRecentOpenFiles();
        void Save();
    }
}