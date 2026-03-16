namespace my_project
{
    partial class managecart
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.clearcart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coupondiscount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.couponapplied = new System.Windows.Forms.Label();
            this.deliveryfee = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.subtotalitems = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.totalpricelabeltext = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.coupontextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 651);
            this.flowLayoutPanel1.TabIndex = 26;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(367, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "My Cart";
            // 
            // clearcart
            // 
            this.clearcart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.clearcart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearcart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.clearcart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.clearcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearcart.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearcart.ForeColor = System.Drawing.Color.White;
            this.clearcart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearcart.Location = new System.Drawing.Point(169, 804);
            this.clearcart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearcart.Name = "clearcart";
            this.clearcart.Size = new System.Drawing.Size(254, 51);
            this.clearcart.TabIndex = 25;
            this.clearcart.Text = "CLEAR CART";
            this.clearcart.UseVisualStyleBackColor = false;
            this.clearcart.Click += new System.EventHandler(this.addtocartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Summary";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.coupondiscount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.couponapplied);
            this.panel1.Controls.Add(this.deliveryfee);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.subtotalitems);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Controls.Add(this.totalpricelabeltext);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.coupontextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(908, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 409);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // coupondiscount
            // 
            this.coupondiscount.AutoSize = true;
            this.coupondiscount.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coupondiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.coupondiscount.Location = new System.Drawing.Point(135, 277);
            this.coupondiscount.Name = "coupondiscount";
            this.coupondiscount.Size = new System.Drawing.Size(0, 27);
            this.coupondiscount.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 37;
            this.label5.Text = "Discount:";
            // 
            // couponapplied
            // 
            this.couponapplied.AutoSize = true;
            this.couponapplied.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponapplied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.couponapplied.Location = new System.Drawing.Point(25, 234);
            this.couponapplied.Name = "couponapplied";
            this.couponapplied.Size = new System.Drawing.Size(157, 25);
            this.couponapplied.TabIndex = 36;
            this.couponapplied.Text = "Coupon Applied";
            this.couponapplied.Visible = false;
            // 
            // deliveryfee
            // 
            this.deliveryfee.AutoSize = true;
            this.deliveryfee.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryfee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.deliveryfee.Location = new System.Drawing.Point(170, 136);
            this.deliveryfee.Name = "deliveryfee";
            this.deliveryfee.Size = new System.Drawing.Size(0, 27);
            this.deliveryfee.TabIndex = 35;
            this.deliveryfee.Click += new System.EventHandler(this.deliveryfee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Delivery Fee: ";
            // 
            // subtotalitems
            // 
            this.subtotalitems.AutoSize = true;
            this.subtotalitems.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalitems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.subtotalitems.Location = new System.Drawing.Point(149, 91);
            this.subtotalitems.Name = "subtotalitems";
            this.subtotalitems.Size = new System.Drawing.Size(0, 27);
            this.subtotalitems.TabIndex = 33;
            this.subtotalitems.Click += new System.EventHandler(this.subtotalitems_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total Items: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.checkoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutBtn.Location = new System.Drawing.Point(30, 347);
            this.checkoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(372, 51);
            this.checkoutBtn.TabIndex = 30;
            this.checkoutBtn.Text = "CHECKOUT";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // totalpricelabeltext
            // 
            this.totalpricelabeltext.AutoSize = true;
            this.totalpricelabeltext.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelabeltext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.totalpricelabeltext.Location = new System.Drawing.Point(137, 304);
            this.totalpricelabeltext.Name = "totalpricelabeltext";
            this.totalpricelabeltext.Size = new System.Drawing.Size(0, 38);
            this.totalpricelabeltext.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "TOTAL:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(279, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "APPLY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coupontextbox
            // 
            this.coupontextbox.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coupontextbox.Location = new System.Drawing.Point(27, 193);
            this.coupontextbox.Name = "coupontextbox";
            this.coupontextbox.Size = new System.Drawing.Size(232, 34);
            this.coupontextbox.TabIndex = 1;
            this.coupontextbox.TextChanged += new System.EventHandler(this.coupontextbox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.removebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.removebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removebtn.Location = new System.Drawing.Point(453, 804);
            this.removebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(254, 51);
            this.removebtn.TabIndex = 28;
            this.removebtn.Text = "REMOVE";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // managecart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.clearcart);
            this.Controls.Add(this.label1);
            this.Name = "managecart";
            this.Size = new System.Drawing.Size(1373, 881);
            this.Load += new System.EventHandler(this.managecart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearcart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label totalpricelabeltext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox coupontextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label subtotalitems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label deliveryfee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Label couponapplied;
        private System.Windows.Forms.Label coupondiscount;
        private System.Windows.Forms.Label label5;
    }
}
