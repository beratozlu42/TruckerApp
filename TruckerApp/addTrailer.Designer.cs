namespace TruckerApp
{
    partial class addTrailer
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            linkLabel1 = new LinkLabel();
            addTrailerBtn = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            addTypeBtn = new Button();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            tabPage3 = new TabPage();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            button2 = new Button();
            tabPage4 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(27, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1140, 608);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(addTrailerBtn);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1132, 571);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ekle";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(464, 319);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(200, 36);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Aradiginiz Dorse Turu Burda Yoksa Yeni \r\nBir Tur Ekleyebilirsiniz.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // addTrailerBtn
            // 
            addTrailerBtn.BackColor = Color.SkyBlue;
            addTrailerBtn.FlatStyle = FlatStyle.Flat;
            addTrailerBtn.Location = new Point(661, 381);
            addTrailerBtn.Name = "addTrailerBtn";
            addTrailerBtn.Size = new Size(105, 45);
            addTrailerBtn.TabIndex = 4;
            addTrailerBtn.Text = "Ekle";
            addTrailerBtn.UseVisualStyleBackColor = false;
            addTrailerBtn.Click += addTrailerBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(464, 261);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 32);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 264);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 2;
            label3.Text = "Dorse Turu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 199);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 2;
            label2.Text = "Dorse Numarasi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 41);
            label1.Name = "label1";
            label1.Size = new Size(243, 53);
            label1.TabIndex = 1;
            label1.Text = "Yeni Dorse Ekle";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(464, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 32);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(addTypeBtn);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1132, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dorse Türü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 41);
            label4.Name = "label4";
            label4.Size = new Size(178, 53);
            label4.TabIndex = 0;
            label4.Text = "Dorse Türü";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(189, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 32);
            textBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 204);
            label5.Name = "label5";
            label5.Size = new Size(110, 24);
            label5.TabIndex = 2;
            label5.Text = "Yeni Dorse Türü";
            // 
            // addTypeBtn
            // 
            addTypeBtn.BackColor = Color.SkyBlue;
            addTypeBtn.FlatStyle = FlatStyle.Flat;
            addTypeBtn.Location = new Point(386, 265);
            addTypeBtn.Name = "addTypeBtn";
            addTypeBtn.Size = new Size(105, 45);
            addTypeBtn.TabIndex = 3;
            addTypeBtn.Text = "Ekle";
            addTypeBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(676, 174);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 2;
            label6.Text = "Dorse Seçiniz";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(676, 201);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(302, 32);
            comboBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(676, 264);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 3;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.WhiteSmoke;
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(comboBox3);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 33);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1132, 571);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Düzenle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(54, 41);
            label7.Name = "label7";
            label7.Size = new Size(230, 53);
            label7.TabIndex = 0;
            label7.Text = "Dorse Düzenle";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(464, 197);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(302, 32);
            comboBox3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 200);
            label8.Name = "label8";
            label8.Size = new Size(115, 24);
            label8.TabIndex = 2;
            label8.Text = "Dorse Numarası";
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(661, 282);
            button2.Name = "button2";
            button2.Size = new Size(105, 45);
            button2.TabIndex = 3;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 33);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1132, 571);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Dorseler";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1126, 494);
            dataGridView1.TabIndex = 0;
            // 
            // addTrailer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1190, 623);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addTrailer";
            Text = "addTrailer";
            Load += addTrailer_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Button addTrailerBtn;
        private LinkLabel linkLabel1;
        private Label label4;
        private TextBox textBox2;
        private Button addTypeBtn;
        private Label label5;
        private ComboBox comboBox2;
        private Button button1;
        private Label label6;
        private TabPage tabPage3;
        private Label label7;
        private Button button2;
        private Label label8;
        private ComboBox comboBox3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
    }
}