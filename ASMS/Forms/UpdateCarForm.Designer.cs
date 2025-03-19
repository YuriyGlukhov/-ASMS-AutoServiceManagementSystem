namespace ASMS.Forms.Forms
{
    partial class UpdateCarForm
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
            ModelBox = new TextBox();
            CancelButton = new Button();
            UpdateCarButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            RegNumberBox = new TextBox();
            BrandBox = new TextBox();
            label5 = new Label();
            YearBox = new TextBox();
            label1 = new Label();
            VinBox = new TextBox();
            SuspendLayout();
            // 
            // ModelBox
            // 
            ModelBox.Location = new Point(218, 118);
            ModelBox.Name = "ModelBox";
            ModelBox.Size = new Size(135, 27);
            ModelBox.TabIndex = 30;
            ModelBox.TextChanged += ModelBox_TextChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(259, 333);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 29;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // UpdateCarButton
            // 
            UpdateCarButton.Location = new Point(118, 333);
            UpdateCarButton.Name = "UpdateCarButton";
            UpdateCarButton.Size = new Size(94, 29);
            UpdateCarButton.TabIndex = 28;
            UpdateCarButton.Text = "Изменить";
            UpdateCarButton.UseVisualStyleBackColor = true;
            UpdateCarButton.Click += UpdateCarButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 166);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 27;
            label4.Text = "Гос. номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 125);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 26;
            label3.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 25;
            label2.Text = "Марка";
            // 
            // RegNumberBox
            // 
            RegNumberBox.Location = new Point(219, 163);
            RegNumberBox.Name = "RegNumberBox";
            RegNumberBox.Size = new Size(134, 27);
            RegNumberBox.TabIndex = 24;
            RegNumberBox.TextChanged += RegNumberBox_TextChanged;
            // 
            // BrandBox
            // 
            BrandBox.Location = new Point(219, 71);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(134, 27);
            BrandBox.TabIndex = 23;
            BrandBox.TextChanged += BrandBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 255);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 34;
            label5.Text = "Год выпуска";
            // 
            // YearBox
            // 
            YearBox.Location = new Point(218, 252);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(134, 27);
            YearBox.TabIndex = 33;
            YearBox.TextChanged += YearBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 209);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 32;
            label1.Text = "Vin";
            // 
            // VinBox
            // 
            VinBox.Location = new Point(218, 209);
            VinBox.Name = "VinBox";
            VinBox.Size = new Size(134, 27);
            VinBox.TabIndex = 31;
            VinBox.TextChanged += VinBox_TextChanged;
            // 
            // UpdateCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(label5);
            Controls.Add(YearBox);
            Controls.Add(label1);
            Controls.Add(VinBox);
            Controls.Add(ModelBox);
            Controls.Add(CancelButton);
            Controls.Add(UpdateCarButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RegNumberBox);
            Controls.Add(BrandBox);
            Name = "UpdateCarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateCarForm";
            Load += UpdateCarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ModelBox;
        private Button CancelButton;
        private Button UpdateCarButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox RegNumberBox;
        private TextBox BrandBox;
        private Label label5;
        private TextBox YearBox;
        private Label label1;
        private TextBox VinBox;
    }
}