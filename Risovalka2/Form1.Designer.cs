namespace Risovalka2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.rbBrezenhem = new System.Windows.Forms.RadioButton();
            this.rbBrizenhemPlus = new System.Windows.Forms.RadioButton();
            this.rbCurveBize = new System.Windows.Forms.RadioButton();
            this.typesLine = new System.Windows.Forms.Panel();
            this.rbBizeN = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ddf1 = new System.Windows.Forms.TextBox();
            this.textBox_df1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dfn = new System.Windows.Forms.TextBox();
            this.textBox_ddfn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.typesLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(34, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 492);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(944, 15);
            this.txtArray.Margin = new System.Windows.Forms.Padding(4);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.ReadOnly = true;
            this.txtArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArray.Size = new System.Drawing.Size(171, 208);
            this.txtArray.TabIndex = 2;
            // 
            // rbBrezenhem
            // 
            this.rbBrezenhem.AutoSize = true;
            this.rbBrezenhem.Checked = true;
            this.rbBrezenhem.Location = new System.Drawing.Point(16, 13);
            this.rbBrezenhem.Name = "rbBrezenhem";
            this.rbBrezenhem.Size = new System.Drawing.Size(128, 20);
            this.rbBrezenhem.TabIndex = 3;
            this.rbBrezenhem.TabStop = true;
            this.rbBrezenhem.Text = "Обычная линия";
            this.rbBrezenhem.UseVisualStyleBackColor = true;
            // 
            // rbBrizenhemPlus
            // 
            this.rbBrizenhemPlus.AutoSize = true;
            this.rbBrizenhemPlus.Location = new System.Drawing.Point(16, 39);
            this.rbBrizenhemPlus.Name = "rbBrizenhemPlus";
            this.rbBrizenhemPlus.Size = new System.Drawing.Size(149, 20);
            this.rbBrizenhemPlus.TabIndex = 4;
            this.rbBrizenhemPlus.TabStop = true;
            this.rbBrizenhemPlus.Text = "Сглаженная линия";
            this.rbBrizenhemPlus.UseVisualStyleBackColor = true;
            // 
            // rbCurveBize
            // 
            this.rbCurveBize.AutoSize = true;
            this.rbCurveBize.Location = new System.Drawing.Point(16, 65);
            this.rbCurveBize.Name = "rbCurveBize";
            this.rbCurveBize.Size = new System.Drawing.Size(142, 20);
            this.rbCurveBize.TabIndex = 5;
            this.rbCurveBize.TabStop = true;
            this.rbCurveBize.Text = "Кривая 4 порядка";
            this.rbCurveBize.UseVisualStyleBackColor = true;
            // 
            // typesLine
            // 
            this.typesLine.Controls.Add(this.rbBizeN);
            this.typesLine.Controls.Add(this.rbBrezenhem);
            this.typesLine.Controls.Add(this.rbCurveBize);
            this.typesLine.Controls.Add(this.rbBrizenhemPlus);
            this.typesLine.Location = new System.Drawing.Point(944, 247);
            this.typesLine.Name = "typesLine";
            this.typesLine.Size = new System.Drawing.Size(171, 132);
            this.typesLine.TabIndex = 6;
            // 
            // rbBizeN
            // 
            this.rbBizeN.AutoSize = true;
            this.rbBizeN.Location = new System.Drawing.Point(16, 91);
            this.rbBizeN.Name = "rbBizeN";
            this.rbBizeN.Size = new System.Drawing.Size(142, 20);
            this.rbBizeN.TabIndex = 6;
            this.rbBizeN.TabStop = true;
            this.rbBizeN.Text = "Кривая n порядка";
            this.rbBizeN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(944, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отрисовка сплайна";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1050, 453);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(9, 40);
            this.vScrollBar1.Maximum = 5000;
            this.vScrollBar1.Minimum = -5000;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 492);
            this.vScrollBar1.TabIndex = 9;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(903, 40);
            this.vScrollBar2.Maximum = 5000;
            this.vScrollBar2.Minimum = -5000;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(20, 492);
            this.vScrollBar2.TabIndex = 10;
            this.vScrollBar2.ValueChanged += new System.EventHandler(this.vScrollBar2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ddf1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "df1";
            // 
            // textBox_ddf1
            // 
            this.textBox_ddf1.Location = new System.Drawing.Point(225, 7);
            this.textBox_ddf1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ddf1.Multiline = true;
            this.textBox_ddf1.Name = "textBox_ddf1";
            this.textBox_ddf1.Size = new System.Drawing.Size(69, 25);
            this.textBox_ddf1.TabIndex = 11;
            // 
            // textBox_df1
            // 
            this.textBox_df1.Location = new System.Drawing.Point(73, 7);
            this.textBox_df1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_df1.Multiline = true;
            this.textBox_df1.Name = "textBox_df1";
            this.textBox_df1.Size = new System.Drawing.Size(69, 25);
            this.textBox_df1.TabIndex = 12;
            this.textBox_df1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "dfn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ddfn";
            // 
            // textBox_dfn
            // 
            this.textBox_dfn.Location = new System.Drawing.Point(818, 7);
            this.textBox_dfn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dfn.Multiline = true;
            this.textBox_dfn.Name = "textBox_dfn";
            this.textBox_dfn.Size = new System.Drawing.Size(69, 25);
            this.textBox_dfn.TabIndex = 15;
            this.textBox_dfn.Text = "0";
            // 
            // textBox_ddfn
            // 
            this.textBox_ddfn.Location = new System.Drawing.Point(672, 6);
            this.textBox_ddfn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ddfn.Multiline = true;
            this.textBox_ddfn.Name = "textBox_ddfn";
            this.textBox_ddfn.Size = new System.Drawing.Size(69, 25);
            this.textBox_ddfn.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 545);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_dfn);
            this.Controls.Add(this.textBox_ddfn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ddf1);
            this.Controls.Add(this.textBox_df1);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typesLine);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.typesLine.ResumeLayout(false);
            this.typesLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.RadioButton rbBrezenhem;
        private System.Windows.Forms.RadioButton rbBrizenhemPlus;
        private System.Windows.Forms.RadioButton rbCurveBize;
        private System.Windows.Forms.Panel typesLine;
        private System.Windows.Forms.RadioButton rbBizeN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ddf1;
        private System.Windows.Forms.TextBox textBox_df1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dfn;
        private System.Windows.Forms.TextBox textBox_ddfn;
    }
}

