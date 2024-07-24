namespace Employeelist
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
            this.tblDetails = new System.Windows.Forms.TableLayoutPanel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.rbtAlman = new System.Windows.Forms.RadioButton();
            this.rbtEx = new System.Windows.Forms.RadioButton();
            this.rbtMariad = new System.Windows.Forms.RadioButton();
            this.rbtSingel = new System.Windows.Forms.RadioButton();
            this.pnlMale = new System.Windows.Forms.Panel();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtHouseNum = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdittion = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.btnSearchByCode = new System.Windows.Forms.Button();
            this.tblDetails.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlMale.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDetails
            // 
            this.tblDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblDetails.ColumnCount = 6;
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblDetails.Controls.Add(this.txtCode, 5, 1);
            this.tblDetails.Controls.Add(this.label6, 5, 0);
            this.tblDetails.Controls.Add(this.label5, 4, 0);
            this.tblDetails.Controls.Add(this.label4, 3, 0);
            this.tblDetails.Controls.Add(this.label3, 2, 0);
            this.tblDetails.Controls.Add(this.label2, 1, 0);
            this.tblDetails.Controls.Add(this.label1, 0, 0);
            this.tblDetails.Controls.Add(this.txtFname, 2, 1);
            this.tblDetails.Controls.Add(this.txtName, 3, 1);
            this.tblDetails.Controls.Add(this.txtId, 4, 1);
            this.tblDetails.Controls.Add(this.txtAge, 0, 1);
            this.tblDetails.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tblDetails.Location = new System.Drawing.Point(40, 46);
            this.tblDetails.Name = "tblDetails";
            this.tblDetails.RowCount = 2;
            this.tblDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblDetails.Size = new System.Drawing.Size(730, 79);
            this.tblDetails.TabIndex = 3;
            this.tblDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(608, 44);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 11;
            this.txtCode.TextChanged += new System.EventHandler(this.codeNum_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "קוד";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "מספר זהות";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "שם פרטי";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "שם משפחה";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "תאריך לידה";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "גיל";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(245, 44);
            this.txtFname.Name = "txtFname";
            this.txtFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFname.Size = new System.Drawing.Size(100, 22);
            this.txtFname.TabIndex = 6;
            this.txtFname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(366, 44);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(487, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 7;
            this.txtId.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(3, 44);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 10;
            this.txtAge.TextChanged += new System.EventHandler(this.ageShow_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.rbtAlman);
            this.pnlStatus.Controls.Add(this.rbtEx);
            this.pnlStatus.Controls.Add(this.rbtMariad);
            this.pnlStatus.Controls.Add(this.rbtSingel);
            this.pnlStatus.Location = new System.Drawing.Point(159, 140);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(200, 117);
            this.pnlStatus.TabIndex = 4;
            this.pnlStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbtAlman
            // 
            this.rbtAlman.AutoSize = true;
            this.rbtAlman.Location = new System.Drawing.Point(81, 88);
            this.rbtAlman.Name = "rbtAlman";
            this.rbtAlman.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtAlman.Size = new System.Drawing.Size(57, 20);
            this.rbtAlman.TabIndex = 6;
            this.rbtAlman.TabStop = true;
            this.rbtAlman.Text = "אלמן";
            this.rbtAlman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtAlman.UseVisualStyleBackColor = true;
            this.rbtAlman.CheckedChanged += new System.EventHandler(this.btncAlman_CheckedChanged);
            // 
            // rbtEx
            // 
            this.rbtEx.AutoSize = true;
            this.rbtEx.Location = new System.Drawing.Point(83, 63);
            this.rbtEx.Name = "rbtEx";
            this.rbtEx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtEx.Size = new System.Drawing.Size(55, 20);
            this.rbtEx.TabIndex = 5;
            this.rbtEx.TabStop = true;
            this.rbtEx.Text = "גרוש";
            this.rbtEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtEx.UseVisualStyleBackColor = true;
            this.rbtEx.CheckedChanged += new System.EventHandler(this.btncEx_CheckedChanged);
            // 
            // rbtMariad
            // 
            this.rbtMariad.AutoSize = true;
            this.rbtMariad.Location = new System.Drawing.Point(86, 37);
            this.rbtMariad.Name = "rbtMariad";
            this.rbtMariad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtMariad.Size = new System.Drawing.Size(52, 20);
            this.rbtMariad.TabIndex = 4;
            this.rbtMariad.TabStop = true;
            this.rbtMariad.Text = "נשוי";
            this.rbtMariad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtMariad.UseVisualStyleBackColor = true;
            this.rbtMariad.CheckedChanged += new System.EventHandler(this.btncMariad_CheckedChanged);
            // 
            // rbtSingel
            // 
            this.rbtSingel.AutoSize = true;
            this.rbtSingel.Location = new System.Drawing.Point(86, 9);
            this.rbtSingel.Name = "rbtSingel";
            this.rbtSingel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtSingel.Size = new System.Drawing.Size(52, 20);
            this.rbtSingel.TabIndex = 3;
            this.rbtSingel.TabStop = true;
            this.rbtSingel.Text = "רווק";
            this.rbtSingel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtSingel.UseVisualStyleBackColor = true;
            this.rbtSingel.CheckedChanged += new System.EventHandler(this.btncSingel_CheckedChanged);
            // 
            // pnlMale
            // 
            this.pnlMale.Controls.Add(this.rbtFemale);
            this.pnlMale.Controls.Add(this.rbtMale);
            this.pnlMale.Location = new System.Drawing.Point(448, 140);
            this.pnlMale.Name = "pnlMale";
            this.pnlMale.Size = new System.Drawing.Size(200, 100);
            this.pnlMale.TabIndex = 5;
            this.pnlMale.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMale_Paint);
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(79, 56);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtFemale.Size = new System.Drawing.Size(56, 20);
            this.rbtFemale.TabIndex = 2;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "נקבה";
            this.rbtFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtFemale.UseVisualStyleBackColor = true;
            this.rbtFemale.CheckedChanged += new System.EventHandler(this.btncFemale_CheckedChanged);
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(88, 22);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtMale.Size = new System.Drawing.Size(47, 20);
            this.rbtMale.TabIndex = 0;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "זכר";
            this.rbtMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtMale.UseVisualStyleBackColor = true;
            this.rbtMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(256, 270);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(124, 36);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "<<<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(428, 269);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(126, 37);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = ">>>>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txtPhone, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMobilePhone, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStreet, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHouseNum, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPhone, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCity, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(43, 325);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(727, 89);
            this.tableLayoutPanel2.TabIndex = 8;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "עיר";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "מספר";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "רחוב";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "נייד";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(633, 14);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(40, 16);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "טלפון";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.Location = new System.Drawing.Point(22, 55);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 5;
            // 
            // txtHouseNum
            // 
            this.txtHouseNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseNum.Location = new System.Drawing.Point(167, 55);
            this.txtHouseNum.Name = "txtHouseNum";
            this.txtHouseNum.Size = new System.Drawing.Size(100, 22);
            this.txtHouseNum.TabIndex = 6;
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStreet.Location = new System.Drawing.Point(312, 55);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 7;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobilePhone.Location = new System.Drawing.Point(457, 55);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(100, 22);
            this.txtMobilePhone.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(603, 55);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdittion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 432);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 43);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(35, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "מחיקת עובד";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(216, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdittion
            // 
            this.btnAdittion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdittion.Location = new System.Drawing.Point(397, 10);
            this.btnAdittion.Name = "btnAdittion";
            this.btnAdittion.Size = new System.Drawing.Size(110, 23);
            this.btnAdittion.TabIndex = 2;
            this.btnAdittion.Text = "הוספת עובד";
            this.btnAdittion.UseVisualStyleBackColor = true;
            this.btnAdittion.Click += new System.EventHandler(this.btnAdittion_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Location = new System.Drawing.Point(580, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(326, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "רשימת עובדים";
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(188, 509);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(181, 23);
            this.btnSearchById.TabIndex = 11;
            this.btnSearchById.Text = "חיפוש עובד לפי מספר זהות";
            this.btnSearchById.UseVisualStyleBackColor = true;
            // 
            // btnSearchByCode
            // 
            this.btnSearchByCode.Location = new System.Drawing.Point(435, 510);
            this.btnSearchByCode.Name = "btnSearchByCode";
            this.btnSearchByCode.Size = new System.Drawing.Size(181, 23);
            this.btnSearchByCode.TabIndex = 12;
            this.btnSearchByCode.Text = "חיפוש עובד לפי קוד";
            this.btnSearchByCode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 572);
            this.Controls.Add(this.btnSearchByCode);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pnlMale);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.tblDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblDetails.ResumeLayout(false);
            this.tblDetails.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlMale.ResumeLayout(false);
            this.pnlMale.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlMale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtMariad;
        private System.Windows.Forms.RadioButton rbtSingel;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtAlman;
        private System.Windows.Forms.RadioButton rbtEx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtHouseNum;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdittion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Button btnSearchByCode;
    }
}

