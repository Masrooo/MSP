namespace MSP.Gui.GuiHome
{
    partial class HomeUserControl
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
            panel1 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonAddlnput = new System.Windows.Forms.Button();
            buttonAddOutput = new System.Windows.Forms.Button();
            buttonAddUser = new System.Windows.Forms.Button();
            buttonAddProject = new System.Windows.Forms.Button();
            buttoAddSupplier = new System.Windows.Forms.Button();
            buttonAddCustomer = new System.Windows.Forms.Button();
            buttonAddCategory = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            labelCompanyName = new System.Windows.Forms.Label();
            labelWellcome = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 408);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1262, 192);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddlnput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttoAddSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Location = new System.Drawing.Point(74, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1118, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "إضافات";
            // 
            // buttonAddlnput
            // 
            buttonAddlnput.Image = Properties.Resources.icons8_logout_32px;
            buttonAddlnput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddlnput.Location = new System.Drawing.Point(36, 46);
            buttonAddlnput.Margin = new System.Windows.Forms.Padding(5);
            buttonAddlnput.Name = "buttonAddlnput";
            buttonAddlnput.Size = new System.Drawing.Size(138, 55);
            buttonAddlnput.TabIndex = 11;
            buttonAddlnput.Text = "قبض";
            buttonAddlnput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.Image = Properties.Resources.icons8_budget_32px;
            buttonAddOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new System.Drawing.Point(187, 46);
            buttonAddOutput.Margin = new System.Windows.Forms.Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new System.Drawing.Size(138, 55);
            buttonAddOutput.TabIndex = 10;
            buttonAddOutput.Text = "صرف";
            buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Image = Properties.Resources.icons8_male_user_32px;
            buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new System.Drawing.Point(338, 46);
            buttonAddUser.Margin = new System.Windows.Forms.Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new System.Drawing.Size(138, 55);
            buttonAddUser.TabIndex = 9;
            buttonAddUser.Text = "   مستخدم   ";
            buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Image = Properties.Resources.icons8_microsoft_project_32px;
            buttonAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new System.Drawing.Point(489, 46);
            buttonAddProject.Margin = new System.Windows.Forms.Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new System.Drawing.Size(138, 55);
            buttonAddProject.TabIndex = 8;
            buttonAddProject.Text = "مشروع";
            buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttoAddSupplier
            // 
            buttoAddSupplier.Image = Properties.Resources.icons8_budget_32px_1;
            buttoAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttoAddSupplier.Location = new System.Drawing.Point(640, 46);
            buttoAddSupplier.Margin = new System.Windows.Forms.Padding(5);
            buttoAddSupplier.Name = "buttoAddSupplier";
            buttoAddSupplier.Size = new System.Drawing.Size(138, 55);
            buttoAddSupplier.TabIndex = 7;
            buttoAddSupplier.Text = "مورد";
            buttoAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Image = Properties.Resources.icons8_user_32px_2;
            buttonAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new System.Drawing.Point(791, 46);
            buttonAddCustomer.Margin = new System.Windows.Forms.Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new System.Drawing.Size(138, 55);
            buttonAddCustomer.TabIndex = 6;
            buttonAddCustomer.Text = "عميل";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Image = Properties.Resources.icons8_Categorize_32px_1;
            buttonAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new System.Drawing.Point(942, 46);
            buttonAddCategory.Margin = new System.Windows.Forms.Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new System.Drawing.Size(138, 55);
            buttonAddCategory.TabIndex = 5;
            buttonAddCategory.Text = "صنف";
            buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(541, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(205, 56);
            label1.TabIndex = 1;
            label1.Text = "الوصول السريع";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.icons8_smart_96px_1;
            pictureBox1.Location = new System.Drawing.Point(478, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(72, 62);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new System.Drawing.Point(772, 18);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(461, 125);
            panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            pictureBoxLogo.Image = Properties.Resources.icons8_smart_96px_1;
            pictureBoxLogo.Location = new System.Drawing.Point(375, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(86, 125);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCompanyName.Location = new System.Drawing.Point(6, 6);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(363, 115);
            labelCompanyName.TabIndex = 5;
            labelCompanyName.Text = "MSP";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWellcome
            // 
            labelWellcome.Font = new System.Drawing.Font("Cairo", 13.7999992F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelWellcome.Location = new System.Drawing.Point(18, 24);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new System.Drawing.Size(363, 99);
            labelWellcome.TabIndex = 6;
            labelWellcome.Text = "مرحبا بك مجددا";
            labelWellcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(labelWellcome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "HomeUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1262, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddlnput;
        private System.Windows.Forms.Button buttonAddOutput;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttoAddSupplier;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelWellcome;
    }
}
