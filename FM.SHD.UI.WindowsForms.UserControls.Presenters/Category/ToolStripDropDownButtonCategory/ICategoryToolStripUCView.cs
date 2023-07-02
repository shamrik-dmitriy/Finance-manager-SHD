using System;
using System.Collections.Generic;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ToolStripDropDownButtonCategory
{
    public interface ICategoryToolStripUCView : IUserControlView
    {
        #region Events

        event Action OnLoadUserControlView;

        event Action ClickUserControlView;

        #endregion

        #region Data actions

        void SetText(string text);
        void SetLabelText(string text);
        long? GetCategoryId();
        BaseDto GetCategoryDto();
        void SetDataSource(IEnumerable<BaseDto> value);

        #endregion
        
        void SetCategoryId(long? id);
        
        void SetCategoryFirst();
    }
}