using System.Data;

namespace BestFood
{
    internal class CategoryService
    {
        public CategoryService() { }

        public List<CategoryDTO> GetCategories()
        {
            string query = "SELECT * FROM categories;";
            return AppSqlHandler.QueryIntoDataTable(query)
                .AsEnumerable()
                .Select(row => new CategoryDTO(
                    row.Field<string>("Name"),
                    row.Field<int>("CategoryID")
                    )
                )
                .ToList();
        }

        public string GetCategory(int id)
        {
            string query = $"SELECT Name FROM categories WHERE CategoryID = {id};";
            return AppSqlHandler.QueryIntoDataTable(query).Rows[0].Field<string>("Name");
        }

        public bool AddOne(string categoryToAdd)
        {
            string query = $"INSERT INTO categories (Name) VALUES ('{categoryToAdd.Replace("'", "''")}');";
            return AppSqlHandler.InsertRow(query);
        }
    }
}
