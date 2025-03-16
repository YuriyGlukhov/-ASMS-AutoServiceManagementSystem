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
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteService
            // 
            buttonDeleteService.Location = new Point(1003, 486);
            buttonDeleteService.Name = "buttonDeleteService";
            buttonDeleteService.Size = new Size(175, 60);
            buttonDeleteService.TabIndex = 14;
            buttonDeleteService.Text = "Удалить";
            buttonDeleteService.UseVisualStyleBackColor = true;
            buttonDeleteService.Click += buttonDeleteService_Click;
            // 
            // buttonUpdateService
            // 
            buttonUpdateService.Location = new Point(1003, 388);
            buttonUpdateService.Name = "buttonUpdateService";
            buttonUpdateService.Size = new Size(175, 60);
            buttonUpdateService.TabIndex = 13;
            buttonUpdateService.Text = "Изменить";
            buttonUpdateService.UseVisualStyleBackColor = true;
            buttonUpdateService.Click += buttonUpdateService_Click;
            // 
            // buttonAddService
            // 
            buttonAddService.Location = new Point(1003, 287);
            buttonAddService.Name = "buttonAddService";
            buttonAddService.Size = new Size(175, 60);
            buttonAddService.TabIndex = 12;
            buttonAddService.Text = "Добавить";
            buttonAddService.UseVisualStyleBackColor = true;
            buttonAddService.Click += buttonAddService_Click;
            // 
            // buttonGetServices
            // 
            buttonGetServices.Location = new Point(1003, 189);
            buttonGetServices.Name = "buttonGetServices";
            buttonGetServices.Size = new Size(175, 60);
            buttonGetServices.TabIndex = 11;
            buttonGetServices.Text = "Обновить";
            buttonGetServices.UseVisualStyleBackColor = true;
            buttonGetServices.Click += buttonGetServices_Click;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Location = new Point(92, 106);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(883, 440);
            dataGridViewServices.TabIndex = 10;
            dataGridViewServices.CellContentClick += dataGridViewServices_CellContentClick;
            // 
            // ServiceControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDeleteService);
            Controls.Add(buttonUpdateService);
            Controls.Add(buttonAddService);
            Controls.Add(buttonGetServices);
            Controls.Add(dataGridViewServices);
            Name = "ServiceControl";
            Size = new Size(1271, 653);
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
    }
}
