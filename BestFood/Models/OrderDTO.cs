namespace BestFood.Models
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        public OrderDTO(int orderId, DateTime orderDate, decimal totalAmount, string status)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Status = status;
        }
    }
}
