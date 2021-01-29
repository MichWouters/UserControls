
namespace UserControls
{
    partial class MyUserControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.chkInStock = new System.Windows.Forms.CheckBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 217);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ProductName";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 254);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // chkInStock
            // 
            this.chkInStock.AutoSize = true;
            this.chkInStock.Location = new System.Drawing.Point(122, 254);
            this.chkInStock.Name = "chkInStock";
            this.chkInStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInStock.Size = new System.Drawing.Size(77, 17);
            this.chkInStock.TabIndex = 3;
            this.chkInStock.Text = "Is In Stock";
            this.chkInStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkInStock.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(6, 284);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(198, 20);
            this.txtComments.TabIndex = 4;
            this.txtComments.TextChanged += new System.EventHandler(this.txtComments_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserControls.Properties.Resources.Stock;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(6, 311);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(198, 23);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.chkInStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(224, 377);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox chkInStock;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnCart;
    }
}
