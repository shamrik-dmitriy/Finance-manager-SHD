namespace FM.SHD.Settings.Services
{
    public interface ISettings
    {
        internal string Path { get; }
        internal string GetSettings();
        internal void SetSettings(string settings);
    }
}