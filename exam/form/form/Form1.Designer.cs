namespace form
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
            this.dgvCoffeeShops = new System.Windows.Forms.DataGridView();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.updateDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeShops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCoffeeShops
            // 
            this.dgvCoffeeShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoffeeShops.Location = new System.Drawing.Point(160, 120);
            this.dgvCoffeeShops.Name = "dgvCoffeeShops";
            this.dgvCoffeeShops.Size = new System.Drawing.Size(240, 150);
            this.dgvCoffeeShops.TabIndex = 0;
            
            // 
            // dgvReviews
            // 
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(533, 120);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.Size = new System.Drawing.Size(240, 150);
            this.dgvReviews.TabIndex = 1;
            // 
            // updateDB
            // 
            this.updateDB.Location = new System.Drawing.Point(434, 390);
            this.updateDB.Name = "updateDB";
            this.updateDB.Size = new System.Drawing.Size(75, 23);
            this.updateDB.TabIndex = 2;
            this.updateDB.Text = "update";
            this.updateDB.UseVisualStyleBackColor = true;
            this.updateDB.Click += new System.EventHandler(this.updateDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 560);
            this.Controls.Add(this.updateDB);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.dgvCoffeeShops);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeShops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCoffeeShops;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.Button updateDB;
    }
}

