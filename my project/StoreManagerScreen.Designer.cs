namespace my_project
{
    partial class StoreManagerScreen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.coupon = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.managediscountsBtn = new System.Windows.Forms.Button();
            this.manageorderBtn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.coupon);
            this.panel2.Controls.Add(this.profileBtn);
            this.panel2.Controls.Add(this.usernamelabel);
            this.panel2.Controls.Add(this.managediscountsBtn);
            this.panel2.Controls.Add(this.manageorderBtn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 881);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // coupon
            // 
            this.coupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coupon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.coupon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.coupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coupon.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coupon.ForeColor = System.Drawing.Color.White;
            this.coupon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.coupon.Location = new System.Drawing.Point(27, 361);
            this.coupon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coupon.Name = "coupon";
            this.coupon.Size = new System.Drawing.Size(300, 81);
            this.coupon.TabIndex = 9;
            this.coupon.Text = "MANAGE COUPONS";
            this.coupon.UseVisualStyleBackColor = true;
            this.coupon.Click += new System.EventHandler(this.managecoupons_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.profileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(27, 587);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(300, 81);
            this.profileBtn.TabIndex = 8;
            this.profileBtn.Text = "PROFILE";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Bell MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(50, 132);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(0, 31);
            this.usernamelabel.TabIndex = 4;
            // 
            // managediscountsBtn
            // 
            this.managediscountsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managediscountsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.managediscountsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.managediscountsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managediscountsBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managediscountsBtn.ForeColor = System.Drawing.Color.White;
            this.managediscountsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managediscountsBtn.Location = new System.Drawing.Point(27, 473);
            this.managediscountsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.managediscountsBtn.Name = "managediscountsBtn";
            this.managediscountsBtn.Size = new System.Drawing.Size(300, 81);
            this.managediscountsBtn.TabIndex = 3;
            this.managediscountsBtn.Text = "MANAGE DISCOUNTS";
            this.managediscountsBtn.UseVisualStyleBackColor = true;
            this.managediscountsBtn.Click += new System.EventHandler(this.manageprofilesBtn_Click);
            // 
            // manageorderBtn
            // 
            this.manageorderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageorderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.manageorderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.manageorderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageorderBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageorderBtn.ForeColor = System.Drawing.Color.White;
            this.manageorderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageorderBtn.Location = new System.Drawing.Point(27, 249);
            this.manageorderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageorderBtn.Name = "manageorderBtn";
            this.manageorderBtn.Size = new System.Drawing.Size(300, 81);
            this.manageorderBtn.TabIndex = 2;
            this.manageorderBtn.Text = "MANAGE ORDERS";
            this.manageorderBtn.UseVisualStyleBackColor = true;
            this.manageorderBtn.Click += new System.EventHandler(this.manageorderBtn_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(37, 85);
            this.greet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(167, 37);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Welcome, ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1728, 33);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label2.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paper Trails - Store Manager";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(344, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 881);
            this.panel3.TabIndex = 7;
            // 
            // StoreManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 914);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StoreManagerScreen";
            this.Text = "StoreManagerScreen";
            this.Load += new System.EventHandler(this.StoreManagerScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Button managediscountsBtn;
        private System.Windows.Forms.Button manageorderBtn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button coupon;
        private System.Windows.Forms.Panel panel3;
    }
}