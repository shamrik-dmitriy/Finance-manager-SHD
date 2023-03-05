using System.Linq;
using System.Windows.Forms;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.UserControls.Views.Extensions
{
    public static class CategoryComboboxExtension
    {
        /// <summary>
        ///     Данный метод подходит только для тех Combobox, в которые точно попадают элементы у которых есть индекс 0.
        ///     Например - типы транзакций
        /// </summary>
        /// <param name="combobox"></param>
        /// <param name="id"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
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