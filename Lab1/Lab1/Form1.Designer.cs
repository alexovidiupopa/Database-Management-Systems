namespace Lab1
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
            this.displayParents = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.DataGridView();
            this.displayChildren = new System.Windows.Forms.Button();
            this.deleteRecords = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.addRecord = new System.Windows.Forms.Button();
            this.updateRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // displayParents
            // 
            this.displayParents.Location = new System.Drawing.Point(23, 860);
            this.displayParents.Name = "displayParents";
            this.displayParents.Size = new System.Drawing.Size(132, 23);
            this.displayParents.TabIndex = 0;
            this.displayParents.Text = "Display Parent Table";
            this.displayParents.UseVisualStyleBackColor = true;
            this.displayParents.Click += new System.EventHandler(this.displayParent_Click);
            // 
            // view
            // 
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Location = new System.Drawing.Point(12, 12);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(1397, 802);
            this.view.TabIndex = 1;
            // 
            // displayChildren
            // 
            this.displayChildren.Location = new System.Drawing.Point(210, 860);
            this.displayChildren.Name = "displayChildren";
            this.displayChildren.Size = new System.Drawing.Size(132, 23);
            this.displayChildren.TabIndex = 2;
            this.displayChildren.Text = "Display Child Records";
            this.displayChildren.UseVisualStyleBackColor = true;
            this.displayChildren.Click += new System.EventHandler(this.displayChild_Click);
            // 
            // deleteRecords
            // 
            this.deleteRecords.Location = new System.Drawing.Point(1349, 856);
            this.deleteRecords.Name = "deleteRecords";
            this.deleteRecords.Size = new System.Drawing.Size(132, 23);
            this.deleteRecords.TabIndex = 3;
            this.deleteRecords.Text = "Delete Child Records";
            this.deleteRecords.UseVisualStyleBackColor = true;
            this.deleteRecords.Click += new System.EventHandler(this.deleteRecords_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 862);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Player Id";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(571, 860);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Player Name";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(718, 860);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Player Rating";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(872, 859);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Title Id";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(1024, 857);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(132, 23);
            this.addRecord.TabIndex = 8;
            this.addRecord.Text = "Add Child Record";
            this.addRecord.UseVisualStyleBackColor = true;
            this.addRecord.Click += new System.EventHandler(this.addRecord_Click);
            // 
            // updateRecord
            // 
            this.updateRecord.Location = new System.Drawing.Point(1181, 857);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(132, 23);
            this.updateRecord.TabIndex = 9;
            this.updateRecord.Text = "Update Child Record";
            this.updateRecord.UseVisualStyleBackColor = true;
            this.updateRecord.Click += new System.EventHandler(this.updateRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 955);
            this.Controls.Add(this.updateRecord);
            this.Controls.Add(this.addRecord);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteRecords);
            this.Controls.Add(this.displayChildren);
            this.Controls.Add(this.view);
            this.Controls.Add(this.displayParents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayParents;
        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Button displayChildren;
        private System.Windows.Forms.Button deleteRecords;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button addRecord;
        private System.Windows.Forms.Button updateRecord;
    }
}

