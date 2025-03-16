namespace ASMS.Forms.Forms
{
    partial class UpdateOrderForm
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
            label8 = new Label();
            comboBoxServices = new ComboBox();
            comboBoxClients = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            comboBoxCars = new ComboBox();
            CancelButton = new Button();
            UpdateOrderButton = new Button();
            label2 = new Label();
            DescriptionBox = new TextBox();
            label1 = new Label();
            comboBoxOrderStatus = new ComboBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 248);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 54;
            label8.Text = "Услуга";
            // 
            // comboBoxServices
            // 
            comboBoxServices.FormattingEnabled = true;
            comboBoxServices.Location = new Point(272, 245);
            comboBoxServices.Name = "comboBoxServices";
            comboBoxServices.Size = new Size(207, 28);
            comboBoxServices.TabIndex = 53;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(272, 135);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(207, 28);
            comboBoxClients.TabIndex = 52;
            comboBoxClients.SelectedIndexChanged += comboBoxClients_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 138);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 51;
            label7.Text = "Клиент";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 196);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 50;
            label6.Text = "Авто";
            // 
            // comboBoxCars
            // 
            comboBoxCars.FormattingEnabled = true;
            comboBoxCars.Location = new Point(272, 193);
            comboBoxCars.Name = "comboBoxCars";
            comboBoxCars.Size = new Size(207, 28);
            comboBoxCars.TabIndex = 49;
            comboBoxCars.SelectedIndexChanged += comboBoxCars_SelectedIndexChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(620, 221);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 48;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // UpdateOrderButton
            // 
            UpdateOrderButton.Location = new Point(620, 138);
            UpdateOrderButton.Name = "UpdateOrderButton";
            UpdateOrderButton.Size = new Size(94, 29);
            UpdateOrderButton.TabIndex = 47;
            UpdateOrderButton.Text = "Изменить";
            UpdateOrderButton.UseVisualStyleBackColor = true;
            UpdateOrderButton.Click += UpdateOrderButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 397);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 46;
            label2.Text = "Описание";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(272, 363);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(207, 97);
            DescriptionBox.TabIndex = 45;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 306);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 56;
            label1.Text = "Статус";
            // 
            // comboBoxOrderStatus
            // 
            comboBoxOrderStatus.FormattingEnabled = true;
            comboBoxOrderStatus.Location = new Point(272, 303);
            comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            comboBoxOrderStatus.Size = new Size(207, 28);
            comboBoxOrderStatus.TabIndex = 55;
            comboBoxOrderStatus.SelectedIndexChanged += comboBoxOrderStatus_SelectedIndexChanged;
            // 
            // UpdateOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 531);
            Controls.Add(label1);
            Controls.Add(comboBoxOrderStatus);
            Controls.Add(label8);
            Controls.Add(comboBoxServices);
            Controls.Add(comboBoxClients);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxCars);
            Controls.Add(CancelButton);
            Controls.Add(UpdateOrderButton);
            Controls.Add(label2);
            Controls.Add(DescriptionBox);
            Name = "UpdateOrderForm";
            Text = "UpdateOrderForm";
            Load += UpdateOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox comboBoxServices;
        private ComboBox comboBoxClients;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxCars;
        private Button CancelButton;
        private Button UpdateOrderButton;
        private Label label2;
        private TextBox DescriptionBox;
        private Label label1;
        private ComboBox comboBoxOrderStatus;
    }
}