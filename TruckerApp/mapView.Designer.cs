namespace TruckerApp
{
    partial class mapView
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
            topNavbar = new Panel();
            exitBtn = new Button();
            label1 = new Label();
            Navbar = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            searchBtn = new Button();
            comboBox1 = new ComboBox();
            screen = new Panel();
            topNavbar.SuspendLayout();
            Navbar.SuspendLayout();
            SuspendLayout();
            // 
            // topNavbar
            // 
            topNavbar.BackColor = Color.DimGray;
            topNavbar.Controls.Add(exitBtn);
            topNavbar.Controls.Add(label1);
            topNavbar.Dock = DockStyle.Top;
            topNavbar.Location = new Point(0, 0);
            topNavbar.Name = "topNavbar";
            topNavbar.Size = new Size(1255, 31);
            topNavbar.TabIndex = 0;
            topNavbar.MouseDown += topNavbar_MouseDown;
            topNavbar.MouseMove += topNavbar_MouseMove;
            topNavbar.MouseUp += topNavbar_MouseUp;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.IndianRed;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(1207, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(48, 29);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "HARITA";
            // 
            // Navbar
            // 
            Navbar.BackColor = Color.WhiteSmoke;
            Navbar.Controls.Add(textBox2);
            Navbar.Controls.Add(textBox1);
            Navbar.Controls.Add(button2);
            Navbar.Controls.Add(button1);
            Navbar.Controls.Add(label2);
            Navbar.Controls.Add(searchBtn);
            Navbar.Controls.Add(comboBox1);
            Navbar.Dock = DockStyle.Top;
            Navbar.Location = new Point(0, 31);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(1255, 79);
            Navbar.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(672, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(672, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(1084, 34);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "get routa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(967, 34);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "add routa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 10);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 2;
            label2.Text = "Nakliyat Numarasi";
            // 
            // searchBtn
            // 
            searchBtn.BackgroundImage = Properties.Resources.SEARCH_ICON;
            searchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Location = new Point(340, 41);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(35, 32);
            searchBtn.TabIndex = 1;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 32);
            comboBox1.TabIndex = 0;
            // 
            // screen
            // 
            screen.Dock = DockStyle.Fill;
            screen.Location = new Point(0, 110);
            screen.Name = "screen";
            screen.Size = new Size(1255, 678);
            screen.TabIndex = 2;
            // 
            // mapView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1255, 788);
            Controls.Add(screen);
            Controls.Add(Navbar);
            Controls.Add(topNavbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mapView";
            Text = "mapView";
            Load += mapView_Load;
            topNavbar.ResumeLayout(false);
            topNavbar.PerformLayout();
            Navbar.ResumeLayout(false);
            Navbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topNavbar;
        private Panel Navbar;
        private Label label1;
        private Button searchBtn;
        private ComboBox comboBox1;
        private Button exitBtn;
        private Panel screen;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}