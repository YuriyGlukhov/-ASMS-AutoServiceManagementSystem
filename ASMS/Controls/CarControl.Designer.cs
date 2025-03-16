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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteCar
            // 
            buttonDeleteCar.Location = new Point(1016, 498);
            buttonDeleteCar.Name = "buttonDeleteCar";
            buttonDeleteCar.Size = new Size(175, 60);
            buttonDeleteCar.TabIndex = 9;
            buttonDeleteCar.Text = "Удалить";
            buttonDeleteCar.UseVisualStyleBackColor = true;
            buttonDeleteCar.Click += buttonDeleteCar_Click;
            // 
            // buttonUpdateCar
            // 
            buttonUpdateCar.Location = new Point(1016, 400);
            buttonUpdateCar.Name = "buttonUpdateCar";
            buttonUpdateCar.Size = new Size(175, 60);
            buttonUpdateCar.TabIndex = 8;
            buttonUpdateCar.Text = "Изменить";
            buttonUpdateCar.UseVisualStyleBackColor = true;
            buttonUpdateCar.Click += buttonUpdateCar_Click;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(1016, 299);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(175, 60);
            buttonAddCar.TabIndex = 7;
            buttonAddCar.Text = "Добавить";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonGetCars
            // 
            buttonGetCars.Location = new Point(1016, 201);
            buttonGetCars.Name = "buttonGetCars";
            buttonGetCars.Size = new Size(175, 60);
            buttonGetCars.TabIndex = 6;
            buttonGetCars.Text = "Обновить";
            buttonGetCars.UseVisualStyleBackColor = true;
            buttonGetCars.Click += buttonGetCars_Click;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(105, 118);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 51;
            dataGridViewCars.Size = new Size(634, 440);
            dataGridViewCars.TabIndex = 5;
            dataGridViewCars.CellContentClick += dataGridViewCars_CellContentClick;
            // 
            // CarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
