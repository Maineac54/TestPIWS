namespace TestPIWS
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabSnapShot = new System.Windows.Forms.TabPage();
			this.txtSnapShotOut = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSnapShotTag = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtSnapShotValue = new System.Windows.Forms.TextBox();
			this.tabByDate = new System.Windows.Forms.TabPage();
			this.txtValCnt = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvCompData = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.picTo = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.picFrom = new System.Windows.Forms.DateTimePicker();
			this.txtCompOut = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.txtCompTag = new System.Windows.Forms.TextBox();
			this.tabSample = new System.Windows.Forms.TabPage();
			this.cboSmplUnit = new System.Windows.Forms.ComboBox();
			this.txtSmplIntv = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dgvSmplData = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.picSmplTo = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.picSmplFrom = new System.Windows.Forms.DateTimePicker();
			this.txtSmplOut = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.txtSmplTag = new System.Windows.Forms.TextBox();
			this.tabWrite = new System.Windows.Forms.TabPage();
			this.picWrite = new System.Windows.Forms.DateTimePicker();
			this.txtWriteOut = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnWriteData = new System.Windows.Forms.Button();
			this.txtWriteVal = new System.Windows.Forms.TextBox();
			this.txtWriteTag = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtQltyMask = new System.Windows.Forms.TextBox();
			this.txtPISrvrNm = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabSnapShot.SuspendLayout();
			this.tabByDate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompData)).BeginInit();
			this.tabSample.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSmplData)).BeginInit();
			this.tabWrite.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabSnapShot);
			this.tabControl1.Controls.Add(this.tabByDate);
			this.tabControl1.Controls.Add(this.tabSample);
			this.tabControl1.Controls.Add(this.tabWrite);
			this.tabControl1.Location = new System.Drawing.Point(12, 44);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(514, 412);
			this.tabControl1.TabIndex = 7;
			this.tabControl1.Resize += new System.EventHandler(this.tabControl1_Resize);
			// 
			// tabSnapShot
			// 
			this.tabSnapShot.Controls.Add(this.txtSnapShotOut);
			this.tabSnapShot.Controls.Add(this.label2);
			this.tabSnapShot.Controls.Add(this.txtSnapShotTag);
			this.tabSnapShot.Controls.Add(this.label1);
			this.tabSnapShot.Controls.Add(this.button1);
			this.tabSnapShot.Controls.Add(this.txtSnapShotValue);
			this.tabSnapShot.Location = new System.Drawing.Point(4, 22);
			this.tabSnapShot.Name = "tabSnapShot";
			this.tabSnapShot.Padding = new System.Windows.Forms.Padding(3);
			this.tabSnapShot.Size = new System.Drawing.Size(506, 386);
			this.tabSnapShot.TabIndex = 0;
			this.tabSnapShot.Text = "Snap Shot";
			this.tabSnapShot.UseVisualStyleBackColor = true;
			// 
			// txtSnapShotOut
			// 
			this.txtSnapShotOut.Location = new System.Drawing.Point(6, 90);
			this.txtSnapShotOut.Multiline = true;
			this.txtSnapShotOut.Name = "txtSnapShotOut";
			this.txtSnapShotOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSnapShotOut.Size = new System.Drawing.Size(493, 290);
			this.txtSnapShotOut.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "PI Tag";
			// 
			// txtSnapShotTag
			// 
			this.txtSnapShotTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestPIWS.Properties.Settings.Default, "SnapShotTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtSnapShotTag.Location = new System.Drawing.Point(6, 26);
			this.txtSnapShotTag.Name = "txtSnapShotTag";
			this.txtSnapShotTag.Size = new System.Drawing.Size(244, 20);
			this.txtSnapShotTag.TabIndex = 10;
			this.txtSnapShotTag.Text = global::TestPIWS.Properties.Settings.Default.SnapShotTag;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(257, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Value";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(408, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 27);
			this.button1.TabIndex = 8;
			this.button1.Text = "Get Data";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtSnapShotValue
			// 
			this.txtSnapShotValue.Location = new System.Drawing.Point(256, 26);
			this.txtSnapShotValue.Name = "txtSnapShotValue";
			this.txtSnapShotValue.Size = new System.Drawing.Size(244, 20);
			this.txtSnapShotValue.TabIndex = 7;
			// 
			// tabByDate
			// 
			this.tabByDate.Controls.Add(this.txtValCnt);
			this.tabByDate.Controls.Add(this.label7);
			this.tabByDate.Controls.Add(this.dgvCompData);
			this.tabByDate.Controls.Add(this.label5);
			this.tabByDate.Controls.Add(this.picTo);
			this.tabByDate.Controls.Add(this.label4);
			this.tabByDate.Controls.Add(this.picFrom);
			this.tabByDate.Controls.Add(this.txtCompOut);
			this.tabByDate.Controls.Add(this.label3);
			this.tabByDate.Controls.Add(this.button3);
			this.tabByDate.Controls.Add(this.txtCompTag);
			this.tabByDate.Location = new System.Drawing.Point(4, 22);
			this.tabByDate.Name = "tabByDate";
			this.tabByDate.Padding = new System.Windows.Forms.Padding(3);
			this.tabByDate.Size = new System.Drawing.Size(506, 386);
			this.tabByDate.TabIndex = 1;
			this.tabByDate.Text = "Date Range";
			this.tabByDate.UseVisualStyleBackColor = true;
			// 
			// txtValCnt
			// 
			this.txtValCnt.Location = new System.Drawing.Point(283, 4);
			this.txtValCnt.Name = "txtValCnt";
			this.txtValCnt.Size = new System.Drawing.Size(67, 20);
			this.txtValCnt.TabIndex = 26;
			this.txtValCnt.Text = "10";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(210, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "Num of Vals:";
			// 
			// dgvCompData
			// 
			this.dgvCompData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCompData.Location = new System.Drawing.Point(6, 61);
			this.dgvCompData.Name = "dgvCompData";
			this.dgvCompData.Size = new System.Drawing.Size(492, 202);
			this.dgvCompData.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(235, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "To Date:";
			// 
			// picTo
			// 
			this.picTo.CustomFormat = "dd-MMM-yyyy hh:mm:ss";
			this.picTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.picTo.Location = new System.Drawing.Point(300, 35);
			this.picTo.Name = "picTo";
			this.picTo.Size = new System.Drawing.Size(200, 20);
			this.picTo.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "From Date:";
			// 
			// picFrom
			// 
			this.picFrom.CustomFormat = "dd-MMM-yyyy hh:mm:ss";
			this.picFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.picFrom.Location = new System.Drawing.Point(71, 34);
			this.picFrom.Name = "picFrom";
			this.picFrom.Size = new System.Drawing.Size(167, 20);
			this.picFrom.TabIndex = 20;
			// 
			// txtCompOut
			// 
			this.txtCompOut.Location = new System.Drawing.Point(6, 269);
			this.txtCompOut.Multiline = true;
			this.txtCompOut.Name = "txtCompOut";
			this.txtCompOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtCompOut.Size = new System.Drawing.Size(493, 99);
			this.txtCompOut.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "PI Tag";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(422, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(81, 27);
			this.button3.TabIndex = 15;
			this.button3.Text = "Get Data";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtCompTag
			// 
			this.txtCompTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestPIWS.Properties.Settings.Default, "DateRangeTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtCompTag.Location = new System.Drawing.Point(71, 2);
			this.txtCompTag.Name = "txtCompTag";
			this.txtCompTag.Size = new System.Drawing.Size(132, 20);
			this.txtCompTag.TabIndex = 17;
			this.txtCompTag.Text = global::TestPIWS.Properties.Settings.Default.DateRangeTag;
			// 
			// tabSample
			// 
			this.tabSample.Controls.Add(this.cboSmplUnit);
			this.tabSample.Controls.Add(this.txtSmplIntv);
			this.tabSample.Controls.Add(this.label8);
			this.tabSample.Controls.Add(this.dgvSmplData);
			this.tabSample.Controls.Add(this.label9);
			this.tabSample.Controls.Add(this.picSmplTo);
			this.tabSample.Controls.Add(this.label10);
			this.tabSample.Controls.Add(this.picSmplFrom);
			this.tabSample.Controls.Add(this.txtSmplOut);
			this.tabSample.Controls.Add(this.label11);
			this.tabSample.Controls.Add(this.button4);
			this.tabSample.Controls.Add(this.txtSmplTag);
			this.tabSample.Location = new System.Drawing.Point(4, 22);
			this.tabSample.Name = "tabSample";
			this.tabSample.Padding = new System.Windows.Forms.Padding(3);
			this.tabSample.Size = new System.Drawing.Size(506, 386);
			this.tabSample.TabIndex = 2;
			this.tabSample.Text = "Sampled Values";
			this.tabSample.UseVisualStyleBackColor = true;
			// 
			// cboSmplUnit
			// 
			this.cboSmplUnit.FormattingEnabled = true;
			this.cboSmplUnit.Items.AddRange(new object[] {
            "s",
            "m",
            "h",
            "d"});
			this.cboSmplUnit.Location = new System.Drawing.Point(334, 7);
			this.cboSmplUnit.Name = "cboSmplUnit";
			this.cboSmplUnit.Size = new System.Drawing.Size(66, 21);
			this.cboSmplUnit.TabIndex = 38;
			this.cboSmplUnit.Text = "m";
			// 
			// txtSmplIntv
			// 
			this.txtSmplIntv.Location = new System.Drawing.Point(282, 5);
			this.txtSmplIntv.Name = "txtSmplIntv";
			this.txtSmplIntv.Size = new System.Drawing.Size(45, 20);
			this.txtSmplIntv.TabIndex = 37;
			this.txtSmplIntv.Text = "10";
			this.txtSmplIntv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(209, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 36;
			this.label8.Text = "Interval:";
			// 
			// dgvSmplData
			// 
			this.dgvSmplData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSmplData.Location = new System.Drawing.Point(5, 62);
			this.dgvSmplData.Name = "dgvSmplData";
			this.dgvSmplData.Size = new System.Drawing.Size(492, 202);
			this.dgvSmplData.TabIndex = 35;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(234, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 34;
			this.label9.Text = "To Date:";
			// 
			// picSmplTo
			// 
			this.picSmplTo.CustomFormat = "dd-MMM-yyyy HH:mm:ss";
			this.picSmplTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.picSmplTo.Location = new System.Drawing.Point(299, 36);
			this.picSmplTo.Name = "picSmplTo";
			this.picSmplTo.Size = new System.Drawing.Size(200, 20);
			this.picSmplTo.TabIndex = 33;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(5, 41);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 13);
			this.label10.TabIndex = 32;
			this.label10.Text = "From Date:";
			// 
			// picSmplFrom
			// 
			this.picSmplFrom.CustomFormat = "dd-MMM-yyyy HH:mm:ss";
			this.picSmplFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.picSmplFrom.Location = new System.Drawing.Point(70, 35);
			this.picSmplFrom.Name = "picSmplFrom";
			this.picSmplFrom.Size = new System.Drawing.Size(167, 20);
			this.picSmplFrom.TabIndex = 31;
			// 
			// txtSmplOut
			// 
			this.txtSmplOut.Location = new System.Drawing.Point(5, 270);
			this.txtSmplOut.Multiline = true;
			this.txtSmplOut.Name = "txtSmplOut";
			this.txtSmplOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSmplOut.Size = new System.Drawing.Size(493, 99);
			this.txtSmplOut.TabIndex = 30;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(39, 13);
			this.label11.TabIndex = 29;
			this.label11.Text = "PI Tag";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(421, 6);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(81, 27);
			this.button4.TabIndex = 27;
			this.button4.Text = "Get Data";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// txtSmplTag
			// 
			this.txtSmplTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestPIWS.Properties.Settings.Default, "SampledTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtSmplTag.Location = new System.Drawing.Point(70, 3);
			this.txtSmplTag.Name = "txtSmplTag";
			this.txtSmplTag.Size = new System.Drawing.Size(132, 20);
			this.txtSmplTag.TabIndex = 28;
			this.txtSmplTag.Text = global::TestPIWS.Properties.Settings.Default.SampledTag;
			// 
			// tabWrite
			// 
			this.tabWrite.Controls.Add(this.picWrite);
			this.tabWrite.Controls.Add(this.txtWriteOut);
			this.tabWrite.Controls.Add(this.label12);
			this.tabWrite.Controls.Add(this.label13);
			this.tabWrite.Controls.Add(this.btnWriteData);
			this.tabWrite.Controls.Add(this.txtWriteVal);
			this.tabWrite.Controls.Add(this.txtWriteTag);
			this.tabWrite.Location = new System.Drawing.Point(4, 22);
			this.tabWrite.Name = "tabWrite";
			this.tabWrite.Padding = new System.Windows.Forms.Padding(3);
			this.tabWrite.Size = new System.Drawing.Size(506, 386);
			this.tabWrite.TabIndex = 3;
			this.tabWrite.Text = "Write Data";
			this.tabWrite.UseVisualStyleBackColor = true;
			// 
			// picWrite
			// 
			this.picWrite.CustomFormat = "dd-MMM-yyyy hh:mm:ss";
			this.picWrite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.picWrite.Location = new System.Drawing.Point(10, 53);
			this.picWrite.Name = "picWrite";
			this.picWrite.Size = new System.Drawing.Size(167, 20);
			this.picWrite.TabIndex = 21;
			// 
			// txtWriteOut
			// 
			this.txtWriteOut.Location = new System.Drawing.Point(6, 90);
			this.txtWriteOut.Multiline = true;
			this.txtWriteOut.Name = "txtWriteOut";
			this.txtWriteOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtWriteOut.Size = new System.Drawing.Size(493, 290);
			this.txtWriteOut.TabIndex = 19;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 7);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(39, 13);
			this.label12.TabIndex = 18;
			this.label12.Text = "PI Tag";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(256, 40);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(34, 13);
			this.label13.TabIndex = 16;
			this.label13.Text = "Value";
			// 
			// btnWriteData
			// 
			this.btnWriteData.Location = new System.Drawing.Point(408, 52);
			this.btnWriteData.Name = "btnWriteData";
			this.btnWriteData.Size = new System.Drawing.Size(92, 27);
			this.btnWriteData.TabIndex = 15;
			this.btnWriteData.Text = "Write Value";
			this.btnWriteData.UseVisualStyleBackColor = true;
			this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
			// 
			// txtWriteVal
			// 
			this.txtWriteVal.Location = new System.Drawing.Point(183, 56);
			this.txtWriteVal.Name = "txtWriteVal";
			this.txtWriteVal.Size = new System.Drawing.Size(134, 20);
			this.txtWriteVal.TabIndex = 14;
			this.txtWriteVal.Text = "250";
			// 
			// txtWriteTag
			// 
			this.txtWriteTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestPIWS.Properties.Settings.Default, "WriteTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtWriteTag.Location = new System.Drawing.Point(6, 26);
			this.txtWriteTag.Name = "txtWriteTag";
			this.txtWriteTag.Size = new System.Drawing.Size(244, 20);
			this.txtWriteTag.TabIndex = 17;
			this.txtWriteTag.Text = global::TestPIWS.Properties.Settings.Default.WriteTag;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(434, 462);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 27);
			this.button2.TabIndex = 13;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(17, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "PI Server:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(302, 15);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(116, 20);
			this.label14.TabIndex = 16;
			this.label14.Text = "Quality Mask:";
			// 
			// txtQltyMask
			// 
			this.txtQltyMask.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestPIWS.Properties.Settings.Default, "QualityMask", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtQltyMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQltyMask.Location = new System.Drawing.Point(424, 12);
			this.txtQltyMask.Name = "txtQltyMask";
			this.txtQltyMask.Size = new System.Drawing.Size(98, 26);
			this.txtQltyMask.TabIndex = 17;
			this.txtQltyMask.Text = global::TestPIWS.Properties.Settings.Default.QualityMask;
			this.txtQltyMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPISrvrNm
			// 
			this.txtPISrvrNm.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestPIWS.Properties.Settings.Default, "PIServerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtPISrvrNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPISrvrNm.Location = new System.Drawing.Point(111, 12);
			this.txtPISrvrNm.Name = "txtPISrvrNm";
			this.txtPISrvrNm.Size = new System.Drawing.Size(134, 26);
			this.txtPISrvrNm.TabIndex = 15;
			this.txtPISrvrNm.Text = global::TestPIWS.Properties.Settings.Default.PIServerName;
			this.txtPISrvrNm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 492);
			this.Controls.Add(this.txtQltyMask);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtPISrvrNm);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Test PI Web Service";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.tabControl1.ResumeLayout(false);
			this.tabSnapShot.ResumeLayout(false);
			this.tabSnapShot.PerformLayout();
			this.tabByDate.ResumeLayout(false);
			this.tabByDate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompData)).EndInit();
			this.tabSample.ResumeLayout(false);
			this.tabSample.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSmplData)).EndInit();
			this.tabWrite.ResumeLayout(false);
			this.tabWrite.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSnapShot;
		private System.Windows.Forms.TabPage tabByDate;
		private System.Windows.Forms.TextBox txtSnapShotOut;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSnapShotTag;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSnapShotValue;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtCompOut;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCompTag;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dgvCompData;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker picTo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker picFrom;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPISrvrNm;
		private System.Windows.Forms.TextBox txtValCnt;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabSample;
		private System.Windows.Forms.ComboBox cboSmplUnit;
		private System.Windows.Forms.TextBox txtSmplIntv;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dgvSmplData;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker picSmplTo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker picSmplFrom;
		private System.Windows.Forms.TextBox txtSmplOut;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSmplTag;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TabPage tabWrite;
		private System.Windows.Forms.DateTimePicker picWrite;
		private System.Windows.Forms.TextBox txtWriteOut;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtWriteTag;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnWriteData;
		private System.Windows.Forms.TextBox txtWriteVal;
		private System.Windows.Forms.TextBox txtQltyMask;
		private System.Windows.Forms.Label label14;
	}
}

