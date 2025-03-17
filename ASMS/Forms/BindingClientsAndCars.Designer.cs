namespace ASMS.Forms.Forms
{
    partial class BindingClientsAndCars
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
            comboBoxClients = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            comboBoxCars = new ComboBox();
            CancelButton = new Button();
            BindButton = new Button();
            SuspendLayout();
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(268, 116);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(175, 28);
            comboBoxClients.TabIndex = 56;
            comboBoxClients.DropDown += comboBoxClients_DropDown;
            comboBoxClients.SelectionChangeCommitted += comboBoxClients_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 119);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 55;
            label7.Text = "Клиент";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 177);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 54;
            label6.Text = "Авто";
            // 
            // comboBoxCars
            // 
            comboBoxCars.FormattingEnabled = true;
            comboBoxCars.Location = new Point(268, 174);
            comboBoxCars.Name = "comboBoxCars";
            comboBoxCars.Size = new Size(175, 28);
            comboBoxCars.TabIndex = 53;
            comboBoxCars.DropDown += comboBoxCars_DropDown;
            comboBoxCars.SelectionChangeCommitted += comboBoxCars_SelectionChangeCommitted;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(356, 273);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 58;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // BindButton
            // 
            BindButton.Location = new Point(215, 273);
            BindButton.Name = "BindButton";
            BindButton.Size = new Size(94, 29);
            BindButton.TabIndex = 57;
            BindButton.Text = "Привязать";
            BindButton.UseVisualStyleBackColor = true;
            BindButton.Click += BindButton_Click;
            // 
            // BindingClientsAndCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 511);
            Controls.Add(CancelButton);
            Controls.Add(BindButton);
            Controls.Add(comboBoxClients);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxCars);
            Name = "BindingClientsAndCars";
            Text = "BindingClientsAndCars";
            Load += BindingClientsAndCars_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClients;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxCars;
        private Button CancelButton;
        private Button BindButton;
    }
}