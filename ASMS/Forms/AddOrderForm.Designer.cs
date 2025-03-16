namespace ASMS.Forms.Forms
{
    partial class AddOrderForm
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
            CancelButton = new Button();
            AddOrderButton = new Button();
            label2 = new Label();
            DescriptionBox = new TextBox();
            comboBoxCars = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBoxClients = new ComboBox();
            comboBoxServices = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(251, 380);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 33;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddOrderButton
            // 
            AddOrderButton.Location = new Point(85, 380);
            AddOrderButton.Name = "AddOrderButton";
            AddOrderButton.Size = new Size(94, 29);
            AddOrderButton.TabIndex = 32;
            AddOrderButton.Text = "Добавить";
            AddOrderButton.UseVisualStyleBackColor = true;
            AddOrderButton.Click += AddOrderButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 250);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 29;
            label2.Text = "Описание";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(138, 216);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(207, 97);
            DescriptionBox.TabIndex = 27;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // comboBoxCars
            // 
            comboBoxCars.FormattingEnabled = true;
            comboBoxCars.Location = new Point(138, 110);
            comboBoxCars.Name = "comboBoxCars";
            comboBoxCars.Size = new Size(207, 28);
            comboBoxCars.TabIndex = 39;
            comboBoxCars.DropDown += comboBoxCars_DropDown;
            comboBoxCars.SelectedIndexChanged += comboBoxCars_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 113);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 40;
            label6.Text = "Авто";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 55);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 41;
            label7.Text = "Клиент";
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(138, 52);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(207, 28);
            comboBoxClients.TabIndex = 42;
            comboBoxClients.DropDown += comboBoxClients_DropDown;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged_1;
            // 
            // comboBoxServices
            // 
            comboBoxServices.FormattingEnabled = true;
            comboBoxServices.Location = new Point(138, 162);
            comboBoxServices.Name = "comboBoxServices";
            comboBoxServices.Size = new Size(207, 28);
            comboBoxServices.TabIndex = 43;
            comboBoxServices.DropDown += comboBoxServices_DropDown;
            comboBoxServices.SelectedIndexChanged += comboBoxServices_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 165);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 44;
            label8.Text = "Услуга";
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 551);
            Controls.Add(label8);
            Controls.Add(comboBoxServices);
            Controls.Add(comboBoxClients);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxCars);
            Controls.Add(CancelButton);
            Controls.Add(AddOrderButton);
            Controls.Add(label2);
            Controls.Add(DescriptionBox);
            Name = "AddOrderForm";
            Text = "AddOrderForm";
            Load += AddOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox YearBox;
        private Label label1;
        private TextBox VinBox;
        private TextBox ModelBox;
        private Button CancelButton;
        private Button AddOrderButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox RegNumberBox;
        private TextBox DescriptionBox;
        private ComboBox comboBox1;
        private ComboBox comboBoxCars;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxClients;
        private ComboBox comboBoxServices;
        private Label label8;
    }
}