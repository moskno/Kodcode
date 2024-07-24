namespace Shabbat
{
    partial class Frm2OrderList
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
            this.lblCtgrName = new System.Windows.Forms.Label();
            this.dgvOrdrLst = new System.Windows.Forms.DataGridView();
            this.btnLeftCtgr = new System.Windows.Forms.Button();
            this.btnRightCtgr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdrLst)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCtgrName
            // 
            this.lblCtgrName.AutoSize = true;
            this.lblCtgrName.Location = new System.Drawing.Point(201, 72);
            this.lblCtgrName.Name = "lblCtgrName";
            this.lblCtgrName.Size = new System.Drawing.Size(62, 16);
            this.lblCtgrName.TabIndex = 0;
            this.lblCtgrName.Text = "Category";
            // 
            // dgvOrdrLst
            // 
            this.dgvOrdrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdrLst.Location = new System.Drawing.Point(59, 114);
            this.dgvOrdrLst.Name = "dgvOrdrLst";
            this.dgvOrdrLst.RowHeadersWidth = 51;
            this.dgvOrdrLst.RowTemplate.Height = 24;
            this.dgvOrdrLst.Size = new System.Drawing.Size(350, 150);
            this.dgvOrdrLst.TabIndex = 1;
            this.dgvOrdrLst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdrLst_CellContentClick);
            // 
            // btnLeftCtgr
            // 
            this.btnLeftCtgr.Location = new System.Drawing.Point(103, 293);
            this.btnLeftCtgr.Name = "btnLeftCtgr";
            this.btnLeftCtgr.Size = new System.Drawing.Size(75, 23);
            this.btnLeftCtgr.TabIndex = 2;
            this.btnLeftCtgr.Text = "<<";
            this.btnLeftCtgr.UseVisualStyleBackColor = true;
            this.btnLeftCtgr.Click += new System.EventHandler(this.btnLeftCtgr_Click);
            // 
            // btnRightCtgr
            // 
            this.btnRightCtgr.Location = new System.Drawing.Point(277, 292);
            this.btnRightCtgr.Name = "btnRightCtgr";
            this.btnRightCtgr.Size = new System.Drawing.Size(75, 23);
            this.btnRightCtgr.TabIndex = 3;
            this.btnRightCtgr.Text = ">>";
            this.btnRightCtgr.UseVisualStyleBackColor = true;
            this.btnRightCtgr.Click += new System.EventHandler(this.btnRightCtgr_Click);
            // 
            // Frm2OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 353);
            this.Controls.Add(this.btnRightCtgr);
            this.Controls.Add(this.btnLeftCtgr);
            this.Controls.Add(this.dgvOrdrLst);
            this.Controls.Add(this.lblCtgrName);
            this.Name = "Frm2OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.Frm2OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdrLst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCtgrName;
        private System.Windows.Forms.DataGridView dgvOrdrLst;
        private System.Windows.Forms.Button btnLeftCtgr;
        private System.Windows.Forms.Button btnRightCtgr;
    }
}