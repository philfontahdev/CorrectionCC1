namespace Facture
{
    partial class SellProduct
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
            this.listViewpro = new System.Windows.Forms.ListView();
            this.Reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBquantity = new System.Windows.Forms.TextBox();
            this.tBprice = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewpro
            // 
            this.listViewpro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reference,
            this.Name,
            this.Quantity,
            this.Price});
            this.listViewpro.HideSelection = false;
            this.listViewpro.Location = new System.Drawing.Point(299, 12);
            this.listViewpro.Name = "listViewpro";
            this.listViewpro.Size = new System.Drawing.Size(489, 198);
            this.listViewpro.TabIndex = 0;
            this.listViewpro.UseCompatibleStateImageBehavior = false;
            this.listViewpro.View = System.Windows.Forms.View.Details;
            // 
            // Reference
            // 
            this.Reference.Text = "Reference";
            this.Reference.Width = 141;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 149;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 97;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(12, 28);
            this.tBName.Multiline = true;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(219, 33);
            this.tBName.TabIndex = 5;
            // 
            // tBquantity
            // 
            this.tBquantity.Location = new System.Drawing.Point(15, 83);
            this.tBquantity.Multiline = true;
            this.tBquantity.Name = "tBquantity";
            this.tBquantity.Size = new System.Drawing.Size(219, 33);
            this.tBquantity.TabIndex = 6;
            // 
            // tBprice
            // 
            this.tBprice.Location = new System.Drawing.Point(12, 138);
            this.tBprice.Multiline = true;
            this.tBprice.Name = "tBprice";
            this.tBprice.Size = new System.Drawing.Size(219, 33);
            this.tBprice.TabIndex = 7;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(125, 232);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(109, 30);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(644, 232);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(109, 30);
            this.Print.TabIndex = 9;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.tBprice);
            this.Controls.Add(this.tBquantity);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewpro);
            this.Text = "SellProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Reference;
        private new System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Print;
        public System.Windows.Forms.ListView listViewpro;
        public System.Windows.Forms.TextBox tBName;
        public System.Windows.Forms.TextBox tBquantity;
        public System.Windows.Forms.TextBox tBprice;
    }
}