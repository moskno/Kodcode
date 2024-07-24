namespace Shabbat
{
    partial class Frm4Food
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
            this.lblCtgrGst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFoodLst = new System.Windows.Forms.DataGridView();
            this.btnAddFd = new System.Windows.Forms.Button();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.btnEntr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChoiseLst = new System.Windows.Forms.DataGridView();
            this.btnLeftFd = new System.Windows.Forms.Button();
            this.btnRightFd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoiseLst)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCtgrGst
            // 
            this.lblCtgrGst.AutoSize = true;
            this.lblCtgrGst.Location = new System.Drawing.Point(210, 19);
            this.lblCtgrGst.Name = "lblCtgrGst";
            this.lblCtgrGst.Size = new System.Drawing.Size(62, 16);
            this.lblCtgrGst.TabIndex = 0;
            this.lblCtgrGst.Text = "Category";
            this.lblCtgrGst.Click += new System.EventHandler(this.lblCtgrGst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food choosed by guests";
            // 
            // dgvFoodLst
            // 
            this.dgvFoodLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodLst.Location = new System.Drawing.Point(21, 89);
            this.dgvFoodLst.Name = "dgvFoodLst";
            this.dgvFoodLst.RowHeadersWidth = 51;
            this.dgvFoodLst.RowTemplate.Height = 24;
            this.dgvFoodLst.Size = new System.Drawing.Size(446, 150);
            this.dgvFoodLst.TabIndex = 2;
            // 
            // btnAddFd
            // 
            this.btnAddFd.Location = new System.Drawing.Point(348, 265);
            this.btnAddFd.Name = "btnAddFd";
            this.btnAddFd.Size = new System.Drawing.Size(118, 23);
            this.btnAddFd.TabIndex = 3;
            this.btnAddFd.Text = "Add your choise";
            this.btnAddFd.UseVisualStyleBackColor = true;
            this.btnAddFd.Click += new System.EventHandler(this.btnAddFd_Click);
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(163, 266);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(165, 22);
            this.txtFood.TabIndex = 4;
            this.txtFood.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtFood_Layout);
            // 
            // btnEntr
            // 
            this.btnEntr.Location = new System.Drawing.Point(21, 265);
            this.btnEntr.Name = "btnEntr";
            this.btnEntr.Size = new System.Drawing.Size(119, 23);
            this.btnEntr.TabIndex = 5;
            this.btnEntr.Text = "Enter";
            this.btnEntr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your food choise";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvChoiseLst
            // 
            this.dgvChoiseLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoiseLst.Location = new System.Drawing.Point(23, 330);
            this.dgvChoiseLst.Name = "dgvChoiseLst";
            this.dgvChoiseLst.RowHeadersWidth = 51;
            this.dgvChoiseLst.RowTemplate.Height = 24;
            this.dgvChoiseLst.Size = new System.Drawing.Size(443, 150);
            this.dgvChoiseLst.TabIndex = 7;
            // 
            // btnLeftFd
            // 
            this.btnLeftFd.Location = new System.Drawing.Point(128, 497);
            this.btnLeftFd.Name = "btnLeftFd";
            this.btnLeftFd.Size = new System.Drawing.Size(75, 23);
            this.btnLeftFd.TabIndex = 8;
            this.btnLeftFd.Text = "<<";
            this.btnLeftFd.UseVisualStyleBackColor = true;
            // 
            // btnRightFd
            // 
            this.btnRightFd.Location = new System.Drawing.Point(290, 497);
            this.btnRightFd.Name = "btnRightFd";
            this.btnRightFd.Size = new System.Drawing.Size(75, 23);
            this.btnRightFd.TabIndex = 9;
            this.btnRightFd.Text = ">>";
            this.btnRightFd.UseVisualStyleBackColor = true;
            // 
            // Frm4Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 541);
            this.Controls.Add(this.btnRightFd);
            this.Controls.Add(this.btnLeftFd);
            this.Controls.Add(this.dgvChoiseLst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEntr);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.btnAddFd);
            this.Controls.Add(this.dgvFoodLst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCtgrGst);
            this.Name = "Frm4Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Frm4Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoiseLst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCtgrGst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFoodLst;
        private System.Windows.Forms.Button btnAddFd;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Button btnEntr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvChoiseLst;
        private System.Windows.Forms.Button btnLeftFd;
        private System.Windows.Forms.Button btnRightFd;
    }
}