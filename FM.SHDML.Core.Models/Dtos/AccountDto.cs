namespace FM.SHDML.Core.Models.Dtos
{
    public class AccountDto : BaseCategoryDto
    {
        public string Description { get; set; }

        public decimal CurrentSum { get; set; }

        public decimal InitialSum { get; set; }

        public bool IsClosed { get; set; }

        public string Currency { get; set; }
    }
}