using System.Data;

namespace BestFood
{
    internal class DishService
    {
        public DishService() { }

        private List<DishDTO> ToDTOList(DataTable dt)
        {
            return dt.AsEnumerable()
                .Select(row => new DishDTO(
                    row.Field<int>("DishID"),
                    row.Field<int>("CategoryID"),
                    row.Field<string>("Name"),
                    row.Field<decimal>("Price"),
                    row.Field<string>("Description")
                    )
                )
                .ToList();
        }

        public List<DishDTO> GetAll()
        {
            string query = "SELECT * FROM dishes;";
            return this.ToDTOList(AppSqlHandler.QueryIntoDataTable(query)); 
        }

        // Get all dishes in a category
        public List<DishDTO> GetByCategoryID(int id) {
            string query = $"SELECT * FROM dishes WHERE CategoryID = {id};";
            return this.ToDTOList(AppSqlHandler.QueryIntoDataTable(query));
        }

        public void AddOne(string foodname, string foodPrice, string foodDescription, string categoryId)
        {
            // Construct the SQL query to insert a new dish into the 'dishes' table
            // Assuming the table 'dishes' has columns 'Name', 'Price', 'Description', 'CategoryID' for dish details
            string query = $"INSERT INTO dishes (Name, Price, Description, CategoryID) VALUES ('{foodname.Replace("'", "''")}', {foodPrice}, '{foodDescription.Replace("'", "''")}', {categoryId});";

            // Call the InsertRow method from AppSqlHandler to execute the query
            bool success = AppSqlHandler.InsertRow(query);

            if (success)
            {
                MessageBox.Show("Dish successfully added.");
            }
            else
            {
                MessageBox.Show("Failed to add dish.");
            }
        }
    }
}
