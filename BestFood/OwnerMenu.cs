using System.Data;

namespace BestFood
{
    public partial class OwnerMenu : Form
    {
        public OwnerMenu()
        {
            InitializeComponent();
            SeedCategories();
        }

        private void SeedCategories()
        {
            // Assuming the categories table has a column named 'Name' for the category names.
            string query = "SELECT * FROM categories;";
            try
            {
                DataTable categoriesTable = AppSqlHandler.QueryIntoDataTable(query);

                // Clear existing categories to avoid duplication if GetCategories is called multiple times.

                List<CategoryDTO> DataSource_Categories = categoriesTable
                                            .AsEnumerable()
                                            .Select(row => new CategoryDTO(row.Field<string>("Name"), row.Field<int>("CategoryID")))
                                            .ToList();

                datagridView_categories.DataSource = DataSource_Categories;

                comboBox_addFood_categories.DataSource = DataSource_Categories;
                comboBox_addFood_categories.DisplayMember = "Name";  // Property to display
                comboBox_addFood_categories.ValueMember = "CategoryID";  // Property to use as the actual value

                // Optionally update UI elements that depend on Categories list here
                // For example, if you have a ComboBox or a ListBox for categories on the form:
                // categoryComboBox.Items.Clear();
                // categoryComboBox.Items.AddRange(Categories.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load categories: " + ex.Message);
            }
        }

        private void GetFoodsByCategoryID(int categoryID)
        {
            string query = $"SELECT * FROM dishes WHERE CategoryID = {categoryID};";
            try
            {
                DataTable foodsTable = AppSqlHandler.QueryIntoDataTable(query);

                // Assuming the foods table has columns 'Name', 'Price', 'Description' for food details.
                dataGridView_dishesByCategories.DataSource = foodsTable
                                        .AsEnumerable()
                                        .Select(row => new DishDTO(
                                            row.Field<int>("DishID"),
                                            row.Field<int>("CategoryID"),
                                            row.Field<string>("Name"),
                                            row.Field<decimal>("Price"),
                                            row.Field<string>("Description")))
                                        .ToList();
                // Optionally update UI elements that depend on Foods list here
                // For example, if you have a DataGridView for foods on the form:
                // dataGridView2.DataSource = foods;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load foods: " + ex.Message);
            }
        }

        private void button_viewCategoryFoods_Click(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a button cell
            if (e.ColumnIndex == datagridView_categories.Columns[0].Index && e.RowIndex >= 0)
            {
                GetFoodsByCategoryID((int)datagridView_categories.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void button_categoryAdd_Click(object sender, EventArgs e)
        {
            string categoryToAdd = textBox_addCategory.Text;
            if (string.IsNullOrEmpty(categoryToAdd))
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Missing Cateogry name");
                return;
            }
            Microsoft.VisualBasic.Interaction.MsgBox($"{categoryToAdd} Added");
            DBInsertCategory(categoryToAdd);
            this.SeedCategories();
            textBox_addCategory.Clear();

        }

        private void DBInsertCategory(string categoryToAdd)
        {
            // Construct the SQL query to insert a new category into the 'categories' table
            // Assuming the table 'categories' has a column named 'Name' where category names are stored
            string query = $"INSERT INTO categories (Name) VALUES ('{categoryToAdd.Replace("'", "''")}');";

            // Call the InsertRow method from AppSqlHandler to execute the query
            bool success = AppSqlHandler.InsertRow(query);

            if (success)
            {
                MessageBox.Show("Category successfully added.");
            }
            else
            {
                MessageBox.Show("Failed to add category.");
            }
        }

        private void DBInsertDish(string foodname, string foodPrice, string foodDescription, string categoryId)
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
        
        private void button_addFood_Click(object sender, EventArgs e)
        {
            string foodname = textBox_addFood_name.Text;
            string foodPrice = textBox_addFood_price.Text;
            string foodDescription = textBox_addFood_description.Text;
            string categoryId = comboBox_addFood_categories.SelectedValue.ToString();

            string messages = "";

            if (string.IsNullOrEmpty(foodname) ||
                string.IsNullOrEmpty(foodPrice) ||
                string.IsNullOrEmpty(foodDescription) ||
                string.IsNullOrEmpty(categoryId)
                )
            {
                messages += "\nPlease fill all fields";
            }

            if (!decimal.TryParse(foodPrice, out _))
            {
                messages += "\nPlease enter a valid price";
            }

            if (!string.IsNullOrEmpty(messages))
            {
                MessageBox.Show(messages);
                return;
            }

            this.DBInsertDish(foodname, foodPrice, foodDescription, categoryId);
            textBox_addFood_name.Clear();
            textBox_addFood_price.Clear();
            textBox_addFood_description.Clear();

        }
    }
}
