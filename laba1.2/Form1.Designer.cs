namespace laba1._2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eraser = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NightShift = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Menu;
            this.close.Location = new System.Drawing.Point(1483, 58);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(150, 46);
            this.close.TabIndex = 0;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.kryg_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(1256, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.SystemColors.Menu;
            this.eraser.Location = new System.Drawing.Point(1483, 141);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(150, 74);
            this.eraser.TabIndex = 2;
            this.eraser.Text = "Стереть";
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Items.AddRange(new object[] {
            "Это лучшая лабораторная работа",
            "Хорошая  лабораторной",
            "Ну очень средняя лаба",
            "Совсем все плохо у тебя "});
            this.listBox1.Location = new System.Drawing.Point(1328, 669);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 132);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1328, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "список моих \r\nвозможных оценок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(1328, 826);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 36);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 56);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // NightShift
            // 
            this.NightShift.AutoSize = true;
            this.NightShift.Location = new System.Drawing.Point(1270, 64);
            this.NightShift.Name = "NightShift";
            this.NightShift.Size = new System.Drawing.Size(186, 36);
            this.NightShift.TabIndex = 7;
            this.NightShift.Text = "Темная тема";
            this.NightShift.UseVisualStyleBackColor = true;
            this.NightShift.CheckedChanged += new System.EventHandler(this.NightShift_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(109, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Как ваше настроение";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(109, 159);
            this.hScrollBar1.Maximum = 105;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(252, 56);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1671, 974);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NightShift);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.close);
            this.Name = "Form1";
            this.Text = "Лаба";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button close;
        private TextBox textBox1;
        private Button eraser;
        private ListBox listBox1;
        private Label label1;
        private TextBox textBox2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private CheckBox NightShift;
        private Label label2;
        private HScrollBar hScrollBar1;
        private LinkLabel linkLabel1;
    }
}