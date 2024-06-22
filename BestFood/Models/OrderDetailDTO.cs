using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFood.Models
{
    public class OrderDetailDTO
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int DishId { get; set; }
        public string DishName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderDetailDTO(int orderDetailId, int orderId, int dishId, int quantity, decimal price, string dishName = "")
        {
            OrderDetailId = orderDetailId;
            OrderId = orderId;
            DishId = dishId;
            Quantity = quantity;
            Price = price;
            DishName = dishName;
        }
    }
}
