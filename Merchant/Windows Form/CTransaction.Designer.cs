namespace Merchant.Windows_Form
{
    partial class CTransaction
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
            this.updateButton = new System.Windows.Forms.Button();
            this.editCheckbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chalanIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCaseTextbox = new System.Windows.Forms.TextBox();
            this.laborCostTextbox = new System.Windows.Forms.TextBox();
            this.chalanCostTextbox = new System.Windows.Forms.TextBox();
            this.dateTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.deletePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(3, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 29);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // editCheckbox
            // 
            this.editCheckbox.AutoSize = true;
            this.editCheckbox.Location = new System.Drawing.Point(770, 122);
            this.editCheckbox.Name = "editCheckbox";
            this.editCheckbox.Size = new System.Drawing.Size(15, 14);
            this.editCheckbox.TabIndex = 18;
            this.editCheckbox.UseVisualStyleBackColor = true;
            this.editCheckbox.CheckedChanged += new System.EventHandler(this.editCheckbox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(277, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "( To edit  the table ,checked the box )";
            // 
            // deletePanel
            // 
            this.deletePanel.Controls.Add(this.deleteButton);
            this.deletePanel.Location = new System.Drawing.Point(940, 448);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(105, 35);
            this.deletePanel.TabIndex = 15;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(3, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 29);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(833, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 47);
            this.panel3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Transaction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(90, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Information";
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.updateButton);
            this.updatePanel.Location = new System.Drawing.Point(791, 448);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(105, 35);
            this.updatePanel.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(16, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chalan Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(16, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Case :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(16, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Labor Cost :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chalan Cost :";
            // 
            // chalanIDTextbox
            // 
            this.chalanIDTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chalanIDTextbox.Location = new System.Drawing.Point(118, 42);
            this.chalanIDTextbox.Name = "chalanIDTextbox";
            this.chalanIDTextbox.Size = new System.Drawing.Size(128, 23);
            this.chalanIDTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(309, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chalan ";
            // 
            // totalCaseTextbox
            // 
            this.totalCaseTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaseTextbox.Location = new System.Drawing.Point(118, 264);
            this.totalCaseTextbox.Name = "totalCaseTextbox";
            this.totalCaseTextbox.Size = new System.Drawing.Size(128, 23);
            this.totalCaseTextbox.TabIndex = 7;
            // 
            // laborCostTextbox
            // 
            this.laborCostTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborCostTextbox.Location = new System.Drawing.Point(118, 208);
            this.laborCostTextbox.Name = "laborCostTextbox";
            this.laborCostTextbox.Size = new System.Drawing.Size(128, 23);
            this.laborCostTextbox.TabIndex = 6;
            // 
            // chalanCostTextbox
            // 
            this.chalanCostTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chalanCostTextbox.Location = new System.Drawing.Point(118, 152);
            this.chalanCostTextbox.Name = "chalanCostTextbox";
            this.chalanCostTextbox.Size = new System.Drawing.Size(128, 23);
            this.chalanCostTextbox.TabIndex = 5;
            // 
            // dateTextbox
            // 
            this.dateTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextbox.Location = new System.Drawing.Point(118, 97);
            this.dateTextbox.Name = "dateTextbox";
            this.dateTextbox.Size = new System.Drawing.Size(128, 23);
            this.dateTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(429, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 70);
            this.panel1.TabIndex = 12;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ChalanID";
            this.columnHeader5.Width = 156;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Case";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Labor Cost";
            this.columnHeader3.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chalan Cost";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 146;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.totalCaseTextbox);
            this.panel2.Controls.Add(this.laborCostTextbox);
            this.panel2.Controls.Add(this.chalanCostTextbox);
            this.panel2.Controls.Add(this.dateTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chalanIDTextbox);
            this.panel2.Location = new System.Drawing.Point(791, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 300);
            this.panel2.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(11, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 300);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // CTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1056, 494);
            this.Controls.Add(this.editCheckbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "CTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTransaction";
            this.Load += new System.EventHandler(this.CTransaction_Load);
            this.deletePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckBox editCheckbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chalanIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalCaseTextbox;
        private System.Windows.Forms.TextBox laborCostTextbox;
        private System.Windows.Forms.TextBox chalanCostTextbox;
        private System.Windows.Forms.TextBox dateTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
    }
}