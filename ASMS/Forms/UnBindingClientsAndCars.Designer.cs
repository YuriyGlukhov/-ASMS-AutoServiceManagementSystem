namespace ASMS.Forms.Forms
{
    partial class UnBindingClientsAndCars
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
            BindButton = new Button();
            comboBoxClients = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            comboBoxCars = new ComboBox();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(396, 275);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 64;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // BindButton
            // 
            BindButton.Location = new Point(255, 275);
            BindButton.Name = "BindButton";
            BindButton.Size = new Size(94, 29);
            BindButton.TabIndex = 63;
            BindButton.Text = "Привязать";
            BindButton.UseVisualStyleBackColor = true;
            BindButton.Click += BindButton_Click;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(308, 118);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(175, 28);
            comboBoxClients.TabIndex = 62;
            comboBoxClients.DropDown += comboBoxClients_DropDown;
            comboBoxClients.SelectionChangeCommitted += comboBoxClients_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 121);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 61;
            label7.Text = "Клиент";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 179);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 60;
            label6.Text = "Авто";
            // 
            // comboBoxCars
            // 
            comboBoxCars.FormattingEnabled = true;
            comboBoxCars.Location = new Point(308, 176);
            comboBoxCars.Name = "comboBoxCars";
            comboBoxCars.Size = new Size(175, 28);
            comboBoxCars.TabIndex = 59;
            comboBoxCars.DropDown += comboBoxCars_DropDown;
            comboBoxCars.SelectedIndexChanged += comboBoxCars_SelectedIndexChanged_1;
            comboBoxCars.SelectionChangeCommitted += comboBoxCars_SelectionChangeCommitted;
            // 
            // UnBindingClientsAndCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelButton);
            Controls.Add(BindButton);
            Controls.Add(comboBoxClients);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxCars);
            Name = "UnBindingClientsAndCars";
            Text = "UnBindingClientsAndCars";
            Load += UnBindingClientsAndCars_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button BindButton;
        private ComboBox comboBoxClients;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxCars;
    }
}