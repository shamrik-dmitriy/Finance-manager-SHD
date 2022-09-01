using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FM.SHDML.Core.Models.Dtos;

namespace SHDML.Winforms.UI.UserControls
{
    public static class CategoryComboboxExtension
    {
        public static int FindId<T>(this ComboBox combobox, long? id) where T : BaseDto
        {
            var objCollection = combobox.Items.Cast<BaseDto>()
                .Select((value, index) => new { Index = index, Value = value });

            foreach (var obj in objCollection)
            {
                if (obj.Value is not T dto) continue;
                if (dto.Id == id)
                {
                    return obj.Index;
                }
            }

            return -1;
        }
    }
}