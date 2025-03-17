namespace ASMS.Forms.Controls
{
    partial class ServiceControl
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
            buttonDeleteService = new Button();
            buttonUpdateService = new Button();
            buttonAddService = new Button();
            buttonGetServices = new Button();
            dataGridViewServices = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteService
            // 
            buttonDeleteService.BackColor = Color.Brown;
            buttonDeleteService.Location = new Point(379, 426);
            buttonDeleteService.Name = "buttonDeleteService";
            buttonDeleteService.Size = new Size(118, 44);
            buttonDeleteService.TabIndex = 14;
            buttonDeleteService.Text = "Удалить";
            buttonDeleteService.UseVisualStyleBackColor = false;
            buttonDeleteService.Click += buttonDeleteService_Click;
            // 
            // buttonUpdateService
            // 
            buttonUpdateService.BackColor = SystemColors.Highlight;
            buttonUpdateService.Location = new Point(264, 426);
            buttonUpdateService.Name = "buttonUpdateService";
            buttonUpdateService.Size = new Size(118, 44);
            buttonUpdateService.TabIndex = 13;
            buttonUpdateService.Text = "Изменить";
            buttonUpdateService.UseVisualStyleBackColor = false;
            buttonUpdateService.Click += buttonUpdateService_Click;
            // 
            // buttonAddService
            // 
            buttonAddService.BackColor = Color.ForestGreen;
            buttonAddService.Location = new Point(149, 426);
            buttonAddService.Name = "buttonAddService";
            buttonAddService.Size = new Size(118, 44);
            buttonAddService.TabIndex = 12;
            buttonAddService.Text = "Добавить";
            buttonAddService.UseVisualStyleBackColor = false;
            buttonAddService.Click += buttonAddService_Click;
            // 
            // buttonGetServices
            // 
            buttonGetServices.BackColor = SystemColors.ActiveBorder;
            buttonGetServices.Location = new Point(34, 426);
            buttonGetServices.Name = "buttonGetServices";
            buttonGetServices.Size = new Size(118, 44);
            buttonGetServices.TabIndex = 11;
            buttonGetServices.Text = "Обновить";
            buttonGetServices.UseVisualStyleBackColor = false;
            buttonGetServices.Click += buttonGetServices_Click;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Location = new Point(21, 78);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(1259, 342);
            dataGridViewServices.TabIndex = 10;
            dataGridViewServices.SelectionChanged += dataGridViewServices_SelectionChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(550, 22);
            label1.Name = "label1";
            label1.Size = new Size(241, 40);
            label1.TabIndex = 15;
            label1.Text = "Услуги и товары";
            // 
            // ServiceControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(buttonDeleteService);
            Controls.Add(buttonUpdateService);
            Controls.Add(buttonAddService);
            Controls.Add(buttonGetServices);
            Controls.Add(dataGridViewServices);
            Name = "ServiceControl";
            Size = new Size(1297, 677);
            Load += ServiceControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDeleteService;
        private Button buttonUpdateService;
        private Button buttonAddService;
        private Button buttonGetServices;
        private DataGridView dataGridViewServices;
        private Label label1;
    }
}
