namespace SP_DZ_4
{
    partial class SetProgress
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
            this.label1 = new System.Windows.Forms.Label();
            this.CountHor = new System.Windows.Forms.TextBox();
            this.StartBut = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.Fin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listRes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество лошадок";
            // 
            // CountHor
            // 
            this.CountHor.Location = new System.Drawing.Point(410, 21);
            this.CountHor.Name = "CountHor";
            this.CountHor.Size = new System.Drawing.Size(100, 20);
            this.CountHor.TabIndex = 1;
            // 
            // StartBut
            // 
            this.StartBut.Location = new System.Drawing.Point(325, 375);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(139, 37);
            this.StartBut.TabIndex = 2;
            this.StartBut.Text = "START";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(535, 19);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 3;
            this.setButton.Text = "Установить";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // Fin
            // 
            this.Fin.AutoSize = true;
            this.Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fin.Location = new System.Drawing.Point(550, 375);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(0, 24);
            this.Fin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результаты:";
            // 
            // listRes
            // 
            this.listRes.HideSelection = false;
            this.listRes.Location = new System.Drawing.Point(611, 341);
            this.listRes.Name = "listRes";
            this.listRes.Size = new System.Drawing.Size(171, 97);
            this.listRes.TabIndex = 7;
            this.listRes.UseCompatibleStateImageBehavior = false;
            this.listRes.View = System.Windows.Forms.View.List;
            this.listRes.Visible = false;
            // 
            // SetProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.CountHor);
            this.Controls.Add(this.label1);
            this.Name = "SetProgress";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountHor;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label Fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listRes;
    }
}

