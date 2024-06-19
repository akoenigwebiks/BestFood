using System.Data;

namespace BestFood
{
    public partial class OwnerMenu : Form
    {
        public object DataSource_Categories { get; set; }

        public OwnerMenu()
        {
            InitializeComponent();
            GetCategories();
        }

        private void GetCategories()
        {
            // Assuming the categories table has a column named 'Name' for the category names.
            string query = "SELECT * FROM categories;";
            try
            {
                DataTable categoriesTable = AppSqlHandler.QueryIntoDataTable(query);

                // Clear existing categories to avoid duplication if GetCategories is called multiple times.

                DataSource_Categories = categoriesTable
                                            .AsEnumerable()
                                            .Select(row => new CategoryDTO(row.Field<string>("Name"), row.Field<int>("CategoryID")))
                                            .ToList();

                datagridView_categories.DataSource = DataSource_Categories;

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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure the click is on a button cell
            if (e.ColumnIndex == datagridView_categories.Columns[0].Index && e.RowIndex >= 0)
            {
                GetFoodsByCategoryID((int)datagridView_categories.Rows[e.RowIndex].Cells[1].Value);
            }
        }

    }
}
