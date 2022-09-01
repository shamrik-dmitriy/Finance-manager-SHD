using FM.SHD.Presenters.IntrefacesViews;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Presenters.Interfaces.Views
{
    public interface IAccountPresenter
    {
        public AccountDto AccountDto { get; set; }
        IAccountView GetView();
    }
}