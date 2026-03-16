namespace my_project
{
    partial class itemincheckout
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
            this.label2 = new System.Windows.Forms.Label();
            this.pricelabelincart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isbnincheckout = new System.Windows.Forms.Label();
            this.authorincheckout = new System.Windows.Forms.Label();
            this.titleincheckout = new System.Windows.Forms.Label();
            this.priceincheckout = new System.Windows.Forms.Label();
            this.quantityincheckout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isbnlabelincart = new System.Windows.Forms.Label();
            this.authorlabelincart = new System.Windows.Forms.Label();
            this.titlelabelincart = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(558, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Price:";
            // 
            // pricelabelincart
            // 
            this.pricelabelincart.AutoSize = true;
            this.pricelabelincart.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabelincart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.pricelabelincart.Location = new System.Drawing.Point(678, 39);
            this.pricelabelincart.Name = "pricelabelincart";
            this.pricelabelincart.Size = new System.Drawing.Size(0, 23);
            this.pricelabelincart.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.isbnincheckout);
            this.panel1.Controls.Add(this.authorincheckout);
            this.panel1.Controls.Add(this.titleincheckout);
            this.panel1.Controls.Add(this.priceincheckout);
            this.panel1.Controls.Add(this.quantityincheckout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.isbnlabelincart);
            this.panel1.Controls.Add(this.authorlabelincart);
            this.panel1.Controls.Add(this.titlelabelincart);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 94);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // isbnincheckout
            // 
            this.isbnincheckout.AutoSize = true;
            this.isbnincheckout.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnincheckout.Location = new System.Drawing.Point(11, 62);
            this.isbnincheckout.Name = "isbnincheckout";
            this.isbnincheckout.Size = new System.Drawing.Size(60, 23);
            this.isbnincheckout.TabIndex = 20;
            this.isbnincheckout.Text = "label3";
            // 
            // authorincheckout
            // 
            this.authorincheckout.AutoSize = true;
            this.authorincheckout.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorincheckout.Location = new System.Drawing.Point(10, 39);
            this.authorincheckout.Name = "authorincheckout";
            this.authorincheckout.Size = new System.Drawing.Size(60, 23);
            this.authorincheckout.TabIndex = 19;
            this.authorincheckout.Text = "label3";
            this.authorincheckout.Click += new System.EventHandler(this.authorincheckout_Click);
            // 
            // titleincheckout
            // 
            this.titleincheckout.AutoSize = true;
            this.titleincheckout.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleincheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.titleincheckout.Location = new System.Drawing.Point(9, 15);
            this.titleincheckout.Name = "titleincheckout";
            this.titleincheckout.Size = new System.Drawing.Size(53, 24);
            this.titleincheckout.TabIndex = 18;
            this.titleincheckout.Text = "Qty: ";
            this.titleincheckout.Click += new System.EventHandler(this.titleincheckout_Click);
            // 
            // priceincheckout
            // 
            this.priceincheckout.AutoSize = true;
            this.priceincheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceincheckout.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceincheckout.Location = new System.Drawing.Point(627, 25);
            this.priceincheckout.Name = "priceincheckout";
            this.priceincheckout.Size = new System.Drawing.Size(62, 25);
            this.priceincheckout.TabIndex = 17;
            this.priceincheckout.Text = "label3";
            this.priceincheckout.Click += new System.EventHandler(this.priceincheckout_Click);
            // 
            // quantityincheckout
            // 
            this.quantityincheckout.AutoSize = true;
            this.quantityincheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityincheckout.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityincheckout.Location = new System.Drawing.Point(472, 25);
            this.quantityincheckout.Name = "quantityincheckout";
            this.quantityincheckout.Size = new System.Drawing.Size(62, 25);
            this.quantityincheckout.TabIndex = 16;
            this.quantityincheckout.Text = "label3";
            this.quantityincheckout.Click += new System.EventHandler(this.quantityincheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(426, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Qty: ";
            // 
            // isbnlabelincart
            // 
            this.isbnlabelincart.AutoSize = true;
            this.isbnlabelincart.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnlabelincart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.isbnlabelincart.Location = new System.Drawing.Point(5, 84);
            this.isbnlabelincart.Name = "isbnlabelincart";
            this.isbnlabelincart.Size = new System.Drawing.Size(0, 23);
            this.isbnlabelincart.TabIndex = 2;
            // 
            // authorlabelincart
            // 
            this.authorlabelincart.AutoSize = true;
            this.authorlabelincart.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorlabelincart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.authorlabelincart.Location = new System.Drawing.Point(5, 49);
            this.authorlabelincart.Name = "authorlabelincart";
            this.authorlabelincart.Size = new System.Drawing.Size(0, 23);
            this.authorlabelincart.TabIndex = 1;
            // 
            // titlelabelincart
            // 
            this.titlelabelincart.AutoSize = true;
            this.titlelabelincart.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabelincart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.titlelabelincart.Location = new System.Drawing.Point(3, 11);
            this.titlelabelincart.Name = "titlelabelincart";
            this.titlelabelincart.Size = new System.Drawing.Size(0, 29);
            this.titlelabelincart.TabIndex = 0;
            // 
            // itemincheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.pricelabelincart);
            this.Controls.Add(this.panel1);
            this.Name = "itemincheckout";
            this.Size = new System.Drawing.Size(739, 115);
            this.Load += new System.EventHandler(this.itemincheckout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pricelabelincart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label isbnlabelincart;
        private System.Windows.Forms.Label authorlabelincart;
        private System.Windows.Forms.Label titlelabelincart;
        private System.Windows.Forms.Label priceincheckout;
        private System.Windows.Forms.Label quantityincheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label authorincheckout;
        private System.Windows.Forms.Label titleincheckout;
        private System.Windows.Forms.Label isbnincheckout;
    }
}
