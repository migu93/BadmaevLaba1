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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.typesLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(879, 16);
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
            this.typesLine.Location = new System.Drawing.Point(879, 248);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
    }
}

