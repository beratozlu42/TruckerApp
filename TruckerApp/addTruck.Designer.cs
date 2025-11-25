namespace TruckerApp
{
    partial class addTruck
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
            pictureBox1 = new PictureBox();
            addBtn = new Button();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            duzenleBtn = new Button();
            deleteBtn = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(26, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1140, 608);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(addBtn);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1132, 571);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ekle";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(672, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.ActiveCaption;
            addBtn.FlatStyle = FlatStyle.Popup;
            addBtn.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(434, 370);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(105, 45);
            addBtn.TabIndex = 5;
            addBtn.Text = "Ekle";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Control;
            comboBox2.DropDownHeight = 150;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.IntegralHeight = false;
            comboBox2.Location = new Point(277, 294);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(262, 32);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(277, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 32);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(277, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 32);
            textBox1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(153, 299);
            label7.Name = "label7";
            label7.Size = new Size(106, 24);
            label7.TabIndex = 1;
            label7.Text = "Cekici Markasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(153, 235);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 1;
            label3.Text = "Cekici Plakasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(172, 174);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 1;
            label2.Text = "Cekici Ismi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 41);
            label1.Name = "label1";
            label1.Size = new Size(182, 53);
            label1.TabIndex = 0;
            label1.Text = "Cekici Ekle";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(duzenleBtn);
            tabPage2.Controls.Add(deleteBtn);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1132, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Duzenle";
            // 
            // duzenleBtn
            // 
            duzenleBtn.BackColor = SystemColors.ActiveCaption;
            duzenleBtn.FlatStyle = FlatStyle.Popup;
            duzenleBtn.Location = new Point(383, 307);
            duzenleBtn.Name = "duzenleBtn";
            duzenleBtn.Size = new Size(105, 45);
            duzenleBtn.TabIndex = 8;
            duzenleBtn.Text = "Duzenle";
            duzenleBtn.UseVisualStyleBackColor = false;
            duzenleBtn.Click += duzenleBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.IndianRed;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Location = new Point(540, 307);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(105, 45);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Sil";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(774, 253);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(127, 28);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Marka Degistir";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(774, 219);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(124, 28);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Plaka Degistir";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(774, 185);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(114, 28);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Isim Degistir";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 223);
            label6.Name = "label6";
            label6.Size = new Size(132, 24);
            label6.TabIndex = 3;
            label6.Text = "Cekicinin Yeni Ismi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 161);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 3;
            label5.Text = "Cekici Ismi";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(383, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 32);
            comboBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(383, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 32);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 41);
            label4.Name = "label4";
            label4.Size = new Size(235, 53);
            label4.TabIndex = 0;
            label4.Text = "Cekici Duzenle";
            // 
            // addTruck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1190, 623);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addTruck";
            Text = "addTruck";
            Load += addTruck_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button addBtn;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private RadioButton radioButton3;
        private Button deleteBtn;
        private Button duzenleBtn;
    }
}