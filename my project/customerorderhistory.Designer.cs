namespace my_project
{
    partial class customerorderhistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.couponlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalpricelabel = new System.Windows.Forms.Label();
            this.deliveryfee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.orderdateinhistory = new System.Windows.Forms.Label();
            this.orderidlabelinhistory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.couponlabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.totalpricelabel);
            this.panel1.Controls.Add(this.deliveryfee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.orderdateinhistory);
            this.panel1.Controls.Add(this.orderidlabelinhistory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // couponlabel
            // 
            this.couponlabel.AutoSize = true;
            this.couponlabel.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.couponlabel.Location = new System.Drawing.Point(982, 40);
            this.couponlabel.Name = "couponlabel";
            this.couponlabel.Size = new System.Drawing.Size(71, 23);
            this.couponlabel.TabIndex = 13;
            this.couponlabel.Text = "orderid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(904, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Coupon:";
            // 
            // totalpricelabel
            // 
            this.totalpricelabel.AutoSize = true;
            this.totalpricelabel.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.totalpricelabel.Location = new System.Drawing.Point(1159, 41);
            this.totalpricelabel.Name = "totalpricelabel";
            this.totalpricelabel.Size = new System.Drawing.Size(78, 25);
            this.totalpricelabel.TabIndex = 11;
            this.totalpricelabel.Text = "orderid";
            // 
            // deliveryfee
            // 
            this.deliveryfee.AutoSize = true;
            this.deliveryfee.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryfee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.deliveryfee.Location = new System.Drawing.Point(1022, -1);
            this.deliveryfee.Name = "deliveryfee";
            this.deliveryfee.Size = new System.Drawing.Size(71, 23);
            this.deliveryfee.TabIndex = 10;
            this.deliveryfee.Text = "orderid";
            this.deliveryfee.Click += new System.EventHandler(this.deliveryfee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(1089, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(904, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delivery fee:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.status.Location = new System.Drawing.Point(592, 11);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(79, 29);
            this.status.TabIndex = 6;
            this.status.Text = "Status";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // orderdateinhistory
            // 
            this.orderdateinhistory.AutoSize = true;
            this.orderdateinhistory.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdateinhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.orderdateinhistory.Location = new System.Drawing.Point(12, 32);
            this.orderdateinhistory.Name = "orderdateinhistory";
            this.orderdateinhistory.Size = new System.Drawing.Size(116, 25);
            this.orderdateinhistory.TabIndex = 5;
            this.orderdateinhistory.Text = "dateofordee";
            this.orderdateinhistory.Click += new System.EventHandler(this.orderdateinhistory_Click);
            // 
            // orderidlabelinhistory
            // 
            this.orderidlabelinhistory.AutoSize = true;
            this.orderidlabelinhistory.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidlabelinhistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.orderidlabelinhistory.Location = new System.Drawing.Point(121, 5);
            this.orderidlabelinhistory.Name = "orderidlabelinhistory";
            this.orderidlabelinhistory.Size = new System.Drawing.Size(78, 25);
            this.orderidlabelinhistory.TabIndex = 4;
            this.orderidlabelinhistory.Text = "orderid";
            this.orderidlabelinhistory.Click += new System.EventHandler(this.orderidlabelinhistory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(19, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 78);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // customerorderhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "customerorderhistory";
            this.Size = new System.Drawing.Size(1254, 169);
            this.Load += new System.EventHandler(this.customerorderhistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderidlabelinhistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label orderdateinhistory;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label totalpricelabel;
        private System.Windows.Forms.Label deliveryfee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label couponlabel;
        private System.Windows.Forms.Label label2;
    }
}
