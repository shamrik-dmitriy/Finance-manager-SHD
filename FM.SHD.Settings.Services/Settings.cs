using System;
using System.Collections.Generic;

namespace FM.SHD.Settings.Services
{
    [Serializable]
    public class Settings
    {
        public Settings()
        {
            RecentOpen = new List<(string FileName, string FilePath)>();
            //   RecentOpen = new Dictionary<string, string>();
        }

        //public Dictionary<string, string> RecentOpen { get; set; }

        public List<(string FileName, string FilePath)> RecentOpen { get; set; }
    }
}