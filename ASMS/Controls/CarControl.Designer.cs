namespace ASMS.Forms.Controls
{
    partial class CarControl
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
            buttonDeleteCar = new Button();
            buttonUpdateCar = new Button();
            buttonAddCar = new Button();
            buttonGetCars = new Button();
            dataGridViewCars = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteCar
            // 
            buttonDeleteCar.BackColor = Color.Brown;
            buttonDeleteCar.Location = new Point(379, 426);
            buttonDeleteCar.Name = "buttonDeleteCar";
            buttonDeleteCar.Size = new Size(118, 44);
            buttonDeleteCar.TabIndex = 9;
            buttonDeleteCar.Text = "Удалить";
            buttonDeleteCar.UseVisualStyleBackColor = false;
            buttonDeleteCar.Click += buttonDeleteCar_Click;
            // 
            // buttonUpdateCar
            // 
            buttonUpdateCar.BackColor = SystemColors.Highlight;
            buttonUpdateCar.Location = new Point(264, 426);
            buttonUpdateCar.Name = "buttonUpdateCar";
            buttonUpdateCar.Size = new Size(118, 44);
            buttonUpdateCar.TabIndex = 8;
            buttonUpdateCar.Text = "Изменить";
            buttonUpdateCar.UseVisualStyleBackColor = false;
            buttonUpdateCar.Click += buttonUpdateCar_Click;
            // 
            // buttonAddCar
            // 
            buttonAddCar.BackColor = Color.ForestGreen;
            buttonAddCar.Location = new Point(149, 426);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(118, 44);
            buttonAddCar.TabIndex = 7;
            buttonAddCar.Text = "Добавить";
            buttonAddCar.UseVisualStyleBackColor = false;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonGetCars
            // 
            buttonGetCars.BackColor = SystemColors.ActiveBorder;
            buttonGetCars.Location = new Point(34, 426);
            buttonGetCars.Name = "buttonGetCars";
            buttonGetCars.Size = new Size(118, 44);
            buttonGetCars.TabIndex = 6;
            buttonGetCars.Text = "Обновить";
            buttonGetCars.UseVisualStyleBackColor = false;
            buttonGetCars.Click += buttonGetCars_Click;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(21, 78);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 51;
            dataGridViewCars.Size = new Size(1259, 342);
            dataGridViewCars.TabIndex = 5;
            dataGridViewCars.SelectionChanged += dataGridViewCars_SelectionChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(550, 22);
            label1.Name = "label1";
            label1.Size = new Size(192, 40);
            label1.TabIndex = 10;
            label1.Text = "Автомобили";
            // 
            // CarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(buttonDeleteCar);
            Controls.Add(buttonUpdateCar);
            Controls.Add(buttonAddCar);
            Controls.Add(buttonGetCars);
            Controls.Add(dataGridViewCars);
            Name = "CarControl";
            Size = new Size(1297, 677);
            Load += CarControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDeleteCar;
        private Button buttonUpdateCar;
        private Button buttonAddCar;
        private Button buttonGetCars;
        private DataGridView dataGridViewCars;
        private Label label1;
    }
}
