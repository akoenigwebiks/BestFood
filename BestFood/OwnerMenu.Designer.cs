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
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridView_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dishesByCategories).BeginInit();
            SuspendLayout();
            // 
            // categories
            // 
            categories.AutoSize = true;
            categories.Location = new Point(675, 9);
            categories.Name = "categories";
            categories.Size = new Size(113, 35);
            categories.TabIndex = 0;
            categories.Text = "קטגוריות";
            // 
            // datagridView_categories
            // 
            datagridView_categories.AutoGenerateColumns = false;
            datagridView_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView_categories.Columns.AddRange(new DataGridViewColumn[] { getFoodsForCategory, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            datagridView_categories.DataSource = categoryDTOBindingSource2;
            datagridView_categories.Location = new Point(360, 58);
            datagridView_categories.Name = "datagridView_categories";
            datagridView_categories.RowHeadersWidth = 51;
            datagridView_categories.Size = new Size(428, 188);
            datagridView_categories.TabIndex = 1;
            datagridView_categories.CellClick += DataGridView1_CellClick;
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
            label1.Location = new Point(688, 268);
            label1.Name = "label1";
            label1.Size = new Size(100, 35);
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
            dataGridView_dishesByCategories.Location = new Point(334, 320);
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
            // OwnerMenu
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(dataGridView_dishesByCategories);
            Controls.Add(label1);
            Controls.Add(datagridView_categories);
            Controls.Add(categories);
            Font = new Font("Segoe UI", 15F);
            Name = "OwnerMenu";
            Text = "OwnerMenu";
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridView_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dishesByCategories).EndInit();
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
    }
}
