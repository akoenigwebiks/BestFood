using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFood.Models
{
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
}
