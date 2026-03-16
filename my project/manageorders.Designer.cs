namespace my_project
{
    partial class manageorders
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
            this.viewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.filterordersbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewreportBtn = new System.Windows.Forms.Button();
            this.viewbookreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.viewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewBtn.Location = new System.Drawing.Point(99, 813);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(278, 50);
            this.viewBtn.TabIndex = 11;
            this.viewBtn.Text = "VIEW ORDER ";
            this.viewBtn.UseCompatibleTextRendering = true;
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(625, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchBox.Location = new System.Drawing.Point(125, 117);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1215, 34);
            this.searchBox.TabIndex = 22;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1303, 568);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(397, 813);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(278, 50);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "UPDATE ORDER";
            this.updateBtn.UseCompatibleTextRendering = true;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // filterordersbox
            // 
            this.filterordersbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterordersbox.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterordersbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.filterordersbox.FormattingEnabled = true;
            this.filterordersbox.Items.AddRange(new object[] {
            "Discounted Orders",
            "Returned Orders",
            "All Orders"});
            this.filterordersbox.Location = new System.Drawing.Point(121, 171);
            this.filterordersbox.Name = "filterordersbox";
            this.filterordersbox.Size = new System.Drawing.Size(203, 33);
            this.filterordersbox.TabIndex = 34;
            this.filterordersbox.SelectedIndexChanged += new System.EventHandler(this.filterordersbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(38, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Show";
            // 
            // viewreportBtn
            // 
            this.viewreportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.viewreportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewreportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.viewreportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.viewreportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewreportBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewreportBtn.ForeColor = System.Drawing.Color.White;
            this.viewreportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewreportBtn.Location = new System.Drawing.Point(695, 813);
            this.viewreportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewreportBtn.Name = "viewreportBtn";
            this.viewreportBtn.Size = new System.Drawing.Size(278, 50);
            this.viewreportBtn.TabIndex = 35;
            this.viewreportBtn.Text = "GENERATE REPORT";
            this.viewreportBtn.UseCompatibleTextRendering = true;
            this.viewreportBtn.UseVisualStyleBackColor = false;
            this.viewreportBtn.Click += new System.EventHandler(this.viewreportBtn_Click);
            // 
            // viewbookreport
            // 
            this.viewbookreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.viewbookreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbookreport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.viewbookreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.viewbookreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbookreport.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbookreport.ForeColor = System.Drawing.Color.White;
            this.viewbookreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewbookreport.Location = new System.Drawing.Point(994, 813);
            this.viewbookreport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewbookreport.Name = "viewbookreport";
            this.viewbookreport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewbookreport.Size = new System.Drawing.Size(278, 50);
            this.viewbookreport.TabIndex = 36;
            this.viewbookreport.Text = "VIEW BOOK REPORT";
            this.viewbookreport.UseCompatibleTextRendering = true;
            this.viewbookreport.UseVisualStyleBackColor = false;
            this.viewbookreport.Click += new System.EventHandler(this.viewbookreport_Click);
            // 
            // manageorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewbookreport);
            this.Controls.Add(this.viewreportBtn);
            this.Controls.Add(this.filterordersbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label1);
            this.Name = "manageorders";
            this.Size = new System.Drawing.Size(1378, 877);
            this.Load += new System.EventHandler(this.manageorders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox filterordersbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewreportBtn;
        private System.Windows.Forms.Button viewbookreport;
    }
}
