namespace TruckerApp
{
    partial class root
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topNavbar = new Panel();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            button1 = new Button();
            exitBtn = new Button();
            navbar = new Panel();
            mapViewButton = new Button();
            trackBtn = new Button();
            forDriversBtn = new Button();
            addTrailerBtn = new Button();
            addTruckBtn = new Button();
            addDriverBtn = new Button();
            screen = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label12 = new Label();
            loginBtn = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label13 = new Label();
            linkLabel2 = new LinkLabel();
            registerBtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            topNavbar.SuspendLayout();
            navbar.SuspendLayout();
            screen.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // topNavbar
            // 
            topNavbar.BackColor = Color.DimGray;
            topNavbar.BorderStyle = BorderStyle.FixedSingle;
            topNavbar.Controls.Add(label10);
            topNavbar.Controls.Add(label11);
            topNavbar.Controls.Add(label9);
            topNavbar.Controls.Add(button1);
            topNavbar.Controls.Add(exitBtn);
            topNavbar.Dock = DockStyle.Top;
            topNavbar.Location = new Point(0, 0);
            topNavbar.Name = "topNavbar";
            topNavbar.Size = new Size(1190, 31);
            topNavbar.TabIndex = 0;
            topNavbar.MouseDown += topNavbar_MouseDown;
            topNavbar.MouseMove += topNavbar_MouseMove;
            topNavbar.MouseUp += topNavbar_MouseUp;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(105, 2);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(101, 2);
            label11.Name = "label11";
            label11.Size = new Size(18, 25);
            label11.TabIndex = 2;
            label11.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(3, 5);
            label9.Name = "label9";
            label9.Size = new Size(102, 22);
            label9.TabIndex = 2;
            label9.Text = "TRUCKERAPP";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1092, 0);
            button1.Name = "button1";
            button1.Size = new Size(48, 29);
            button1.TabIndex = 1;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.IndianRed;
            exitBtn.Dock = DockStyle.Right;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(1140, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(48, 29);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // navbar
            // 
            navbar.BackColor = Color.Gray;
            navbar.Controls.Add(mapViewButton);
            navbar.Controls.Add(trackBtn);
            navbar.Controls.Add(forDriversBtn);
            navbar.Controls.Add(addTrailerBtn);
            navbar.Controls.Add(addTruckBtn);
            navbar.Controls.Add(addDriverBtn);
            navbar.Dock = DockStyle.Top;
            navbar.Enabled = false;
            navbar.ForeColor = SystemColors.ActiveCaptionText;
            navbar.Location = new Point(0, 31);
            navbar.Name = "navbar";
            navbar.Size = new Size(1190, 65);
            navbar.TabIndex = 1;
            // 
            // mapViewButton
            // 
            mapViewButton.BackColor = SystemColors.Menu;
            mapViewButton.Cursor = Cursors.Hand;
            mapViewButton.Dock = DockStyle.Left;
            mapViewButton.FlatStyle = FlatStyle.Flat;
            mapViewButton.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            mapViewButton.Location = new Point(793, 0);
            mapViewButton.Name = "mapViewButton";
            mapViewButton.Size = new Size(199, 65);
            mapViewButton.TabIndex = 6;
            mapViewButton.Text = "HARİTA GÖRÜNÜMÜ";
            mapViewButton.UseVisualStyleBackColor = false;
            mapViewButton.Click += mapViewButton_Click;
            // 
            // trackBtn
            // 
            trackBtn.BackColor = SystemColors.Menu;
            trackBtn.Cursor = Cursors.Hand;
            trackBtn.Dock = DockStyle.Left;
            trackBtn.FlatStyle = FlatStyle.Flat;
            trackBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            trackBtn.Location = new Point(594, 0);
            trackBtn.Name = "trackBtn";
            trackBtn.Size = new Size(199, 65);
            trackBtn.TabIndex = 5;
            trackBtn.Text = "NAKLİYAT TAKİP";
            trackBtn.UseVisualStyleBackColor = false;
            trackBtn.Click += trackBtn_Click;
            // 
            // forDriversBtn
            // 
            forDriversBtn.BackColor = SystemColors.Menu;
            forDriversBtn.Cursor = Cursors.Hand;
            forDriversBtn.Dock = DockStyle.Right;
            forDriversBtn.FlatStyle = FlatStyle.Flat;
            forDriversBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            forDriversBtn.Location = new Point(992, 0);
            forDriversBtn.Name = "forDriversBtn";
            forDriversBtn.Size = new Size(198, 65);
            forDriversBtn.TabIndex = 4;
            forDriversBtn.Text = "SÜRÜCÜ İŞLEMLERİ";
            forDriversBtn.UseVisualStyleBackColor = false;
            forDriversBtn.Click += forDriversBtn_Click;
            // 
            // addTrailerBtn
            // 
            addTrailerBtn.BackColor = SystemColors.Menu;
            addTrailerBtn.Cursor = Cursors.Hand;
            addTrailerBtn.Dock = DockStyle.Left;
            addTrailerBtn.FlatStyle = FlatStyle.Flat;
            addTrailerBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addTrailerBtn.ForeColor = SystemColors.ActiveCaptionText;
            addTrailerBtn.Location = new Point(396, 0);
            addTrailerBtn.Name = "addTrailerBtn";
            addTrailerBtn.Size = new Size(198, 65);
            addTrailerBtn.TabIndex = 2;
            addTrailerBtn.Text = "DORSELER";
            addTrailerBtn.UseVisualStyleBackColor = false;
            addTrailerBtn.Click += addTrailerBtn_Click;
            // 
            // addTruckBtn
            // 
            addTruckBtn.BackColor = SystemColors.Menu;
            addTruckBtn.Cursor = Cursors.Hand;
            addTruckBtn.Dock = DockStyle.Left;
            addTruckBtn.FlatStyle = FlatStyle.Flat;
            addTruckBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addTruckBtn.ForeColor = SystemColors.ActiveCaptionText;
            addTruckBtn.Location = new Point(198, 0);
            addTruckBtn.Name = "addTruckBtn";
            addTruckBtn.Size = new Size(198, 65);
            addTruckBtn.TabIndex = 1;
            addTruckBtn.Text = "ÇEKİCİLER";
            addTruckBtn.UseVisualStyleBackColor = false;
            addTruckBtn.Click += addTruckBtn_Click;
            // 
            // addDriverBtn
            // 
            addDriverBtn.BackColor = SystemColors.Menu;
            addDriverBtn.Cursor = Cursors.Hand;
            addDriverBtn.Dock = DockStyle.Left;
            addDriverBtn.FlatStyle = FlatStyle.Flat;
            addDriverBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addDriverBtn.ForeColor = SystemColors.ControlText;
            addDriverBtn.Location = new Point(0, 0);
            addDriverBtn.Name = "addDriverBtn";
            addDriverBtn.Size = new Size(198, 65);
            addDriverBtn.TabIndex = 0;
            addDriverBtn.Text = "SÜRÜCÜLER\r\n";
            addDriverBtn.UseVisualStyleBackColor = false;
            addDriverBtn.Click += addDriverBtn_Click;
            // 
            // screen
            // 
            screen.BackColor = Color.DimGray;
            screen.BorderStyle = BorderStyle.FixedSingle;
            screen.Controls.Add(panel1);
            screen.Controls.Add(tabControl1);
            screen.Dock = DockStyle.Fill;
            screen.Location = new Point(0, 96);
            screen.Name = "screen";
            screen.Size = new Size(1190, 623);
            screen.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(42, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 613);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 148);
            label8.Name = "label8";
            label8.Size = new Size(347, 75);
            label8.TabIndex = 1;
            label8.Text = "TRUCKERAPP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 248);
            label3.Name = "label3";
            label3.Size = new Size(576, 123);
            label3.TabIndex = 0;
            label3.Text = "TruckerApp Uygulamamiza Hosgeldiniz.\r\nUygulamamizi kullanabilmek icin giris yapmaniz \r\ngerekmektedir\r\n";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(676, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(464, 613);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.MintCream;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(loginBtn);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Cursor = Cursors.Hand;
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(456, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Giris";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(20, 25);
            label12.Name = "label12";
            label12.Size = new Size(105, 57);
            label12.TabIndex = 5;
            label12.Text = "GIRIS";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Aquamarine;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(272, 359);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(112, 48);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Giris Yap";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(120, 481);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(225, 16);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Hesabiniz Yoksa Bir Hesap Olusturun";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(78, 239);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 1;
            label2.Text = "Sifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(78, 138);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 1;
            label1.Text = "Kullanici Adi";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(78, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 32);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(78, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 32);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.MintCream;
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(registerBtn);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Cursor = Cursors.Hand;
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(456, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Hesap Olustur";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(20, 25);
            label13.Name = "label13";
            label13.Size = new Size(108, 57);
            label13.TabIndex = 6;
            label13.Text = "KAYIT";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(81, 485);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(161, 32);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Zaten bir hesabiniz var mi?\r\nGiris Yapiniz\r\n";
            linkLabel2.TextAlign = ContentAlignment.TopCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.CornflowerBlue;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.ForeColor = SystemColors.ButtonHighlight;
            registerBtn.Location = new Point(275, 469);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(112, 48);
            registerBtn.TabIndex = 2;
            registerBtn.Text = "Kayit Ol";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 363);
            label7.Name = "label7";
            label7.Size = new Size(112, 28);
            label7.TabIndex = 1;
            label7.Text = "Sifre (Tekrar)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 272);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 1;
            label6.Text = "Sifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 193);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 1;
            label5.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 108);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 1;
            label4.Text = "Kullanici Adi";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(81, 394);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(306, 32);
            textBox6.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(81, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(306, 32);
            textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(81, 303);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(306, 32);
            textBox5.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(81, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 32);
            textBox3.TabIndex = 0;
            // 
            // root
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 719);
            Controls.Add(screen);
            Controls.Add(navbar);
            Controls.Add(topNavbar);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "root";
            Text = "Form1";
            Load += root_Load;
            topNavbar.ResumeLayout(false);
            topNavbar.PerformLayout();
            navbar.ResumeLayout(false);
            screen.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topNavbar;
        private Button exitBtn;
        private Button button1;
        public Button addDriverBtn;
        public Button addTrailerBtn;
        public Button addTruckBtn;
        public Panel screen;
        public Panel navbar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        public TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
        private Button loginBtn;
        private Button registerBtn;
        private LinkLabel linkLabel2;
        private Label label8;
        private Button forDriversBtn;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button trackBtn;
        private Button mapViewButton;
        private Label label12;
        private Label label13;
    }
}