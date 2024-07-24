namespace Shabbat
{
    partial class Frm3Guest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGstName = new System.Windows.Forms.TextBox();
            this.btnAddGst = new System.Windows.Forms.Button();
            this.btnDeleteGst = new System.Windows.Forms.Button();
            this.lbxGst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name or choose from list";
            // 
            // txtGstName
            // 
            this.txtGstName.Location = new System.Drawing.Point(147, 106);
            this.txtGstName.Name = "txtGstName";
            this.txtGstName.Size = new System.Drawing.Size(178, 22);
            this.txtGstName.TabIndex = 1;
            this.txtGstName.TextChanged += new System.EventHandler(this.txtGstName_TextChanged);
            // 
            // btnAddGst
            // 
            this.btnAddGst.Location = new System.Drawing.Point(109, 166);
            this.btnAddGst.Name = "btnAddGst";
            this.btnAddGst.Size = new System.Drawing.Size(75, 23);
            this.btnAddGst.TabIndex = 2;
            this.btnAddGst.Text = "Add";
            this.btnAddGst.UseVisualStyleBackColor = true;
            this.btnAddGst.Click += new System.EventHandler(this.btnAddGst_Click);
            // 
            // btnDeleteGst
            // 
            this.btnDeleteGst.Location = new System.Drawing.Point(282, 166);
            this.btnDeleteGst.Name = "btnDeleteGst";
            this.btnDeleteGst.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGst.TabIndex = 3;
            this.btnDeleteGst.Text = "delete";
            this.btnDeleteGst.UseVisualStyleBackColor = true;
            // 
            // lbxGst
            // 
            this.lbxGst.FormattingEnabled = true;
            this.lbxGst.ItemHeight = 16;
            this.lbxGst.Location = new System.Drawing.Point(161, 226);
            this.lbxGst.Name = "lbxGst";
            this.lbxGst.Size = new System.Drawing.Size(148, 164);
            this.lbxGst.TabIndex = 5;
            // 
            // Frm3Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.lbxGst);
            this.Controls.Add(this.btnDeleteGst);
            this.Controls.Add(this.btnAddGst);
            this.Controls.Add(this.txtGstName);
            this.Controls.Add(this.label1);
            this.Name = "Frm3Guest";
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.Frm3Guest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGstName;
        private System.Windows.Forms.Button btnAddGst;
        private System.Windows.Forms.Button btnDeleteGst;
        private System.Windows.Forms.ListBox lbxGst;
    }
}