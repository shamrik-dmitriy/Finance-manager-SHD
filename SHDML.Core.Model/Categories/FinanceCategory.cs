using System.Collections.Generic;

namespace SHDML.CORE.MODEL.Categories
{
    public class FinanceCategory : BaseCategory
    {
        public List<FinanceCategory> SubFinanceCategories { get; set; }
    }
}