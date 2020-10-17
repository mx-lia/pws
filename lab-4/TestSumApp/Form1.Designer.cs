namespace TestSumApp
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
            this.k1 = new System.Windows.Forms.NumericUpDown();
            this.k2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.s1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.TextBox();
            this.k = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.k1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k2)).BeginInit();
            this.SuspendLayout();
            // 
            // k1
            // 
            this.k1.Location = new System.Drawing.Point(12, 54);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(120, 22);
            this.k1.TabIndex = 0;
            // 
            // k2
            // 
            this.k2.Location = new System.Drawing.Point(160, 54);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(120, 22);
            this.k2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(369, 86);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(0, 17);
            this.s.TabIndex = 4;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(296, 83);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(46, 23);
            this.calc.TabIndex = 5;
            this.calc.Text = "=";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(12, 83);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(120, 22);
            this.s1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(160, 83);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(120, 22);
            this.s2.TabIndex = 8;
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(369, 56);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(0, 17);
            this.k.TabIndex = 10;
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(160, 111);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(120, 22);
            this.f2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "+";
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(12, 111);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(120, 22);
            this.f1.TabIndex = 11;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(369, 111);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(0, 17);
            this.f.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 172);
            this.Controls.Add(this.f);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.k);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.k1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.k1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown k1;
        private System.Windows.Forms.NumericUpDown k2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.Label k;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.Label f;
    }
}

