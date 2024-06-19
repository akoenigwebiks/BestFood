namespace BestFood
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public CategoryDTO(string name, int categoryId)
        {
            Name = name;
            CategoryId = categoryId;
        }
    }

    public class DishDTO
    {
        public int DishId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public DishDTO(int dishId, int categoryId, string name, decimal price, string description = "")
        {
            DishId = dishId;
            CategoryId = categoryId;
            Name = name;
            Price = price;
            Description = description;
        }
    }

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

    public class OrderDetailDTO
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderDetailDTO(int orderDetailId, int orderId, int dishId, int quantity, decimal price)
        {
            OrderDetailId = orderDetailId;
            OrderId = orderId;
            DishId = dishId;
            Quantity = quantity;
            Price = price;
        }
    }
}
