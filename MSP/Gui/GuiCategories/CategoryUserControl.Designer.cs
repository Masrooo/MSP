namespace MSP.Gui.GuiCategories
{
    partial class CategoryUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonAdd = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonExport = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            textBoxSearch = new System.Windows.Forms.TextBox();
            buttonSearch = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonExport);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 524);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanel1.Size = new System.Drawing.Size(1262, 76);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Properties.Resources.icons8_add_32px;
            buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAdd.Location = new System.Drawing.Point(1112, 10);
            buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(135, 55);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "اضافة";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Properties.Resources.icons8_edit_32px_2;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.Location = new System.Drawing.Point(967, 10);
            buttonEdit.Margin = new System.Windows.Forms.Padding(5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new System.Drawing.Size(135, 55);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "تعديل";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.icons8_delete_32px_2;
            buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDelete.Location = new System.Drawing.Point(822, 10);
            buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(135, 55);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "حذف";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExport
            // 
            buttonExport.Image = Properties.Resources.icons8_export_csv_32px;
            buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonExport.Location = new System.Drawing.Point(677, 10);
            buttonExport.Margin = new System.Windows.Forms.Padding(5);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new System.Drawing.Size(135, 55);
            buttonExport.TabIndex = 4;
            buttonExport.Text = "تصدير";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(20, 8);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(649, 57);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(buttonSearch);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(489, 57);
            panel2.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new System.Drawing.Font("Cairo", 13.7999992F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxSearch.Location = new System.Drawing.Point(81, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(405, 51);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            buttonSearch.Image = Properties.Resources.icons8_search_32px;
            buttonSearch.Location = new System.Drawing.Point(0, 0);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(81, 55);
            buttonSearch.TabIndex = 4;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1262, 524);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // CategoryUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "CategoryUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1262, 600);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
