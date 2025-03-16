namespace ASMS.Forms.Forms
{
    partial class AddCarForm
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
            AddCarButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            RegNumberBox = new TextBox();
            BrandBox = new TextBox();
            ModelBox = new TextBox();
            label1 = new Label();
            VinBox = new TextBox();
            label5 = new Label();
            YearBox = new TextBox();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(600, 252);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 21;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddCarButton
            // 
            AddCarButton.Location = new Point(600, 169);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(94, 29);
            AddCarButton.TabIndex = 19;
            AddCarButton.Text = "Добавить";
            AddCarButton.UseVisualStyleBackColor = true;
            AddCarButton.Click += AddCarButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 219);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 18;
            label4.Text = "Гос. номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 178);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 17;
            label3.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 127);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 16;
            label2.Text = "Марка";
            label2.Click += label2_Click;
            // 
            // RegNumberBox
            // 
            RegNumberBox.Location = new Point(250, 216);
            RegNumberBox.Name = "RegNumberBox";
            RegNumberBox.Size = new Size(134, 27);
            RegNumberBox.TabIndex = 15;
            RegNumberBox.TextChanged += RegNumberBox_TextChanged;
            // 
            // BrandBox
            // 
            BrandBox.Location = new Point(250, 124);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(134, 27);
            BrandBox.TabIndex = 14;
            BrandBox.TextChanged += BrandBox_TextChanged;
            // 
            // ModelBox
            // 
            ModelBox.Location = new Point(249, 171);
            ModelBox.Name = "ModelBox";
            ModelBox.Size = new Size(135, 27);
            ModelBox.TabIndex = 22;
            ModelBox.TextChanged += ModelBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 262);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 24;
            label1.Text = "Vin";
            label1.Click += label1_Click;
            // 
            // VinBox
            // 
            VinBox.Location = new Point(250, 262);
            VinBox.Name = "VinBox";
            VinBox.Size = new Size(134, 27);
            VinBox.TabIndex = 23;
            VinBox.TextChanged += VinBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 308);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 26;
            label5.Text = "Год выпуска";
            // 
            // YearBox
            // 
            YearBox.Location = new Point(250, 305);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(134, 27);
            YearBox.TabIndex = 25;
            YearBox.TextChanged += YearBox_TextChanged;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(YearBox);
            Controls.Add(label1);
            Controls.Add(VinBox);
            Controls.Add(ModelBox);
            Controls.Add(CancelButton);
            Controls.Add(AddCarButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RegNumberBox);
            Controls.Add(BrandBox);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button AddCarButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox RegNumberBox;
        private TextBox BrandBox;
        private TextBox ModelBox;
        private Label label1;
        private TextBox VinBox;
        private Label label5;
        private TextBox YearBox;
    }
}