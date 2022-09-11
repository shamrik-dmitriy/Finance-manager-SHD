using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Winforms.UI.UserControls.Common
{
    public partial class DataControlButtonsUCView : UserControl, IDataControlButtonsUCView
    {
        #region Public events

        public event Action Continue;
        public event Action Cancel;
        public event Action Delete;

        #endregion

        #region Constructor / Destructor

        public DataControlButtonsUCView()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private void continueButton_Click(object sender, EventArgs e)
        {
            Continue?.Invoke();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete?.Invoke();
        }

        #endregion

        #region Public methods

        public void SetTextButtonCancel(string text)
        {
            cancelButton.Text = text;
        }

        public void SetTextButtonContinue(string text)
        {
            continueButton.Text = text;
        }

        public void SetVisibleButtonDelete(bool isVisible)
        {
            deleteButton.Visible = isVisible;
        }

        public void SetTextButtonDelete(string text)
        {
            deleteButton.Text = text;
        }

        public void CloseParentView()
        {
            ((Form)TopLevelControl)?.Close();
        }

        #endregion
    }
}