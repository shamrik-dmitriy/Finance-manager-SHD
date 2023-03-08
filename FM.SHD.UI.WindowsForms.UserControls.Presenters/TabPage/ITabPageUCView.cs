using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.TabPage
{
    public interface ITabPageUCView: IUserControlView
    {
        void AddUserControlToWorkspaceBlock(UserControl userControl);
        void AddUserControlToButtonBlock(UserControl userControl);
    }
}