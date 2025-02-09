namespace MemoryGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.pb1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pb16 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb12 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb15 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb11 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb14 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb13 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpbTimer = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cpbScore = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart_Pause_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.cbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.cpbTimer.SuspendLayout();
            this.cpbScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(268, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Game";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb1.ImageRotate = 0F;
            this.pb1.Location = new System.Drawing.Point(9, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(133, 112);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.pb16);
            this.guna2Panel1.Controls.Add(this.pb12);
            this.guna2Panel1.Controls.Add(this.pb8);
            this.guna2Panel1.Controls.Add(this.pb4);
            this.guna2Panel1.Controls.Add(this.pb15);
            this.guna2Panel1.Controls.Add(this.pb11);
            this.guna2Panel1.Controls.Add(this.pb7);
            this.guna2Panel1.Controls.Add(this.pb3);
            this.guna2Panel1.Controls.Add(this.pb14);
            this.guna2Panel1.Controls.Add(this.pb10);
            this.guna2Panel1.Controls.Add(this.pb6);
            this.guna2Panel1.Controls.Add(this.pb2);
            this.guna2Panel1.Controls.Add(this.pb13);
            this.guna2Panel1.Controls.Add(this.pb9);
            this.guna2Panel1.Controls.Add(this.pb5);
            this.guna2Panel1.Controls.Add(this.pb1);
            this.guna2Panel1.Location = new System.Drawing.Point(215, 137);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(610, 509);
            this.guna2Panel1.TabIndex = 1;
            // 
            // pb16
            // 
            this.pb16.BackColor = System.Drawing.Color.Transparent;
            this.pb16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb16.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb16.ImageRotate = 0F;
            this.pb16.Location = new System.Drawing.Point(459, 384);
            this.pb16.Name = "pb16";
            this.pb16.Size = new System.Drawing.Size(133, 112);
            this.pb16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb16.TabIndex = 19;
            this.pb16.TabStop = false;
            this.pb16.Click += new System.EventHandler(this.pb16_Click);
            // 
            // pb12
            // 
            this.pb12.BackColor = System.Drawing.Color.Transparent;
            this.pb12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb12.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb12.ImageRotate = 0F;
            this.pb12.Location = new System.Drawing.Point(459, 260);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(133, 112);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb12.TabIndex = 18;
            this.pb12.TabStop = false;
            this.pb12.Click += new System.EventHandler(this.pb12_Click);
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Transparent;
            this.pb8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb8.ImageRotate = 0F;
            this.pb8.Location = new System.Drawing.Point(459, 136);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(133, 112);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 17;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb4.ImageRotate = 0F;
            this.pb4.Location = new System.Drawing.Point(459, 12);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(133, 112);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 16;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb15
            // 
            this.pb15.BackColor = System.Drawing.Color.Transparent;
            this.pb15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb15.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb15.ImageRotate = 0F;
            this.pb15.Location = new System.Drawing.Point(308, 384);
            this.pb15.Name = "pb15";
            this.pb15.Size = new System.Drawing.Size(133, 112);
            this.pb15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb15.TabIndex = 15;
            this.pb15.TabStop = false;
            this.pb15.Click += new System.EventHandler(this.pb15_Click);
            // 
            // pb11
            // 
            this.pb11.BackColor = System.Drawing.Color.Transparent;
            this.pb11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb11.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb11.ImageRotate = 0F;
            this.pb11.Location = new System.Drawing.Point(308, 260);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(133, 112);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb11.TabIndex = 14;
            this.pb11.TabStop = false;
            this.pb11.Click += new System.EventHandler(this.pb11_Click);
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Transparent;
            this.pb7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb7.ImageRotate = 0F;
            this.pb7.Location = new System.Drawing.Point(308, 136);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(133, 112);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 13;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.pb7_Click);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb3.ImageRotate = 0F;
            this.pb3.Location = new System.Drawing.Point(308, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(133, 112);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 12;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb14
            // 
            this.pb14.BackColor = System.Drawing.Color.Transparent;
            this.pb14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb14.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb14.ImageRotate = 0F;
            this.pb14.Location = new System.Drawing.Point(157, 384);
            this.pb14.Name = "pb14";
            this.pb14.Size = new System.Drawing.Size(133, 112);
            this.pb14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb14.TabIndex = 11;
            this.pb14.TabStop = false;
            this.pb14.Click += new System.EventHandler(this.pb14_Click);
            // 
            // pb10
            // 
            this.pb10.BackColor = System.Drawing.Color.Transparent;
            this.pb10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb10.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb10.ImageRotate = 0F;
            this.pb10.Location = new System.Drawing.Point(157, 260);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(133, 112);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb10.TabIndex = 10;
            this.pb10.TabStop = false;
            this.pb10.Click += new System.EventHandler(this.pb10_Click);
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb6.ImageRotate = 0F;
            this.pb6.Location = new System.Drawing.Point(157, 136);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(133, 112);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 9;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb6_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb2.ImageRotate = 0F;
            this.pb2.Location = new System.Drawing.Point(157, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(133, 112);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb13
            // 
            this.pb13.BackColor = System.Drawing.Color.Transparent;
            this.pb13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb13.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb13.ImageRotate = 0F;
            this.pb13.Location = new System.Drawing.Point(9, 384);
            this.pb13.Name = "pb13";
            this.pb13.Size = new System.Drawing.Size(133, 112);
            this.pb13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb13.TabIndex = 7;
            this.pb13.TabStop = false;
            this.pb13.Click += new System.EventHandler(this.pb13_Click);
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.Transparent;
            this.pb9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb9.ImageRotate = 0F;
            this.pb9.Location = new System.Drawing.Point(9, 260);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(133, 112);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 2;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.pb9_Click);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Transparent;
            this.pb5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::MemoryGame.Properties.Resources.question_mark_96;
            this.pb5.ImageRotate = 0F;
            this.pb5.Location = new System.Drawing.Point(9, 136);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(133, 112);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 1;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpbTimer
            // 
            this.cpbTimer.BackColor = System.Drawing.Color.Transparent;
            this.cpbTimer.Controls.Add(this.lblTimer);
            this.cpbTimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cpbTimer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpbTimer.ForeColor = System.Drawing.Color.White;
            this.cpbTimer.Location = new System.Drawing.Point(11, 53);
            this.cpbTimer.Minimum = 0;
            this.cpbTimer.Name = "cpbTimer";
            this.cpbTimer.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cpbTimer.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cpbTimer.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.cpbTimer.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.cpbTimer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbTimer.Size = new System.Drawing.Size(108, 108);
            this.cpbTimer.TabIndex = 2;
            this.cpbTimer.Text = "guna2CircleProgressBar1";
            this.cpbTimer.Value = 100;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Lime;
            this.lblTimer.Location = new System.Drawing.Point(30, 33);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(49, 37);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "50";
            // 
            // cpbScore
            // 
            this.cpbScore.BackColor = System.Drawing.Color.Transparent;
            this.cpbScore.Controls.Add(this.lblScore);
            this.cpbScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cpbScore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpbScore.ForeColor = System.Drawing.Color.White;
            this.cpbScore.Location = new System.Drawing.Point(926, 53);
            this.cpbScore.Maximum = 8;
            this.cpbScore.Minimum = 0;
            this.cpbScore.Name = "cpbScore";
            this.cpbScore.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.cpbScore.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.cpbScore.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbScore.Size = new System.Drawing.Size(108, 108);
            this.cpbScore.TabIndex = 3;
            this.cpbScore.Text = "guna2CircleProgressBar2";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblScore.Location = new System.Drawing.Point(25, 33);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 37);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0/8";
            // 
            // btnStart_Pause_Reset
            // 
            this.btnStart_Pause_Reset.Animated = true;
            this.btnStart_Pause_Reset.AutoRoundedCorners = true;
            this.btnStart_Pause_Reset.BackColor = System.Drawing.Color.Transparent;
            this.btnStart_Pause_Reset.BorderRadius = 19;
            this.btnStart_Pause_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart_Pause_Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart_Pause_Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart_Pause_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart_Pause_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart_Pause_Reset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart_Pause_Reset.ForeColor = System.Drawing.Color.White;
            this.btnStart_Pause_Reset.Location = new System.Drawing.Point(443, 675);
            this.btnStart_Pause_Reset.Name = "btnStart_Pause_Reset";
            this.btnStart_Pause_Reset.Size = new System.Drawing.Size(138, 41);
            this.btnStart_Pause_Reset.TabIndex = 4;
            this.btnStart_Pause_Reset.Text = "Playing";
            this.guna2HtmlToolTip1.SetToolTip(this.btnStart_Pause_Reset, "Press To Playing");
            this.btnStart_Pause_Reset.UseTransparentBackground = true;
            this.btnStart_Pause_Reset.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(939, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Left";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // cbLevel
            // 
            this.cbLevel.AutoRoundedCorners = true;
            this.cbLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbLevel.BorderRadius = 17;
            this.cbLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLevel.ItemHeight = 30;
            this.cbLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Very Hard"});
            this.cbLevel.Location = new System.Drawing.Point(11, 434);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(135, 36);
            this.cbLevel.TabIndex = 7;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(43, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Level";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(936, 164);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 45);
            this.lblResult.TabIndex = 9;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.IsBalloon = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 744);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart_Pause_Reset);
            this.Controls.Add(this.cpbScore);
            this.Controls.Add(this.cpbTimer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.cpbTimer.ResumeLayout(false);
            this.cpbTimer.PerformLayout();
            this.cpbScore.ResumeLayout(false);
            this.cpbScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pb1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pb16;
        private Guna.UI2.WinForms.Guna2PictureBox pb12;
        private Guna.UI2.WinForms.Guna2PictureBox pb8;
        private Guna.UI2.WinForms.Guna2PictureBox pb4;
        private Guna.UI2.WinForms.Guna2PictureBox pb15;
        private Guna.UI2.WinForms.Guna2PictureBox pb11;
        private Guna.UI2.WinForms.Guna2PictureBox pb7;
        private Guna.UI2.WinForms.Guna2PictureBox pb3;
        private Guna.UI2.WinForms.Guna2PictureBox pb14;
        private Guna.UI2.WinForms.Guna2PictureBox pb10;
        private Guna.UI2.WinForms.Guna2PictureBox pb6;
        private Guna.UI2.WinForms.Guna2PictureBox pb2;
        private Guna.UI2.WinForms.Guna2PictureBox pb13;
        private Guna.UI2.WinForms.Guna2PictureBox pb9;
        private Guna.UI2.WinForms.Guna2PictureBox pb5;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbTimer;
        private System.Windows.Forms.Label lblTimer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbScore;
        private Guna.UI2.WinForms.Guna2Button btnStart_Pause_Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.Label lblScore;
        private Guna.UI2.WinForms.Guna2ComboBox cbLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
    }
}

