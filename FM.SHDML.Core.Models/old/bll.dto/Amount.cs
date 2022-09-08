namespace FM.SHDML.Core.Models.old.bll.dto
{
    public class Amount
    {
        private decimal _cost;
        private double _count;
        private decimal _sum;
        private decimal _tax;
        private decimal _discount;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public double Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public decimal Sum
        {
            get { return _sum != 0 ? _sum : Cost * (decimal)Count + Tax - Discount; }
            set { _sum = value; }
        }

        public decimal Tax { get; set; }
        public decimal Discount { get; set; }

        public Amount(decimal cost, double count, decimal sum, decimal tax, decimal discount)
        {
            Cost = cost;
            Count = count;
            Sum = sum;
            Tax = tax;
            Discount = discount;
        }
    }
}