namespace ASMS.Forms.Forms
{
    partial class AddServiceForm
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
            label5 = new Label();
            DurationBox = new TextBox();
            label1 = new Label();
            BrandBox = new TextBox();
            DescriptionBox = new TextBox();
            CancelButton = new Button();
            AddServiceButton = new Button();
            label4 = new Label();
            label3 = new Label();
            ServiceName = new Label();
            PriceBox = new TextBox();
            NameBox = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.No;
            label5.Location = new Point(50, 279);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 38;
            label5.Text = "Длительность, в м.";
            label5.Click += label5_Click;
            // 
            // DurationBox
            // 
            DurationBox.Location = new Point(194, 272);
            DurationBox.Name = "DurationBox";
            DurationBox.Size = new Size(134, 27);
            DurationBox.TabIndex = 37;
            DurationBox.TextChanged += DurationBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 229);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 36;
            label1.Text = "Марка";
            // 
            // BrandBox
            // 
            BrandBox.Location = new Point(194, 229);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(134, 27);
            BrandBox.TabIndex = 35;
            BrandBox.TextChanged += BrandBox_TextChanged;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(194, 114);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(182, 53);
            DescriptionBox.TabIndex = 34;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(282, 340);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 33;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddServiceButton
            // 
            AddServiceButton.Location = new Point(94, 340);
            AddServiceButton.Name = "AddServiceButton";
            AddServiceButton.Size = new Size(94, 29);
            AddServiceButton.TabIndex = 32;
            AddServiceButton.Text = "Добавить";
            AddServiceButton.UseVisualStyleBackColor = true;
            AddServiceButton.Click += AddServiceButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 183);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 31;
            label4.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 129);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 30;
            label3.Text = "Описание";
            // 
            // ServiceName
            // 
            ServiceName.Location = new Point(80, 55);
            ServiceName.MaximumSize = new Size(200, 100);
            ServiceName.Name = "ServiceName";
            ServiceName.RightToLeft = RightToLeft.Yes;
            ServiceName.Size = new Size(108, 46);
            ServiceName.TabIndex = 29;
            ServiceName.Text = "Название услуги/товара";
            ServiceName.Click += ServiceName_Click;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(194, 183);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(134, 27);
            PriceBox.TabIndex = 28;
            PriceBox.TextChanged += PriceBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(194, 55);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(182, 46);
            NameBox.TabIndex = 27;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // AddServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 408);
            Controls.Add(label5);
            Controls.Add(DurationBox);
            Controls.Add(label1);
            Controls.Add(BrandBox);
            Controls.Add(DescriptionBox);
            Controls.Add(CancelButton);
            Controls.Add(AddServiceButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ServiceName);
            Controls.Add(PriceBox);
            Controls.Add(NameBox);
            Name = "AddServiceForm";
            Text = "Добавление услуги или товара";
            Load += AddServiceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox DurationBox;
        private Label label1;
        private TextBox BrandBox;
        private TextBox DescriptionBox;
        private Button CancelButton;
        private Button AddServiceButton;
        private Label label4;
        private Label label3;
        private Label ServiceName;
        private TextBox PriceBox;
        private TextBox NameBox;
    }
}