namespace MSP
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonHome = new System.Windows.Forms.Button();
            buttonCategory = new System.Windows.Forms.Button();
            buttonCustomers = new System.Windows.Forms.Button();
            buttonSuppliers = new System.Windows.Forms.Button();
            buttonProjects = new System.Windows.Forms.Button();
            buttonUsers = new System.Windows.Forms.Button();
            buttonSettings = new System.Windows.Forms.Button();
            buttonLogout = new System.Windows.Forms.Button();
            buttonHelp = new System.Windows.Forms.Button();
            buttonAbout = new System.Windows.Forms.Button();
            panelContainer = new System.Windows.Forms.Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonHome);
            flowLayoutPanel1.Controls.Add(buttonCategory);
            flowLayoutPanel1.Controls.Add(buttonCustomers);
            flowLayoutPanel1.Controls.Add(buttonSuppliers);
            flowLayoutPanel1.Controls.Add(buttonProjects);
            flowLayoutPanel1.Controls.Add(buttonUsers);
            flowLayoutPanel1.Controls.Add(buttonSettings);
            flowLayoutPanel1.Controls.Add(buttonLogout);
            flowLayoutPanel1.Controls.Add(buttonHelp);
            flowLayoutPanel1.Controls.Add(buttonAbout);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 600);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanel1.Size = new System.Drawing.Size(1262, 73);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.Image = Properties.Resources.icons8_home_32px_1;
            buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHome.Location = new System.Drawing.Point(1061, 10);
            buttonHome.Margin = new System.Windows.Forms.Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new System.Drawing.Size(165, 55);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "الرئيسة";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.Image = Properties.Resources.icons8_Categorize_32px_1;
            buttonCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCategory.Location = new System.Drawing.Point(886, 10);
            buttonCategory.Margin = new System.Windows.Forms.Padding(5);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new System.Drawing.Size(165, 55);
            buttonCategory.TabIndex = 1;
            buttonCategory.Text = "الاصناف";
            buttonCategory.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Image = Properties.Resources.icons8_user_32px;
            buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new System.Drawing.Point(711, 10);
            buttonCustomers.Margin = new System.Windows.Forms.Padding(5);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new System.Drawing.Size(165, 55);
            buttonCustomers.TabIndex = 2;
            buttonCustomers.Text = "العملاء";
            buttonCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Image = Properties.Resources.icons8_users_32px_1;
            buttonSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new System.Drawing.Point(536, 10);
            buttonSuppliers.Margin = new System.Windows.Forms.Padding(5);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new System.Drawing.Size(165, 55);
            buttonSuppliers.TabIndex = 3;
            buttonSuppliers.Text = "الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            // 
            // buttonProjects
            // 
            buttonProjects.Image = Properties.Resources.icons8_microsoft_project_32px;
            buttonProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonProjects.Location = new System.Drawing.Point(361, 10);
            buttonProjects.Margin = new System.Windows.Forms.Padding(5);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Size = new System.Drawing.Size(165, 55);
            buttonProjects.TabIndex = 4;
            buttonProjects.Text = "المشاريع";
            buttonProjects.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.Image = Properties.Resources.icons8_users_32px;
            buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonUsers.Location = new System.Drawing.Point(186, 10);
            buttonUsers.Margin = new System.Windows.Forms.Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new System.Drawing.Size(165, 55);
            buttonUsers.TabIndex = 5;
            buttonUsers.Text = "     المستخدمين";
            buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Image = Properties.Resources.icons8_settings_32px;
            buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSettings.Location = new System.Drawing.Point(11, 10);
            buttonSettings.Margin = new System.Windows.Forms.Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new System.Drawing.Size(165, 55);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "الاعدادات";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            buttonLogout.Image = Properties.Resources.icons8_logout_32px_2;
            buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLogout.Location = new System.Drawing.Point(1061, 75);
            buttonLogout.Margin = new System.Windows.Forms.Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new System.Drawing.Size(165, 55);
            buttonLogout.TabIndex = 7;
            buttonLogout.Text = "خروج";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.icons8_help_32px_2;
            buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHelp.Location = new System.Drawing.Point(886, 75);
            buttonHelp.Margin = new System.Windows.Forms.Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new System.Drawing.Size(165, 55);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "المساعده";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.icons8_info_32px;
            buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAbout.Location = new System.Drawing.Point(711, 75);
            buttonAbout.Margin = new System.Windows.Forms.Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new System.Drawing.Size(165, 55);
            buttonAbout.TabIndex = 9;
            buttonAbout.Text = "حول";
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = System.Drawing.Color.White;
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(1262, 600);
            panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1262, 673);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel1);
            Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MSP";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAbout;
        public System.Windows.Forms.Panel panelContainer;
    }
}
