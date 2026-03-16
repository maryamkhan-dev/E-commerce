namespace my_project
{
    partial class eachbookinshop
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
            this.isbnlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isbntext = new System.Windows.Forms.Label();
            this.authortext = new System.Windows.Forms.Label();
            this.publishertext = new System.Windows.Forms.Label();
            this.datetext = new System.Windows.Forms.Label();
            this.pricetext = new System.Windows.Forms.Label();
            this.addtocartBtn = new System.Windows.Forms.Button();
            this.discountedprice = new System.Windows.Forms.Label();
            this.discountpricelabel = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // isbnlabel
            // 
            this.isbnlabel.AutoSize = true;
            this.isbnlabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.isbnlabel.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.isbnlabel.Location = new System.Drawing.Point(31, 77);
            this.isbnlabel.Name = "isbnlabel";
            this.isbnlabel.Size = new System.Drawing.Size(69, 26);
            this.isbnlabel.TabIndex = 1;
            this.isbnlabel.Text = "ISBN:";
            this.isbnlabel.UseWaitCursor = true;
            this.isbnlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(31, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Publisher:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(31, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Published Year:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label4.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(31, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price:";
            this.label4.UseWaitCursor = true;
            // 
            // isbntext
            // 
            this.isbntext.AutoEllipsis = true;
            this.isbntext.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.isbntext.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbntext.Location = new System.Drawing.Point(100, 76);
            this.isbntext.Name = "isbntext";
            this.isbntext.Size = new System.Drawing.Size(281, 27);
            this.isbntext.TabIndex = 6;
            this.isbntext.Text = "isbn";
            this.isbntext.UseWaitCursor = true;
            this.isbntext.Click += new System.EventHandler(this.isbntext_Click);
            // 
            // authortext
            // 
            this.authortext.AutoEllipsis = true;
            this.authortext.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.authortext.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authortext.Location = new System.Drawing.Point(111, 112);
            this.authortext.Name = "authortext";
            this.authortext.Size = new System.Drawing.Size(270, 27);
            this.authortext.TabIndex = 7;
            this.authortext.Text = "author";
            this.authortext.UseWaitCursor = true;
            // 
            // publishertext
            // 
            this.publishertext.AutoEllipsis = true;
            this.publishertext.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.publishertext.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishertext.Location = new System.Drawing.Point(137, 148);
            this.publishertext.Name = "publishertext";
            this.publishertext.Size = new System.Drawing.Size(244, 27);
            this.publishertext.TabIndex = 8;
            this.publishertext.Text = "publishname";
            this.publishertext.UseWaitCursor = true;
            this.publishertext.Click += new System.EventHandler(this.publishertext_Click);
            // 
            // datetext
            // 
            this.datetext.AutoEllipsis = true;
            this.datetext.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.datetext.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetext.Location = new System.Drawing.Point(192, 183);
            this.datetext.Name = "datetext";
            this.datetext.Size = new System.Drawing.Size(182, 27);
            this.datetext.TabIndex = 9;
            this.datetext.Text = "year";
            this.datetext.UseWaitCursor = true;
            this.datetext.Click += new System.EventHandler(this.datetext_Click);
            // 
            // pricetext
            // 
            this.pricetext.AutoEllipsis = true;
            this.pricetext.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pricetext.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetext.Location = new System.Drawing.Point(92, 221);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(282, 27);
            this.pricetext.TabIndex = 10;
            this.pricetext.Text = "price";
            this.pricetext.UseWaitCursor = true;
            // 
            // addtocartBtn
            // 
            this.addtocartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.addtocartBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.addtocartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.addtocartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(152)))));
            this.addtocartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtocartBtn.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocartBtn.ForeColor = System.Drawing.Color.White;
            this.addtocartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addtocartBtn.Location = new System.Drawing.Point(69, 291);
            this.addtocartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addtocartBtn.Name = "addtocartBtn";
            this.addtocartBtn.Size = new System.Drawing.Size(254, 51);
            this.addtocartBtn.TabIndex = 21;
            this.addtocartBtn.Text = "ADD TO CART";
            this.addtocartBtn.UseVisualStyleBackColor = false;
            this.addtocartBtn.UseWaitCursor = true;
            this.addtocartBtn.Click += new System.EventHandler(this.addtocartBtn_Click);
            // 
            // discountedprice
            // 
            this.discountedprice.AutoEllipsis = true;
            this.discountedprice.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.discountedprice.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountedprice.Location = new System.Drawing.Point(245, 255);
            this.discountedprice.Name = "discountedprice";
            this.discountedprice.Size = new System.Drawing.Size(96, 26);
            this.discountedprice.TabIndex = 23;
            this.discountedprice.Text = "discount";
            this.discountedprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discountedprice.UseWaitCursor = true;
            this.discountedprice.Click += new System.EventHandler(this.discountedprice_Click);
            // 
            // discountpricelabel
            // 
            this.discountpricelabel.AutoSize = true;
            this.discountpricelabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.discountpricelabel.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountpricelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.discountpricelabel.Location = new System.Drawing.Point(63, 256);
            this.discountpricelabel.Name = "discountpricelabel";
            this.discountpricelabel.Size = new System.Drawing.Size(190, 26);
            this.discountpricelabel.TabIndex = 22;
            this.discountpricelabel.Text = "Discounted Price: ";
            this.discountpricelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discountpricelabel.UseWaitCursor = true;
            this.discountpricelabel.Click += new System.EventHandler(this.discountpricelabel_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoEllipsis = true;
            this.titlelabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.titlelabel.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.titlelabel.Location = new System.Drawing.Point(19, 2);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(362, 64);
            this.titlelabel.TabIndex = 24;
            this.titlelabel.Text = "ISBN:";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlelabel.UseWaitCursor = true;
            this.titlelabel.Click += new System.EventHandler(this.titlelabel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(36, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 29);
            this.panel1.TabIndex = 25;
            this.panel1.UseWaitCursor = true;
            // 
            // eachbookinshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.discountedprice);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.discountpricelabel);
            this.Controls.Add(this.addtocartBtn);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.datetext);
            this.Controls.Add(this.publishertext);
            this.Controls.Add(this.authortext);
            this.Controls.Add(this.isbntext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isbnlabel);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "eachbookinshop";
            this.Size = new System.Drawing.Size(399, 355);
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.eachbookinshop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label isbnlabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label isbntext;
        public System.Windows.Forms.Label authortext;
        public System.Windows.Forms.Label publishertext;
        public System.Windows.Forms.Label datetext;
        public System.Windows.Forms.Label pricetext;
        private System.Windows.Forms.Button addtocartBtn;
        public System.Windows.Forms.Label discountedprice;
        public System.Windows.Forms.Label titlelabel;
        public System.Windows.Forms.Label discountpricelabel;
        private System.Windows.Forms.Panel panel1;
    }
}
