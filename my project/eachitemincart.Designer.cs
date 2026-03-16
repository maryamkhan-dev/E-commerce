namespace my_project
{
    partial class eachitemincart
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
            this.isbnlabelincart = new System.Windows.Forms.Label();
            this.authorlabelincart = new System.Windows.Forms.Label();
            this.titlelabelincart = new System.Windows.Forms.Label();
            this.pricelabelincart = new System.Windows.Forms.Label();
            this.addoneBtn = new System.Windows.Forms.Button();
            this.removeoneBtn = new System.Windows.Forms.Button();
            this.quantityincart = new System.Windows.Forms.Label();
            this.isitemselected = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.isbnlabelincart);
            this.panel1.Controls.Add(this.authorlabelincart);
            this.panel1.Controls.Add(this.titlelabelincart);
            this.panel1.Location = new System.Drawing.Point(63, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 118);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // pricelabelincart
            // 
            this.pricelabelincart.AutoSize = true;
            this.pricelabelincart.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelabelincart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.pricelabelincart.Location = new System.Drawing.Point(668, 117);
            this.pricelabelincart.Name = "pricelabelincart";
            this.pricelabelincart.Size = new System.Drawing.Size(0, 27);
            this.pricelabelincart.TabIndex = 2;
            // 
            // addoneBtn
            // 
            this.addoneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.addoneBtn.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addoneBtn.ForeColor = System.Drawing.Color.White;
            this.addoneBtn.Location = new System.Drawing.Point(711, 46);
            this.addoneBtn.Name = "addoneBtn";
            this.addoneBtn.Size = new System.Drawing.Size(57, 49);
            this.addoneBtn.TabIndex = 0;
            this.addoneBtn.Text = "+";
            this.addoneBtn.UseVisualStyleBackColor = false;
            this.addoneBtn.Click += new System.EventHandler(this.addoneBtn_Click);
            // 
            // removeoneBtn
            // 
            this.removeoneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.removeoneBtn.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeoneBtn.ForeColor = System.Drawing.Color.White;
            this.removeoneBtn.Location = new System.Drawing.Point(601, 46);
            this.removeoneBtn.Name = "removeoneBtn";
            this.removeoneBtn.Size = new System.Drawing.Size(55, 49);
            this.removeoneBtn.TabIndex = 2;
            this.removeoneBtn.Text = "-";
            this.removeoneBtn.UseVisualStyleBackColor = false;
            this.removeoneBtn.Click += new System.EventHandler(this.removeoneBtn_Click);
            // 
            // quantityincart
            // 
            this.quantityincart.AutoSize = true;
            this.quantityincart.Location = new System.Drawing.Point(656, 60);
            this.quantityincart.Name = "quantityincart";
            this.quantityincart.Size = new System.Drawing.Size(0, 20);
            this.quantityincart.TabIndex = 4;
            this.quantityincart.Click += new System.EventHandler(this.quantityincart_Click);
            // 
            // isitemselected
            // 
            this.isitemselected.AutoSize = true;
            this.isitemselected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isitemselected.Location = new System.Drawing.Point(10, 71);
            this.isitemselected.Name = "isitemselected";
            this.isitemselected.Size = new System.Drawing.Size(22, 21);
            this.isitemselected.TabIndex = 6;
            this.isitemselected.UseVisualStyleBackColor = true;
            this.isitemselected.CheckedChanged += new System.EventHandler(this.isitemselected_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(597, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price:";
            // 
            // eachitemincart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pricelabelincart);
            this.Controls.Add(this.isitemselected);
            this.Controls.Add(this.quantityincart);
            this.Controls.Add(this.removeoneBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addoneBtn);
            this.Name = "eachitemincart";
            this.Size = new System.Drawing.Size(776, 157);
            this.Load += new System.EventHandler(this.eachitemincart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titlelabelincart;
        private System.Windows.Forms.Label pricelabelincart;
        private System.Windows.Forms.Label authorlabelincart;
        private System.Windows.Forms.Button addoneBtn;
        private System.Windows.Forms.Button removeoneBtn;
        private System.Windows.Forms.Label quantityincart;
        private System.Windows.Forms.CheckBox isitemselected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label isbnlabelincart;
    }
}
