namespace my_project
{
    partial class CustomerScreen
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
            this.manageordersbtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.cardBtn = new System.Windows.Forms.Button();
            this.shopBtn = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.manageordersbtn);
            this.panel2.Controls.Add(this.profileBtn);
            this.panel2.Controls.Add(this.usernamelabel);
            this.panel2.Controls.Add(this.cardBtn);
            this.panel2.Controls.Add(this.shopBtn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 881);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // manageordersbtn
            // 
            this.manageordersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageordersbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.manageordersbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.manageordersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageordersbtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageordersbtn.ForeColor = System.Drawing.Color.White;
            this.manageordersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageordersbtn.Location = new System.Drawing.Point(27, 504);
            this.manageordersbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageordersbtn.Name = "manageordersbtn";
            this.manageordersbtn.Size = new System.Drawing.Size(300, 81);
            this.manageordersbtn.TabIndex = 9;
            this.manageordersbtn.Text = "MANAGE ORDERS";
            this.manageordersbtn.UseVisualStyleBackColor = true;
            this.manageordersbtn.Click += new System.EventHandler(this.checkoutBtn_Click);
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
            this.profileBtn.Location = new System.Drawing.Point(27, 614);
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
            this.usernamelabel.Size = new System.Drawing.Size(79, 31);
            this.usernamelabel.TabIndex = 4;
            this.usernamelabel.Text = "bnmb";
            this.usernamelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardBtn
            // 
            this.cardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.cardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.cardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cardBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardBtn.ForeColor = System.Drawing.Color.White;
            this.cardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardBtn.Location = new System.Drawing.Point(27, 395);
            this.cardBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(300, 81);
            this.cardBtn.TabIndex = 3;
            this.cardBtn.Text = "MANAGE CART";
            this.cardBtn.UseVisualStyleBackColor = true;
            this.cardBtn.Click += new System.EventHandler(this.cardBtn_Click);
            // 
            // shopBtn
            // 
            this.shopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.shopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.shopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBtn.ForeColor = System.Drawing.Color.White;
            this.shopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopBtn.Location = new System.Drawing.Point(27, 285);
            this.shopBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(300, 81);
            this.shopBtn.TabIndex = 2;
            this.shopBtn.Text = "SHOP";
            this.shopBtn.UseVisualStyleBackColor = true;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
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
            this.panel1.TabIndex = 2;
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
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paper Trails - Customer";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(348, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 881);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 914);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "CustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerScreen";
            this.Load += new System.EventHandler(this.CustomerScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cardBtn;
        private System.Windows.Forms.Button shopBtn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button manageordersbtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Panel panel3;
    }
}