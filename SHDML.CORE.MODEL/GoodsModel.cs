namespace SHDML.CORE.MODEL
{
    public class GoodsModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Sum { get; set; }
        // TODO: Enum
        public int PaymentType { get; set; }
        // TODO: Enum
        public int Nds { get; set; }
    }
}