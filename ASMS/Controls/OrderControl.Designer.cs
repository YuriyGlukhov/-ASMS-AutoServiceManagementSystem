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
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Location = new Point(1073, 665);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(175, 46);
            buttonDeleteOrder.TabIndex = 9;
            buttonDeleteOrder.Text = "Удалить";
            buttonDeleteOrder.UseVisualStyleBackColor = true;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // buttonUpdateOrder
            // 
            buttonUpdateOrder.Location = new Point(550, 665);
            buttonUpdateOrder.Name = "buttonUpdateOrder";
            buttonUpdateOrder.Size = new Size(175, 46);
            buttonUpdateOrder.TabIndex = 8;
            buttonUpdateOrder.Text = "Изменить";
            buttonUpdateOrder.UseVisualStyleBackColor = true;
            buttonUpdateOrder.Click += buttonUpdateOrder_Click;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Location = new Point(92, 665);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(175, 46);
            buttonAddOrder.TabIndex = 7;
            buttonAddOrder.Text = "Добавить";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // buttonAddGetOrder
            // 
            buttonAddGetOrder.Location = new Point(550, 146);
            buttonAddGetOrder.Name = "buttonAddGetOrder";
            buttonAddGetOrder.Size = new Size(175, 60);
            buttonAddGetOrder.TabIndex = 6;
            buttonAddGetOrder.Text = "Обновить";
            buttonAddGetOrder.UseVisualStyleBackColor = true;
            buttonAddGetOrder.Click += buttonAddGetOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(92, 212);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(1156, 448);
            dataGridViewOrders.TabIndex = 5;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonUpdateOrder);
            Controls.Add(buttonAddOrder);
            Controls.Add(buttonAddGetOrder);
            Controls.Add(dataGridViewOrders);
            Name = "OrderControl";
            Size = new Size(1475, 780);
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
    }
}
