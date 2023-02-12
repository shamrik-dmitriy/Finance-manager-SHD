using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace FM.SHD.Plugins.Interfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        string Id { get; }

        bool IsAddDataToTab { get; }
        bool IsAddDataToMenu { get; }

        TabPage GetTab();

        ToolStripMenuItem GetMenuItem();

        IServiceCollection Add();
    }
}