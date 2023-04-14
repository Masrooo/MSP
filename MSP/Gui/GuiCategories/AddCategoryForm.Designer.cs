namespace MSP.Gui.GuiCategories
{
    partial class AddCategoryForm
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
            panel1 = new System.Windows.Forms.Panel();
            buttonSave = new System.Windows.Forms.Button();
            buttonSaveAndClose = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            comboBoxNAWE = new System.Windows.Forms.ComboBox();
            comboBoxFuel = new System.Windows.Forms.ComboBox();
            textBoxShape = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBoxLiter = new System.Windows.Forms.TextBox();
            textBoxPassen = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBoxBalance = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 591);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(642, 67);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.icons8_save_32px;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(5, 5);
            buttonSave.Margin = new System.Windows.Forms.Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(124, 55);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_close_35px;
            buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new System.Drawing.Point(464, 5);
            buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new System.Drawing.Size(171, 55);
            buttonSaveAndClose.TabIndex = 2;
            buttonSaveAndClose.Text = "        حفظ وغلاق   ";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(618, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "صـرف ", "قبـض" });
            comboBoxType.Location = new System.Drawing.Point(92, 115);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(364, 45);
            comboBoxType.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(488, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 37);
            label3.TabIndex = 0;
            label3.Text = "نوع الصنف";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(92, 44);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(364, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(480, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم الماركة";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(comboBoxNAWE);
            groupBox2.Controls.Add(comboBoxFuel);
            groupBox2.Controls.Add(textBoxShape);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxLiter);
            groupBox2.Controls.Add(textBoxPassen);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new System.Drawing.Point(12, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(618, 258);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات الماركة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(536, 194);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 37);
            label8.TabIndex = 5;
            label8.Text = "الوقود";
            // 
            // comboBoxNAWE
            // 
            comboBoxNAWE.FormattingEnabled = true;
            comboBoxNAWE.Items.AddRange(new object[] { "مـــــــلاكــــــي", "نقـــــــــــــــــــــل", "ميكــروبــــاص" });
            comboBoxNAWE.Location = new System.Drawing.Point(92, 44);
            comboBoxNAWE.Name = "comboBoxNAWE";
            comboBoxNAWE.Size = new System.Drawing.Size(364, 45);
            comboBoxNAWE.TabIndex = 4;
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Items.AddRange(new object[] { "بنــزيـــن", "ســــولار" });
            comboBoxFuel.Location = new System.Drawing.Point(322, 191);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new System.Drawing.Size(208, 45);
            comboBoxFuel.TabIndex = 3;
            // 
            // textBoxShape
            // 
            textBoxShape.Location = new System.Drawing.Point(322, 113);
            textBoxShape.Name = "textBoxShape";
            textBoxShape.Size = new System.Drawing.Size(208, 45);
            textBoxShape.TabIndex = 1;
            textBoxShape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(532, 118);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 37);
            label5.TabIndex = 0;
            label5.Text = "الشكل";
            // 
            // textBoxLiter
            // 
            textBoxLiter.Location = new System.Drawing.Point(15, 194);
            textBoxLiter.Name = "textBoxLiter";
            textBoxLiter.Size = new System.Drawing.Size(130, 45);
            textBoxLiter.TabIndex = 1;
            textBoxLiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPassen
            // 
            textBoxPassen.Location = new System.Drawing.Point(15, 118);
            textBoxPassen.Name = "textBoxPassen";
            textBoxPassen.Size = new System.Drawing.Size(130, 45);
            textBoxPassen.TabIndex = 1;
            textBoxPassen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(159, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 37);
            label4.TabIndex = 0;
            label4.Text = "السعه اللترية";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(175, 126);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(106, 37);
            label6.TabIndex = 0;
            label6.Text = "عدد الركاب";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(473, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 37);
            label2.TabIndex = 0;
            label2.Text = "النوع";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(677, 548);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 37);
            label7.TabIndex = 0;
            label7.Text = "الوقود";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new System.Drawing.Point(150, 527);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new System.Drawing.Size(364, 45);
            textBoxBalance.TabIndex = 4;
            textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(291, 487);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 37);
            label9.TabIndex = 3;
            label9.Text = "الرصيد";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(642, 658);
            Controls.Add(textBoxBalance);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل صنف";
            TopMost = true;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxNAWE;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.TextBox textBoxShape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLiter;
        private System.Windows.Forms.TextBox textBoxPassen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label9;
    }
}