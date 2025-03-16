namespace ASMS.Forms.Forms
{
    partial class UpdateClientFrom
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
            BithdayBox = new MaskedTextBox();
            CloseFormButton = new Button();
            UpdateClientButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            PhoneBox = new TextBox();
            NameBox = new TextBox();
            SuspendLayout();
            // 
            // BithdayBox
            // 
            BithdayBox.Location = new Point(334, 186);
            BithdayBox.Mask = "00/00/0000";
            BithdayBox.Name = "BithdayBox";
            BithdayBox.Size = new Size(125, 27);
            BithdayBox.TabIndex = 22;
            BithdayBox.ValidatingType = typeof(DateTime);
            BithdayBox.MaskInputRejected += BithdayBox_MaskInputRejected;
            BithdayBox.TextChanged += BithdayBox_TextChanged;
            // 
            // CloseFormButton
            // 
            CloseFormButton.Location = new Point(600, 205);
            CloseFormButton.Name = "CloseFormButton";
            CloseFormButton.Size = new Size(94, 29);
            CloseFormButton.TabIndex = 21;
            CloseFormButton.Text = "Отмена";
            CloseFormButton.UseVisualStyleBackColor = true;
            CloseFormButton.Click += CloseFormButton_Click;
            // 
            // UpdateClientButton
            // 
            UpdateClientButton.Location = new Point(600, 142);
            UpdateClientButton.Name = "UpdateClientButton";
            UpdateClientButton.Size = new Size(94, 29);
            UpdateClientButton.TabIndex = 20;
            UpdateClientButton.Text = "Изменить";
            UpdateClientButton.UseVisualStyleBackColor = true;
            UpdateClientButton.Click += UpdateClientButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 234);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 18;
            label4.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 189);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 17;
            label3.Text = "Дата рождения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 142);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 16;
            label2.Text = "Имя";
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(285, 231);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(174, 27);
            PhoneBox.TabIndex = 14;
            PhoneBox.TextChanged += PhoneBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(229, 139);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(230, 27);
            NameBox.TabIndex = 13;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // UpdateClientFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(BithdayBox);
            Controls.Add(CloseFormButton);
            Controls.Add(UpdateClientButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PhoneBox);
            Controls.Add(NameBox);
            Name = "UpdateClientFrom";
            Text = "UpdateClientFrom";
            Load += UpdateClientFrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox BithdayBox;
        private Button CloseFormButton;
        private Button UpdateClientButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox PhoneBox;
        private TextBox NameBox;
    }
}