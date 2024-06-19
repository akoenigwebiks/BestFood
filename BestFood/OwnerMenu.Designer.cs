namespace BestFood
{
    partial class OwnerMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            categories = new Label();
            categoryDTOBindingSource = new BindingSource(components);
            categoryDTOBindingSource1 = new BindingSource(components);
            categoriesBindingSource = new BindingSource(components);
            datagridView_categories = new DataGridView();
            getFoodsForCategory = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            categoryDTOBindingSource2 = new BindingSource(components);
            label1 = new Label();
            dishDTOBindingSource = new BindingSource(components);
            dataGridView_dishesByCategories = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            textBox_addCategory = new TextBox();
            button_categoryAdd = new Button();
            panel_addFood = new Panel();
            label_addFood_Description = new Label();
            textBox_addFood_description = new TextBox();
            label_addFood_Name = new Label();
            label_addFood_Category = new Label();
            comboBox_addFood_categories = new ComboBox();
            textBox_addFood_name = new TextBox();
            button_addFood = new Button();
            label_addFood_price = new Label();
            textBox_addFood_price = new TextBox();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridView_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dishesByCategories).BeginInit();
            panel1.SuspendLayout();
            panel_addFood.SuspendLayout();
            SuspendLayout();
            // 
            // categories
            // 
            categories.AutoSize = true;
            categories.Location = new Point(1079, 9);
            categories.Name = "categories";
            categories.Size = new Size(89, 28);
            categories.TabIndex = 0;
            categories.Text = "קטגוריות";
            // 
            // datagridView_categories
            // 
            datagridView_categories.AutoGenerateColumns = false;
            datagridView_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView_categories.Columns.AddRange(new DataGridViewColumn[] { getFoodsForCategory, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            datagridView_categories.DataSource = categoryDTOBindingSource2;
            datagridView_categories.Location = new Point(764, 58);
            datagridView_categories.Name = "datagridView_categories";
            datagridView_categories.RowHeadersWidth = 51;
            datagridView_categories.Size = new Size(428, 188);
            datagridView_categories.TabIndex = 1;
            datagridView_categories.CellClick += button_viewCategoryFoods_Click;
            // 
            // getFoodsForCategory
            // 
            getFoodsForCategory.HeaderText = "צפייה";
            getFoodsForCategory.MinimumWidth = 6;
            getFoodsForCategory.Name = "getFoodsForCategory";
            getFoodsForCategory.Text = "צפה";
            getFoodsForCategory.UseColumnTextForButtonValue = true;
            getFoodsForCategory.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CategoryId";
            dataGridViewTextBoxColumn3.HeaderText = "מזהה";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            dataGridViewTextBoxColumn4.HeaderText = "קטגוריה";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // categoryDTOBindingSource2
            // 
            categoryDTOBindingSource2.DataSource = typeof(CategoryDTO);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1092, 268);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 2;
            label1.Text = "מאכלים";
            // 
            // dishDTOBindingSource
            // 
            dishDTOBindingSource.DataSource = typeof(DishDTO);
            // 
            // dataGridView_dishesByCategories
            // 
            dataGridView_dishesByCategories.AutoGenerateColumns = false;
            dataGridView_dishesByCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_dishesByCategories.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView_dishesByCategories.DataSource = dishDTOBindingSource;
            dataGridView_dishesByCategories.Location = new Point(738, 320);
            dataGridView_dishesByCategories.Name = "dataGridView_dishesByCategories";
            dataGridView_dishesByCategories.RowHeadersWidth = 51;
            dataGridView_dishesByCategories.Size = new Size(454, 188);
            dataGridView_dishesByCategories.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "שם";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "מחיר";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "תיאור";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_addCategory);
            panel1.Controls.Add(button_categoryAdd);
            panel1.Location = new Point(323, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 188);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 16);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 2;
            label2.Text = "קטגוריה";
            // 
            // textBox_addCategory
            // 
            textBox_addCategory.Location = new Point(50, 47);
            textBox_addCategory.Name = "textBox_addCategory";
            textBox_addCategory.Size = new Size(257, 34);
            textBox_addCategory.TabIndex = 1;
            // 
            // button_categoryAdd
            // 
            button_categoryAdd.Location = new Point(51, 108);
            button_categoryAdd.Name = "button_categoryAdd";
            button_categoryAdd.Size = new Size(257, 41);
            button_categoryAdd.TabIndex = 0;
            button_categoryAdd.Text = "הוספת קטגוריה";
            button_categoryAdd.UseVisualStyleBackColor = true;
            button_categoryAdd.Click += button_categoryAdd_Click;
            // 
            // panel_addFood
            // 
            panel_addFood.Controls.Add(label_addFood_price);
            panel_addFood.Controls.Add(textBox_addFood_price);
            panel_addFood.Controls.Add(label_addFood_Description);
            panel_addFood.Controls.Add(textBox_addFood_description);
            panel_addFood.Controls.Add(label_addFood_Name);
            panel_addFood.Controls.Add(label_addFood_Category);
            panel_addFood.Controls.Add(comboBox_addFood_categories);
            panel_addFood.Controls.Add(textBox_addFood_name);
            panel_addFood.Controls.Add(button_addFood);
            panel_addFood.Location = new Point(323, 320);
            panel_addFood.Name = "panel_addFood";
            panel_addFood.Size = new Size(343, 407);
            panel_addFood.TabIndex = 5;
            // 
            // label_addFood_Description
            // 
            label_addFood_Description.AutoSize = true;
            label_addFood_Description.Location = new Point(248, 238);
            label_addFood_Description.Name = "label_addFood_Description";
            label_addFood_Description.Size = new Size(61, 28);
            label_addFood_Description.TabIndex = 9;
            label_addFood_Description.Text = "תיאור";
            // 
            // textBox_addFood_descriptions
            // 
            textBox_addFood_description.Location = new Point(51, 269);
            textBox_addFood_description.Name = "textBox_addFood_descriptions";
            textBox_addFood_description.Size = new Size(257, 34);
            textBox_addFood_description.TabIndex = 8;
            // 
            // label_addFood_Name
            // 
            label_addFood_Name.AutoSize = true;
            label_addFood_Name.Location = new Point(248, 97);
            label_addFood_Name.Name = "label_addFood_Name";
            label_addFood_Name.Size = new Size(60, 28);
            label_addFood_Name.TabIndex = 7;
            label_addFood_Name.Text = "מאכל";
            // 
            // label_addFood_Category
            // 
            label_addFood_Category.AutoSize = true;
            label_addFood_Category.Location = new Point(224, 21);
            label_addFood_Category.Name = "label_addFood_Category";
            label_addFood_Category.Size = new Size(83, 28);
            label_addFood_Category.TabIndex = 3;
            label_addFood_Category.Text = "קטגוריה";
            // 
            // comboBox_addFood_categories
            // 
            comboBox_addFood_categories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_addFood_categories.FormattingEnabled = true;
            comboBox_addFood_categories.Location = new Point(50, 52);
            comboBox_addFood_categories.Name = "comboBox_addFood_categories";
            comboBox_addFood_categories.Size = new Size(257, 36);
            comboBox_addFood_categories.TabIndex = 6;
            // 
            // textBox_addFood_name
            // 
            textBox_addFood_name.Location = new Point(51, 128);
            textBox_addFood_name.Name = "textBox_addFood_name";
            textBox_addFood_name.Size = new Size(257, 34);
            textBox_addFood_name.TabIndex = 1;
            // 
            // button_addFood
            // 
            button_addFood.Location = new Point(52, 326);
            button_addFood.Name = "button_addFood";
            button_addFood.Size = new Size(257, 41);
            button_addFood.TabIndex = 0;
            button_addFood.Text = "הוספת קטגוריה";
            button_addFood.UseVisualStyleBackColor = true;
            button_addFood.Click += button_addFood_Click;
            // 
            // label_addFood_price
            // 
            label_addFood_price.AutoSize = true;
            label_addFood_price.Location = new Point(253, 171);
            label_addFood_price.Name = "label_addFood_price";
            label_addFood_price.Size = new Size(54, 28);
            label_addFood_price.TabIndex = 11;
            label_addFood_price.Text = "מחיר";
            // 
            // textBox_addFood_price
            // 
            textBox_addFood_price.Location = new Point(50, 202);
            textBox_addFood_price.Name = "textBox_addFood_price";
            textBox_addFood_price.Size = new Size(257, 34);
            textBox_addFood_price.TabIndex = 10;
            // 
            // OwnerMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 739);
            Controls.Add(panel_addFood);
            Controls.Add(panel1);
            Controls.Add(dataGridView_dishesByCategories);
            Controls.Add(label1);
            Controls.Add(datagridView_categories);
            Controls.Add(categories);
            Font = new Font("Segoe UI", 12F);
            Name = "OwnerMenu";
            Text = "OwnerMenu";
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridView_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dishesByCategories).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_addFood.ResumeLayout(false);
            panel_addFood.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categories;
        private BindingSource categoryDTOBindingSource;
        private BindingSource categoryDTOBindingSource1;
        private BindingSource categoriesBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView datagridView_categories;
        private BindingSource categoryDTOBindingSource2;
        private Label label1;
        private BindingSource dishDTOBindingSource;
        private DataGridView dataGridView_dishesByCategories;
        private DataGridViewButtonColumn getFoodsForCategory;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Panel panel1;
        private Button button_categoryAdd;
        private TextBox textBox_addCategory;
        private Panel panel_addFood;
        private TextBox textBox_addFood_name;
        private Button button_addFood;
        private Label label2;
        private Label label_addFood_Description;
        private TextBox textBox_addFood_description;
        private Label label_addFood_Name;
        private Label label_addFood_Category;
        private ComboBox comboBox_addFood_categories;
        private Label label_addFood_price;
        private TextBox textBox_addFood_price;
    }
}
