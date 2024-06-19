namespace BestFood
{
    partial class CustomerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label_categories = new Label();
            datagridView_categories = new DataGridView();
            categoryDTOBindingSource = new BindingSource(components);
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            getFoodsForCategory = new DataGridViewButtonColumn();
            label_dishes = new Label();
            dishDTOBindingSource = new BindingSource(components);
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            label_orderDetails = new Label();
            dataGridView2 = new DataGridView();
            orderDetailDTOBindingSource = new BindingSource(components);
            orderDetailIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dishIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagridView_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label_categories
            // 
            label_categories.AutoSize = true;
            label_categories.Location = new Point(699, 22);
            label_categories.Name = "label_categories";
            label_categories.Size = new Size(89, 28);
            label_categories.TabIndex = 0;
            label_categories.Text = "קטגוריות";
            // 
            // datagridView_categories
            // 
            datagridView_categories.AutoGenerateColumns = false;
            datagridView_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView_categories.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, getFoodsForCategory });
            datagridView_categories.DataSource = categoryDTOBindingSource;
            datagridView_categories.Location = new Point(334, 53);
            datagridView_categories.Name = "datagridView_categories";
            datagridView_categories.RowHeadersWidth = 51;
            datagridView_categories.Size = new Size(454, 188);
            datagridView_categories.TabIndex = 2;
            // 
            // categoryDTOBindingSource
            // 
            categoryDTOBindingSource.DataSource = typeof(CategoryDTO);
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "מזהה";
            categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "שם";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // getFoodsForCategory
            // 
            getFoodsForCategory.HeaderText = "צפייה";
            getFoodsForCategory.MinimumWidth = 6;
            getFoodsForCategory.Name = "getFoodsForCategory";
            getFoodsForCategory.Text = "צפה";
            getFoodsForCategory.UseColumnTextForButtonValue = true;
            getFoodsForCategory.Width = 150;
            // 
            // label_dishes
            // 
            label_dishes.AutoSize = true;
            label_dishes.Location = new Point(718, 272);
            label_dishes.Name = "label_dishes";
            label_dishes.Size = new Size(70, 28);
            label_dishes.TabIndex = 3;
            label_dishes.Text = "תפריט";
            // 
            // dishDTOBindingSource
            // 
            dishDTOBindingSource.DataSource = typeof(DishDTO);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "תיאור";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "מחיר";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "שם";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.MenuHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = dishDTOBindingSource;
            dataGridView1.Location = new Point(334, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(454, 188);
            dataGridView1.TabIndex = 4;
            // 
            // label_orderDetails
            // 
            label_orderDetails.AutoSize = true;
            label_orderDetails.Location = new Point(714, 532);
            label_orderDetails.Name = "label_orderDetails";
            label_orderDetails.Size = new Size(74, 28);
            label_orderDetails.TabIndex = 5;
            label_orderDetails.Text = "פריטים";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { orderDetailIdDataGridViewTextBoxColumn, orderIdDataGridViewTextBoxColumn, dishIdDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = orderDetailDTOBindingSource;
            dataGridView2.Location = new Point(110, 563);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(678, 188);
            dataGridView2.TabIndex = 6;
            // 
            // orderDetailDTOBindingSource
            // 
            orderDetailDTOBindingSource.DataSource = typeof(OrderDetailDTO);
            // 
            // orderDetailIdDataGridViewTextBoxColumn
            // 
            orderDetailIdDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailId";
            orderDetailIdDataGridViewTextBoxColumn.HeaderText = "OrderDetailId";
            orderDetailIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderDetailIdDataGridViewTextBoxColumn.Name = "orderDetailIdDataGridViewTextBoxColumn";
            orderDetailIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dishIdDataGridViewTextBoxColumn
            // 
            dishIdDataGridViewTextBoxColumn.DataPropertyName = "DishId";
            dishIdDataGridViewTextBoxColumn.HeaderText = "DishId";
            dishIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            dishIdDataGridViewTextBoxColumn.Name = "dishIdDataGridViewTextBoxColumn";
            dishIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 863);
            Controls.Add(dataGridView2);
            Controls.Add(label_orderDetails);
            Controls.Add(dataGridView1);
            Controls.Add(label_dishes);
            Controls.Add(datagridView_categories);
            Controls.Add(label_categories);
            Font = new Font("Segoe UI", 12F);
            Name = "CustomerMenu";
            RightToLeft = RightToLeft.Yes;
            Text = "CustomerMenu";
            ((System.ComponentModel.ISupportInitialize)datagridView_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_categories;
        private DataGridView datagridView_categories;
        private BindingSource categoryDTOBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn getFoodsForCategory;
        private Label label_dishes;
        private BindingSource dishDTOBindingSource;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridView dataGridView1;
        private Label label_orderDetails;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn orderDetailIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dishIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private BindingSource orderDetailDTOBindingSource;
    }
}