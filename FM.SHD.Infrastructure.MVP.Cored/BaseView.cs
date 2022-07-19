using FM.SHD.Infrastructure.MVP.Core.Presenters;
using FM.SHD.Infrastructure.MVP.Core.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM.SHD.Infrastructure.MVP.Core
{
    public partial class BaseView : Form, IView, INotifyView
    {
        #region Private member variable

        private IPresenter _presenter;
        private string _viewName;

        #endregion

        #region Public properties

        public virtual IPresenter Presenter
        {
            get { return _presenter; }
            set { _presenter = value; }
        }

        public virtual string ViewName
        {
            get { return _viewName; }
            set { _viewName = value; }
        }
        #endregion

        #region Constructor

        public BaseView()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Methods

        public virtual void Activate(bool isActive)
        {
        }

        public virtual void Initialize()
        {

        }

        #endregion
    }
}
