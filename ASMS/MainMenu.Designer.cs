namespace ASMS.Forms
{
    partial class MainMenu
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
            ControlMenu = new TabControl();
            ClientControl = new TabPage();
            CarControl = new TabPage();
            OrderControler = new TabPage();
            ServiceControl = new TabPage();
            ControlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ControlMenu
            // 
            ControlMenu.Controls.Add(ClientControl);
            ControlMenu.Controls.Add(CarControl);
            ControlMenu.Controls.Add(OrderControler);
            ControlMenu.Controls.Add(ServiceControl);
            ControlMenu.Location = new Point(20, 24);
            ControlMenu.Name = "ControlMenu";
            ControlMenu.SelectedIndex = 0;
            ControlMenu.Size = new Size(1556, 60);
            ControlMenu.TabIndex = 0;
            // 
            // ClientControl
            // 
            ClientControl.Location = new Point(4, 29);
            ClientControl.Name = "ClientControl";
            ClientControl.Padding = new Padding(3);
            ClientControl.Size = new Size(1548, 27);
            ClientControl.TabIndex = 0;
            ClientControl.Text = "Клиенты";
            ClientControl.UseVisualStyleBackColor = true;
            ClientControl.Click += ClientControl_Click;
            // 
            // CarControl
            // 
            CarControl.Location = new Point(4, 29);
            CarControl.Name = "CarControl";
            CarControl.Padding = new Padding(3);
            CarControl.Size = new Size(1548, 27);
            CarControl.TabIndex = 1;
            CarControl.Text = "Автомобили";
            CarControl.UseVisualStyleBackColor = true;
            CarControl.Click += CarControl_Click;
            // 
            // OrderControler
            // 
            OrderControler.Location = new Point(4, 29);
            OrderControler.Name = "OrderControler";
            OrderControler.Padding = new Padding(3);
            OrderControler.Size = new Size(1548, 27);
            OrderControler.TabIndex = 2;
            OrderControler.Text = "Заказы";
            OrderControler.UseVisualStyleBackColor = true;
            OrderControler.Click += OrderControl_Click;
            // 
            // ServiceControl
            // 
            ServiceControl.Location = new Point(4, 29);
            ServiceControl.Name = "ServiceControl";
            ServiceControl.Padding = new Padding(3);
            ServiceControl.Size = new Size(1548, 27);
            ServiceControl.TabIndex = 3;
            ServiceControl.Text = "Услуги";
            ServiceControl.UseVisualStyleBackColor = true;
            ServiceControl.Click += ServiceControl_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 799);
            Controls.Add(ControlMenu);
            Name = "MainMenu";
            Text = "MainMenu";
            ControlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ControlMenu;
        private TabPage ClientControl;
        private TabPage CarControl;
        private TabPage OrderControler;
        private TabPage ServiceControl;
    }
}