using FM.SHD.UI.WindowsForms.SharedInterfaces.AClasses;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Categories.Views;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.AClasses;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Categories.WindowsForms.Presenters
{
    public class CategoryPresenter : ACategoriesBasePresenter
    {
        private readonly ICategoryManagementView _managementView;
        public CategoryDto CategoryDto { get; set; }
        
        public CategoryPresenter(ICategoryManagementView managementView) : base(managementView)
        {
            _managementView = managementView;
        }

        public override void Run(CategoryDto categoryDto)
        {
            CategoryDto = categoryDto;
            _managementView.Show();
        }

        public override void Run(string title, CategoryDto transactionDto = default(CategoryDto))
        {
            throw new System.NotImplementedException();
        }
    }
}