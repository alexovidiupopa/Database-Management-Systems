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
            this.viewChildren = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChildren)).BeginInit();
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
            // 
            // view
            // 
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Location = new System.Drawing.Point(31, 29);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(442, 457);
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
            // 
            // deleteRecords
            // 
            this.deleteRecords.Location = new System.Drawing.Point(1349, 856);
            this.deleteRecords.Name = "deleteRecords";
            this.deleteRecords.Size = new System.Drawing.Size(132, 23);
            this.deleteRecords.TabIndex = 3;
            this.deleteRecords.Text = "Delete Child Records";
            this.deleteRecords.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 862);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Player Id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(571, 860);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Player Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(718, 860);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Player Rating";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(872, 859);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Title Id";
            // 
            // addRecord
            // 
            this.addRecord.Location = new System.Drawing.Point(1024, 857);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(132, 23);
            this.addRecord.TabIndex = 8;
            this.addRecord.Text = "Add Child Record";
            this.addRecord.UseVisualStyleBackColor = true;
            // 
            // updateRecord
            // 
            this.updateRecord.Location = new System.Drawing.Point(1181, 857);
            this.updateRecord.Name = "updateRecord";
            this.updateRecord.Size = new System.Drawing.Size(132, 23);
            this.updateRecord.TabIndex = 9;
            this.updateRecord.Text = "Update Child Record";
            this.updateRecord.UseVisualStyleBackColor = true;
            // 
            // viewChildren
            // 
            this.viewChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewChildren.Location = new System.Drawing.Point(526, 29);
            this.viewChildren.Name = "viewChildren";
            this.viewChildren.Size = new System.Drawing.Size(442, 457);
            this.viewChildren.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Parent Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Child Table";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updateDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewChildren);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewChildren)).EndInit();
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
        private System.Windows.Forms.DataGridView viewChildren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

