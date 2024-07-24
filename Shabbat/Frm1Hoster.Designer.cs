namespace Shabbat
{
    partial class Frm1Hoster
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
            this.txtCtgr = new System.Windows.Forms.TextBox();
            this.btnDeleteCtgr = new System.Windows.Forms.Button();
            this.lbxCtgr = new System.Windows.Forms.ListBox();
            this.btnAddCtgr = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCtgr
            // 
            this.txtCtgr.Location = new System.Drawing.Point(128, 56);
            this.txtCtgr.Name = "txtCtgr";
            this.txtCtgr.Size = new System.Drawing.Size(100, 22);
            this.txtCtgr.TabIndex = 1;
            this.txtCtgr.TextChanged += new System.EventHandler(this.txtCtgr_TextChanged);
            // 
            // btnDeleteCtgr
            // 
            this.btnDeleteCtgr.Location = new System.Drawing.Point(202, 115);
            this.btnDeleteCtgr.Name = "btnDeleteCtgr";
            this.btnDeleteCtgr.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCtgr.TabIndex = 2;
            this.btnDeleteCtgr.Text = "Delete";
            this.btnDeleteCtgr.UseVisualStyleBackColor = true;
            this.btnDeleteCtgr.Click += new System.EventHandler(this.btnDeleteCtgr_Click);
            // 
            // lbxCtgr
            // 
            this.lbxCtgr.FormattingEnabled = true;
            this.lbxCtgr.ItemHeight = 16;
            this.lbxCtgr.Location = new System.Drawing.Point(101, 176);
            this.lbxCtgr.Name = "lbxCtgr";
            this.lbxCtgr.Size = new System.Drawing.Size(156, 148);
            this.lbxCtgr.TabIndex = 3;
            this.lbxCtgr.SelectedIndexChanged += new System.EventHandler(this.lbxCtgr_SelectedIndexChanged);
            // 
            // btnAddCtgr
            // 
            this.btnAddCtgr.Location = new System.Drawing.Point(83, 115);
            this.btnAddCtgr.Name = "btnAddCtgr";
            this.btnAddCtgr.Size = new System.Drawing.Size(75, 23);
            this.btnAddCtgr.TabIndex = 4;
            this.btnAddCtgr.Text = "Add";
            this.btnAddCtgr.UseVisualStyleBackColor = true;
            this.btnAddCtgr.Click += new System.EventHandler(this.btnAddCtgr_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(12, 374);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(123, 23);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.Text = "View order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // Frm1Hoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 428);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnAddCtgr);
            this.Controls.Add(this.lbxCtgr);
            this.Controls.Add(this.btnDeleteCtgr);
            this.Controls.Add(this.txtCtgr);
            this.Controls.Add(this.label1);
            this.Name = "Frm1Hoster";
            this.Text = "Hoster";
            this.Load += new System.EventHandler(this.Frm1Hoster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCtgr;
        private System.Windows.Forms.Button btnDeleteCtgr;
        private System.Windows.Forms.ListBox lbxCtgr;
        private System.Windows.Forms.Button btnAddCtgr;
        private System.Windows.Forms.Button btnViewOrder;
    }
}

