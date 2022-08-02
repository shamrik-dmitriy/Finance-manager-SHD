using System;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface ISingleTransactionView : IView
    {
        public event Action Add;
        
    }
}