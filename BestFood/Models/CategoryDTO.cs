namespace BestFood.Models
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
}
