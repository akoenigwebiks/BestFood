using BestFood.DAL;
using BestFood.Models;

namespace BestFood
{
    public partial class OwnerMenu : Form
    {
        private DishService dishService = new DishService();
        private CategoryService categoryService = new CategoryService();
        private OrdersService ordersService = new OrdersService();
        public OwnerMenu()
        {
            InitializeComponent();
            SeedCategories();
            DBGetTotalIncome();
            DBGetTotalOrdersCount();
        }

        private void SeedCategories()
        {
            List<CategoryDTO> categoryDTOs = categoryService.GetCategories();
            datagridView_categories.DataSource = categoryDTOs;

            comboBox_addFood_categories.DataSource = categoryDTOs;
            comboBox_addFood_categories.DisplayMember = "Name";  // Property to display
            comboBox_addFood_categories.ValueMember = "CategoryID";  // Property to use as the actual value
        }

        private void GetFoodsByCategoryID(int categoryID)
        {
            dataGridView_dishesByCategories.DataSource = dishService.GetByCategoryID(categoryID);
        }

        private void button_viewCategoryFoods_Click(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a button cell
            if (e.ColumnIndex == datagridView_categories.Columns[1].Index && e.RowIndex >= 0)
            {
                GetFoodsByCategoryID((int)datagridView_categories.Rows[e.RowIndex].Cells[0].Value);
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
            categoryService.AddOne(categoryToAdd);
        }

        private void DBGetTotalIncome()
        {
            textBox_total_income.Text = ordersService.GetTotalAmount().ToString();
        }

        private void DBGetTotalOrdersCount()
        {
            textBox_total_orders.Text = ordersService.GetTotalOrders().ToString();
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
            dishService.AddOne(foodname, foodPrice, foodDescription, categoryId);
            textBox_addFood_name.Clear();
            textBox_addFood_price.Clear();
            textBox_addFood_description.Clear();

        }
    }
}
