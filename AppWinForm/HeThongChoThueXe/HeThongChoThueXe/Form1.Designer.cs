namespace HeThongChoThueXe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxComList = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t1 = new System.Windows.Forms.Label();
            this.time1t = new System.Windows.Forms.Label();
            this.time1m = new System.Windows.Forms.Label();
            this.tt1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.t2 = new System.Windows.Forms.Label();
            this.time2t = new System.Windows.Forms.Label();
            this.time2m = new System.Windows.Forms.Label();
            this.tt2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkXe2 = new System.Windows.Forms.CheckBox();
            this.checkXe1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.day1m = new System.Windows.Forms.Label();
            this.day1t = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.day2m = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.day2t = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxComList);
            this.groupBox1.Location = new System.Drawing.Point(12, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết nối với thiết bị";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxComList
            // 
            this.cbxComList.FormattingEnabled = true;
            this.cbxComList.Location = new System.Drawing.Point(6, 19);
            this.cbxComList.Name = "cbxComList";
            this.cbxComList.Size = new System.Drawing.Size(74, 21);
            this.cbxComList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.day1t);
            this.groupBox2.Controls.Add(this.day1m);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.t1);
            this.groupBox2.Controls.Add(this.time1t);
            this.groupBox2.Controls.Add(this.time1m);
            this.groupBox2.Controls.Add(this.tt1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xe số 1";
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(187, 125);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(16, 15);
            this.t1.TabIndex = 12;
            this.t1.Text = "0";
            // 
            // time1t
            // 
            this.time1t.AutoSize = true;
            this.time1t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1t.Location = new System.Drawing.Point(292, 58);
            this.time1t.Name = "time1t";
            this.time1t.Size = new System.Drawing.Size(39, 15);
            this.time1t.TabIndex = 11;
            this.time1t.Text = "..........";
            // 
            // time1m
            // 
            this.time1m.AutoSize = true;
            this.time1m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time1m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1m.Location = new System.Drawing.Point(82, 58);
            this.time1m.Name = "time1m";
            this.time1m.Size = new System.Drawing.Size(39, 15);
            this.time1m.TabIndex = 10;
            this.time1m.Text = "..........";
            // 
            // tt1
            // 
            this.tt1.AutoSize = true;
            this.tt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt1.Location = new System.Drawing.Point(172, 29);
            this.tt1.Name = "tt1";
            this.tt1.Size = new System.Drawing.Size(58, 15);
            this.tt1.TabIndex = 9;
            this.tt1.Text = "Chưa thuê";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "VND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giờ trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giờ lấy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "HỆ THỐNG CHO THUÊ XE THÔNG MINH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "--------------------------------------------------------------";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.day2t);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.day2m);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.t2);
            this.groupBox3.Controls.Add(this.time2t);
            this.groupBox3.Controls.Add(this.time2m);
            this.groupBox3.Controls.Add(this.tt2);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 158);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xe số 2";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(187, 127);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(16, 15);
            this.t2.TabIndex = 12;
            this.t2.Text = "0";
            // 
            // time2t
            // 
            this.time2t.AutoSize = true;
            this.time2t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time2t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2t.Location = new System.Drawing.Point(292, 58);
            this.time2t.Name = "time2t";
            this.time2t.Size = new System.Drawing.Size(39, 15);
            this.time2t.TabIndex = 11;
            this.time2t.Text = "..........";
            // 
            // time2m
            // 
            this.time2m.AutoSize = true;
            this.time2m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2m.Location = new System.Drawing.Point(82, 58);
            this.time2m.Name = "time2m";
            this.time2m.Size = new System.Drawing.Size(39, 15);
            this.time2m.TabIndex = 10;
            this.time2m.Text = "..........";
            // 
            // tt2
            // 
            this.tt2.AutoSize = true;
            this.tt2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt2.Location = new System.Drawing.Point(172, 29);
            this.tt2.Name = "tt2";
            this.tt2.Size = new System.Drawing.Size(58, 15);
            this.tt2.TabIndex = 9;
            this.tt2.Text = "Chưa thuê";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(269, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "VND";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(94, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Thành tiền:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(237, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Giờ trả:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Giờ lấy:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(97, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Trạng thái:";
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 360000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.checkBox10);
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkXe2);
            this.groupBox4.Controls.Add(this.checkXe1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(469, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 324);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trạng thái xe";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(114, 177);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(59, 20);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Xe 10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(114, 151);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(52, 20);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Xe 9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(114, 125);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(52, 20);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Xe 8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(114, 99);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(52, 20);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Xe 7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(114, 72);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(52, 20);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Xe 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(22, 176);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(52, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Xe 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(22, 150);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(52, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Xe 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(22, 124);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(52, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Xe 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkXe2
            // 
            this.checkXe2.AutoSize = true;
            this.checkXe2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXe2.Location = new System.Drawing.Point(22, 98);
            this.checkXe2.Name = "checkXe2";
            this.checkXe2.Size = new System.Drawing.Size(52, 20);
            this.checkXe2.TabIndex = 1;
            this.checkXe2.Text = "Xe 2";
            this.checkXe2.UseVisualStyleBackColor = true;
            // 
            // checkXe1
            // 
            this.checkXe1.AutoSize = true;
            this.checkXe1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXe1.Location = new System.Drawing.Point(22, 72);
            this.checkXe1.Name = "checkXe1";
            this.checkXe1.Size = new System.Drawing.Size(52, 20);
            this.checkXe1.TabIndex = 0;
            this.checkXe1.Text = "Xe 1";
            this.checkXe1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(7, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Đã thuê";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(101, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 20);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Chưa thuê";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngày: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ngày: ";
            // 
            // day1m
            // 
            this.day1m.AutoSize = true;
            this.day1m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.day1m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1m.Location = new System.Drawing.Point(82, 87);
            this.day1m.Name = "day1m";
            this.day1m.Size = new System.Drawing.Size(39, 15);
            this.day1m.TabIndex = 15;
            this.day1m.Text = "..........";
            // 
            // day1t
            // 
            this.day1t.AutoSize = true;
            this.day1t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.day1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1t.Location = new System.Drawing.Point(292, 87);
            this.day1t.Name = "day1t";
            this.day1t.Size = new System.Drawing.Size(39, 15);
            this.day1t.TabIndex = 16;
            this.day1t.Text = "..........";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ngày: ";
            // 
            // day2m
            // 
            this.day2m.AutoSize = true;
            this.day2m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.day2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2m.Location = new System.Drawing.Point(82, 86);
            this.day2m.Name = "day2m";
            this.day2m.Size = new System.Drawing.Size(39, 15);
            this.day2m.TabIndex = 14;
            this.day2m.Text = "..........";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(240, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Ngày: ";
            // 
            // day2t
            // 
            this.day2t.AutoSize = true;
            this.day2t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.day2t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2t.Location = new System.Drawing.Point(292, 88);
            this.day2t.Name = "day2t";
            this.day2t.Size = new System.Drawing.Size(39, 15);
            this.day2t.TabIndex = 16;
            this.day2t.Text = "..........";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quản lý thuê xe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxComList;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.Label time1t;
        private System.Windows.Forms.Label time1m;
        private System.Windows.Forms.Label tt1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label time2t;
        private System.Windows.Forms.Label time2m;
        private System.Windows.Forms.Label tt2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkXe2;
        private System.Windows.Forms.CheckBox checkXe1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label day1t;
        private System.Windows.Forms.Label day1m;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label day2t;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label day2m;
        private System.Windows.Forms.Label label13;
    }
}

