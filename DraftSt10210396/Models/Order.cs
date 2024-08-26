namespace DraftSt10210396.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }
    }
}

