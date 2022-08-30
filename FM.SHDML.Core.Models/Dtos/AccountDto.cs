namespace FM.SHDML.Core.Models.Dtos
{
    public class AccountDto : BaseDto
    {
        public string Description { get; set; }

        public decimal CurrentSum { get; set; }

        public decimal InitialSum { get; set; }

        public bool IsClosed { get; set; }

        public long? CurrencyId { get; set; }

        public long? CategoryId { get; set; }

        public long IdentityId { get; set; }
    }
}