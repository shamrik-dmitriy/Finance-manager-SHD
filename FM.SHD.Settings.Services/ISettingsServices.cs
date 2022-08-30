namespace FM.SHD.Settings.Services
{
    public interface ISettingsServices
    {
        internal string Path { get; }
        internal string GetSettings();
        internal void SetSettings(string settings);
    }
}