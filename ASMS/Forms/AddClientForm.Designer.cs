namespace ASMS.Forms.Forms
{
    partial class AddClientForm
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
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddClientButton = new Button();
            maskedTextBox1 = new MaskedTextBox();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(218, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 129);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "Имя";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 176);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 7;
            label3.Text = "Дата рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 221);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "Телефон";
            // 
            // AddClientButton
            // 
            AddClientButton.Location = new Point(118, 333);
            AddClientButton.Name = "AddClientButton";
            AddClientButton.Size = new Size(94, 29);
            AddClientButton.TabIndex = 10;
            AddClientButton.Text = "Добавить";
            AddClientButton.UseVisualStyleBackColor = true;
            AddClientButton.Click += AddClientButton_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(218, 173);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(84, 27);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(259, 333);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(CancelButton);
            Controls.Add(maskedTextBox1);
            Controls.Add(AddClientButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Name = "AddClientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddClientForm";
            Load += AddClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddClientButton;
        private MaskedTextBox maskedTextBox1;
        private Button CancelButton;
    }
}