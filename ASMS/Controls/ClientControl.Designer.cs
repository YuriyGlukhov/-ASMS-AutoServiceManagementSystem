namespace ASMS.Forms.Controlls
{
    partial class ClientControl
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
            dataGridViewClients = new DataGridView();
            buttonAddGetClient = new Button();
            buttonAddClient = new Button();
            buttonUpdateClient = new Button();
            buttonDeleteClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(34, 102);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(634, 440);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.CellContentClick += dataGridViewClients_CellContentClick;
            // 
            // buttonAddGetClient
            // 
            buttonAddGetClient.Location = new Point(945, 185);
            buttonAddGetClient.Name = "buttonAddGetClient";
            buttonAddGetClient.Size = new Size(175, 60);
            buttonAddGetClient.TabIndex = 1;
            buttonAddGetClient.Text = "Обновить";
            buttonAddGetClient.UseVisualStyleBackColor = true;
            buttonAddGetClient.Click += buttonAddGetClient_Click;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(945, 283);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(175, 60);
            buttonAddClient.TabIndex = 2;
            buttonAddClient.Text = "Добавить";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonUpdateClient
            // 
            buttonUpdateClient.Location = new Point(945, 384);
            buttonUpdateClient.Name = "buttonUpdateClient";
            buttonUpdateClient.Size = new Size(175, 60);
            buttonUpdateClient.TabIndex = 3;
            buttonUpdateClient.Text = "Изменить";
            buttonUpdateClient.UseVisualStyleBackColor = true;
            buttonUpdateClient.Click += buttonUpdateClient_Click;
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.Location = new Point(945, 482);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(175, 60);
            buttonDeleteClient.TabIndex = 4;
            buttonDeleteClient.Text = "Удалить";
            buttonDeleteClient.UseVisualStyleBackColor = true;
            buttonDeleteClient.Click += buttonDeleteClient_Click;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDeleteClient);
            Controls.Add(buttonUpdateClient);
            Controls.Add(buttonAddClient);
            Controls.Add(buttonAddGetClient);
            Controls.Add(dataGridViewClients);
            Name = "ClientControl";
            Size = new Size(1249, 583);
            Load += ClientControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClients;
        private Button buttonAddGetClient;
        private Button buttonAddClient;
        private Button buttonUpdateClient;
        private Button buttonDeleteClient;
    }
}
