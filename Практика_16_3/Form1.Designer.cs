namespace Практика_16_3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn2 = new System.Windows.Forms.RadioButton();
            this.Btn8 = new System.Windows.Forms.RadioButton();
            this.Btn16 = new System.Windows.Forms.RadioButton();
            this.BtnDo = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Полученное число";
            // 
            // Btn2
            // 
            this.Btn2.AutoSize = true;
            this.Btn2.Location = new System.Drawing.Point(459, 32);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(37, 21);
            this.Btn2.TabIndex = 4;
            this.Btn2.TabStop = true;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.AutoSize = true;
            this.Btn8.Location = new System.Drawing.Point(459, 56);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(37, 21);
            this.Btn8.TabIndex = 5;
            this.Btn8.TabStop = true;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // Btn16
            // 
            this.Btn16.AutoSize = true;
            this.Btn16.Location = new System.Drawing.Point(459, 81);
            this.Btn16.Name = "Btn16";
            this.Btn16.Size = new System.Drawing.Size(45, 21);
            this.Btn16.TabIndex = 6;
            this.Btn16.TabStop = true;
            this.Btn16.Text = "16";
            this.Btn16.UseVisualStyleBackColor = true;
            // 
            // BtnDo
            // 
            this.BtnDo.Location = new System.Drawing.Point(183, 131);
            this.BtnDo.Name = "BtnDo";
            this.BtnDo.Size = new System.Drawing.Size(75, 23);
            this.BtnDo.TabIndex = 7;
            this.BtnDo.Text = "Do";
            this.BtnDo.UseVisualStyleBackColor = true;
            this.BtnDo.Click += new System.EventHandler(this.BtnDo_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(299, 131);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 188);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDo);
            this.Controls.Add(this.Btn16);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Перевод десятичного числа в различные системы счисления";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Btn2;
        private System.Windows.Forms.RadioButton Btn8;
        private System.Windows.Forms.RadioButton Btn16;
        private System.Windows.Forms.Button BtnDo;
        private System.Windows.Forms.Button BtnExit;
    }
}

