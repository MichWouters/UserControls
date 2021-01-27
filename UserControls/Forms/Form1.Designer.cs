
namespace UserControls
{
    partial class Form1
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
            this.myUserControl3 = new UserControls.MyUserControl();
            this.myUserControl2 = new UserControls.MyUserControl();
            this.myUserControl1 = new UserControls.MyUserControl();
            this.myUserControl4 = new UserControls.MyUserControl();
            this.myUserControl5 = new UserControls.MyUserControl();
            this.btnDynamic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myUserControl3
            // 
            this.myUserControl3.Comments = "";
            this.myUserControl3.IsInStock = false;
            this.myUserControl3.Location = new System.Drawing.Point(557, 12);
            this.myUserControl3.MyProductName = "ProductName";
            this.myUserControl3.Name = "myUserControl3";
            this.myUserControl3.PizzaID = 3;
            this.myUserControl3.Price = "Price";
            this.myUserControl3.Size = new System.Drawing.Size(231, 335);
            this.myUserControl3.TabIndex = 2;
            // 
            // myUserControl2
            // 
            this.myUserControl2.Comments = "This is a comment";
            this.myUserControl2.IsInStock = true;
            this.myUserControl2.Location = new System.Drawing.Point(283, 12);
            this.myUserControl2.MyProductName = "My Product";
            this.myUserControl2.Name = "myUserControl2";
            this.myUserControl2.PizzaID = 2;
            this.myUserControl2.Price = "5.45$";
            this.myUserControl2.Size = new System.Drawing.Size(231, 335);
            this.myUserControl2.TabIndex = 1;
            // 
            // myUserControl1
            // 
            this.myUserControl1.Comments = "";
            this.myUserControl1.IsInStock = false;
            this.myUserControl1.Location = new System.Drawing.Point(12, 12);
            this.myUserControl1.MyProductName = "ProductName";
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.PizzaID = 1;
            this.myUserControl1.Price = "Price";
            this.myUserControl1.Size = new System.Drawing.Size(231, 344);
            this.myUserControl1.TabIndex = 0;
            // 
            // myUserControl4
            // 
            this.myUserControl4.Comments = "";
            this.myUserControl4.IsInStock = false;
            this.myUserControl4.Location = new System.Drawing.Point(12, 362);
            this.myUserControl4.MyProductName = "ProductName";
            this.myUserControl4.Name = "myUserControl4";
            this.myUserControl4.PizzaID = 4;
            this.myUserControl4.Price = "Price";
            this.myUserControl4.Size = new System.Drawing.Size(224, 331);
            this.myUserControl4.TabIndex = 3;
            // 
            // myUserControl5
            // 
            this.myUserControl5.Comments = "";
            this.myUserControl5.IsInStock = false;
            this.myUserControl5.Location = new System.Drawing.Point(283, 372);
            this.myUserControl5.MyProductName = "ProductName";
            this.myUserControl5.Name = "myUserControl5";
            this.myUserControl5.PizzaID = 12;
            this.myUserControl5.Price = "Price";
            this.myUserControl5.Size = new System.Drawing.Size(224, 331);
            this.myUserControl5.TabIndex = 4;
            // 
            // btnDynamic
            // 
            this.btnDynamic.Location = new System.Drawing.Point(12, 719);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(762, 23);
            this.btnDynamic.TabIndex = 5;
            this.btnDynamic.Text = "Go Dynamic!";
            this.btnDynamic.UseVisualStyleBackColor = true;
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 754);
            this.Controls.Add(this.btnDynamic);
            this.Controls.Add(this.myUserControl5);
            this.Controls.Add(this.myUserControl4);
            this.Controls.Add(this.myUserControl3);
            this.Controls.Add(this.myUserControl2);
            this.Controls.Add(this.myUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControl myUserControl1;
        private MyUserControl myUserControl2;
        private MyUserControl myUserControl3;
        private MyUserControl myUserControl4;
        private MyUserControl myUserControl5;
        private System.Windows.Forms.Button btnDynamic;
    }
}

