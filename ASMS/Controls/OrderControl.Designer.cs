namespace ASMS.Forms.Controls
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDeleteOrder = new Button();
            buttonUpdateOrder = new Button();
            buttonAddOrder = new Button();
            buttonAddGetOrder = new Button();
            dataGridViewOrders = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.BackColor = Color.Brown;
            buttonDeleteOrder.Location = new Point(379, 426);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(118, 44);
            buttonDeleteOrder.TabIndex = 9;
            buttonDeleteOrder.Text = "Удалить";
            buttonDeleteOrder.UseVisualStyleBackColor = false;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // buttonUpdateOrder
            // 
            buttonUpdateOrder.BackColor = SystemColors.Highlight;
            buttonUpdateOrder.Location = new Point(264, 426);
            buttonUpdateOrder.Name = "buttonUpdateOrder";
            buttonUpdateOrder.Size = new Size(118, 44);
            buttonUpdateOrder.TabIndex = 8;
            buttonUpdateOrder.Text = "Изменить";
            buttonUpdateOrder.UseVisualStyleBackColor = false;
            buttonUpdateOrder.Click += buttonUpdateOrder_Click;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.BackColor = Color.ForestGreen;
            buttonAddOrder.Location = new Point(149, 426);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(118, 44);
            buttonAddOrder.TabIndex = 7;
            buttonAddOrder.Text = "Добавить";
            buttonAddOrder.UseVisualStyleBackColor = false;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // buttonAddGetOrder
            // 
            buttonAddGetOrder.BackColor = SystemColors.ActiveBorder;
            buttonAddGetOrder.Location = new Point(34, 426);
            buttonAddGetOrder.Name = "buttonAddGetOrder";
            buttonAddGetOrder.Size = new Size(118, 44);
            buttonAddGetOrder.TabIndex = 6;
            buttonAddGetOrder.Text = "Обновить";
            buttonAddGetOrder.UseVisualStyleBackColor = false;
            buttonAddGetOrder.Click += buttonAddGetOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(21, 78);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(1259, 342);
            dataGridViewOrders.TabIndex = 5;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(560, 22);
            label1.Name = "label1";
            label1.Size = new Size(119, 40);
            label1.TabIndex = 11;
            label1.Text = "Заказы";
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonUpdateOrder);
            Controls.Add(buttonAddOrder);
            Controls.Add(buttonAddGetOrder);
            Controls.Add(dataGridViewOrders);
            Name = "OrderControl";
            Size = new Size(1297, 677);
            Load += OrderControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDeleteOrder;
        private Button buttonUpdateOrder;
        private Button buttonAddOrder;
        private Button buttonAddGetOrder;
        private DataGridView dataGridViewOrders;
        private Label label1;
    }
}
