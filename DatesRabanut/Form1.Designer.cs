namespace DatesRabanut
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbWeekDay = new System.Windows.Forms.ComboBox();
            this.cmbMonthDay = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateView = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.cmbWeekDay, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbMonthDay, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbMonth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbYear, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbWeekDay
            // 
            this.cmbWeekDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbWeekDay.FormattingEnabled = true;
            this.cmbWeekDay.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"});
            this.cmbWeekDay.Location = new System.Drawing.Point(503, 63);
            this.cmbWeekDay.Name = "cmbWeekDay";
            this.cmbWeekDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbWeekDay.Size = new System.Drawing.Size(121, 24);
            this.cmbWeekDay.TabIndex = 7;
            // 
            // cmbMonthDay
            // 
            this.cmbMonthDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMonthDay.FormattingEnabled = true;
            this.cmbMonthDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbMonthDay.Location = new System.Drawing.Point(342, 63);
            this.cmbMonthDay.Name = "cmbMonthDay";
            this.cmbMonthDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMonthDay.Size = new System.Drawing.Size(121, 24);
            this.cmbMonthDay.TabIndex = 6;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbMonth.Location = new System.Drawing.Point(181, 63);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "היום בשבוע";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "היום בחודש";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "חודש";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "שנה";
            // 
            // cmbYear
            // 
            this.cmbYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "תשפ\"ד",
            "תשפ\"ה",
            "תשפ\"ו",
            "תשפ\"ז",
            "תשפ\"ח",
            "תשפ\"ט",
            "תש\"ץ",
            "תשצ\"א",
            "תשצ\"ב",
            "תשצ\"ג",
            "תשצ\"ד",
            "תשצ\"ה",
            "תשצ\"ו",
            "תשצ\"ז",
            "תשצ\"ח",
            "תשצ\"ט",
            "ת\"ת"});
            this.cmbYear.Location = new System.Drawing.Point(20, 63);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "כתיבת תאריך עברי";
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.Location = new System.Drawing.Point(133, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(136, 44);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "החזרת התאריך";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnEnter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDateView, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 249);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(402, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // txtDateView
            // 
            this.txtDateView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateView.Location = new System.Drawing.Point(3, 64);
            this.txtDateView.Name = "txtDateView";
            this.txtDateView.ReadOnly = true;
            this.txtDateView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateView.Size = new System.Drawing.Size(396, 22);
            this.txtDateView.TabIndex = 3;
            this.txtDateView.TextChanged += new System.EventHandler(this.txtDateView_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "כתיבת תאריך עברי";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbWeekDay;
        private System.Windows.Forms.ComboBox cmbMonthDay;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtDateView;
    }
}

