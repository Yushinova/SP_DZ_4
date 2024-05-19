namespace Task_3
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
            this.MaxCount = new System.Windows.Forms.TextBox();
            this.MinCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultFib = new System.Windows.Forms.TextBox();
            this.ProgressFib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MaxCount
            // 
            this.MaxCount.Location = new System.Drawing.Point(162, 50);
            this.MaxCount.Name = "MaxCount";
            this.MaxCount.Size = new System.Drawing.Size(100, 20);
            this.MaxCount.TabIndex = 0;
            // 
            // MinCount
            // 
            this.MinCount.Location = new System.Drawing.Point(64, 50);
            this.MinCount.Name = "MinCount";
            this.MinCount.ReadOnly = true;
            this.MinCount.Size = new System.Drawing.Size(39, 20);
            this.MinCount.TabIndex = 1;
            this.MinCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите числа Фибоначчи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MAX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ВСЕГО ЧИСЕЛ:";
            // 
            // ResultFib
            // 
            this.ResultFib.Location = new System.Drawing.Point(162, 102);
            this.ResultFib.Name = "ResultFib";
            this.ResultFib.ReadOnly = true;
            this.ResultFib.Size = new System.Drawing.Size(100, 20);
            this.ResultFib.TabIndex = 7;
            // 
            // ProgressFib
            // 
            this.ProgressFib.Location = new System.Drawing.Point(425, 49);
            this.ProgressFib.Name = "ProgressFib";
            this.ProgressFib.ReadOnly = true;
            this.ProgressFib.Size = new System.Drawing.Size(95, 20);
            this.ProgressFib.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 280);
            this.Controls.Add(this.ProgressFib);
            this.Controls.Add(this.ResultFib);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinCount);
            this.Controls.Add(this.MaxCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaxCount;
        private System.Windows.Forms.TextBox MinCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultFib;
        private System.Windows.Forms.TextBox ProgressFib;
    }
}

