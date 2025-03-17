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
            label1 = new Label();
            BindingButton = new Button();
            unBindButton = new Button();
            ShowClientsCars = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(21, 78);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(1259, 342);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.SelectionChanged += dataGridViewClients_SelectionChanged;
            // 
            // buttonAddGetClient
            // 
            buttonAddGetClient.BackColor = SystemColors.ActiveBorder;
            buttonAddGetClient.Location = new Point(34, 426);
            buttonAddGetClient.Name = "buttonAddGetClient";
            buttonAddGetClient.Size = new Size(118, 44);
            buttonAddGetClient.TabIndex = 1;
            buttonAddGetClient.Text = "Обновить";
            buttonAddGetClient.UseVisualStyleBackColor = false;
            buttonAddGetClient.Click += buttonAddGetClient_Click;
            // 
            // buttonAddClient
            // 
            buttonAddClient.BackColor = Color.ForestGreen;
            buttonAddClient.Location = new Point(149, 426);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(118, 44);
            buttonAddClient.TabIndex = 2;
            buttonAddClient.Text = "Добавить";
            buttonAddClient.UseVisualStyleBackColor = false;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonUpdateClient
            // 
            buttonUpdateClient.BackColor = SystemColors.Highlight;
            buttonUpdateClient.Location = new Point(264, 426);
            buttonUpdateClient.Name = "buttonUpdateClient";
            buttonUpdateClient.Size = new Size(118, 44);
            buttonUpdateClient.TabIndex = 3;
            buttonUpdateClient.Text = "Изменить";
            buttonUpdateClient.UseVisualStyleBackColor = false;
            buttonUpdateClient.Click += buttonUpdateClient_Click;
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.BackColor = Color.Brown;
            buttonDeleteClient.Location = new Point(379, 426);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(118, 44);
            buttonDeleteClient.TabIndex = 4;
            buttonDeleteClient.Text = "Удалить";
            buttonDeleteClient.UseVisualStyleBackColor = false;
            buttonDeleteClient.Click += buttonDeleteClient_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(550, 22);
            label1.Name = "label1";
            label1.Size = new Size(137, 40);
            label1.TabIndex = 11;
            label1.Text = "Клиенты";
            // 
            // BindingButton
            // 
            BindingButton.AutoEllipsis = true;
            BindingButton.Location = new Point(875, 426);
            BindingButton.Name = "BindingButton";
            BindingButton.Size = new Size(118, 44);
            BindingButton.TabIndex = 14;
            BindingButton.Text = "BindCar";
            BindingButton.UseVisualStyleBackColor = true;
            BindingButton.Click += BindingButton_Click;
            // 
            // unBindButton
            // 
            unBindButton.Location = new Point(999, 426);
            unBindButton.Name = "unBindButton";
            unBindButton.Size = new Size(118, 44);
            unBindButton.TabIndex = 16;
            unBindButton.Text = "Unbind Car";
            unBindButton.UseVisualStyleBackColor = true;
            unBindButton.Click += unBindButton_Click;
            // 
            // ShowClientsCars
            // 
            ShowClientsCars.Location = new Point(1123, 426);
            ShowClientsCars.Name = "ShowClientsCars";
            ShowClientsCars.Size = new Size(118, 44);
            ShowClientsCars.TabIndex = 18;
            ShowClientsCars.Text = "Cars List";
            ShowClientsCars.UseVisualStyleBackColor = true;
            ShowClientsCars.Click += ShowClientsCars_Click;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ShowClientsCars);
            Controls.Add(unBindButton);
            Controls.Add(BindingButton);
            Controls.Add(label1);
            Controls.Add(buttonDeleteClient);
            Controls.Add(buttonUpdateClient);
            Controls.Add(buttonAddClient);
            Controls.Add(buttonAddGetClient);
            Controls.Add(dataGridViewClients);
            Name = "ClientControl";
            Size = new Size(1297, 677);
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
        private Label label1;
        private Button BindingButton;
        private Button unBindButton;
        private Button ShowClientsCars;
    }
}
