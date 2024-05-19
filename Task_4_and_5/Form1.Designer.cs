namespace Task_4_and_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.FindWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.FindFolderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ListRes = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите слово для поиска:";
            // 
            // FindWord
            // 
            this.FindWord.Location = new System.Drawing.Point(262, 49);
            this.FindWord.Name = "FindWord";
            this.FindWord.Size = new System.Drawing.Size(185, 20);
            this.FindWord.TabIndex = 1;
            this.FindWord.Text = "Карл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь к файлу:";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(101, 89);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(570, 20);
            this.FilePath.TabIndex = 3;
            this.FilePath.Text = "C:\\Users\\User\\source\\repos\\SP_DZ_4\\Task_4_and_5\\FindFile.txt";
            // 
            // FolderPath
            // 
            this.FolderPath.Location = new System.Drawing.Point(101, 192);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(570, 20);
            this.FolderPath.TabIndex = 4;
            this.FolderPath.Text = "C:\\Users\\User\\source\\repos\\SP_DZ_4\\Task_4_and_5\\FindWordFolder\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Путь к папке:";
            // 
            // FindFileButton
            // 
            this.FindFileButton.Location = new System.Drawing.Point(698, 87);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(75, 23);
            this.FindFileButton.TabIndex = 6;
            this.FindFileButton.Text = "ПОИСК";
            this.FindFileButton.UseVisualStyleBackColor = true;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // FindFolderButton
            // 
            this.FindFolderButton.Location = new System.Drawing.Point(698, 189);
            this.FindFolderButton.Name = "FindFolderButton";
            this.FindFolderButton.Size = new System.Drawing.Size(75, 23);
            this.FindFolderButton.TabIndex = 7;
            this.FindFolderButton.Text = "ПОИСК";
            this.FindFolderButton.UseVisualStyleBackColor = true;
            this.FindFolderButton.Click += new System.EventHandler(this.FindFolderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество слов:";
            // 
            // ResultFile
            // 
            this.ResultFile.Location = new System.Drawing.Point(364, 133);
            this.ResultFile.Name = "ResultFile";
            this.ResultFile.Size = new System.Drawing.Size(100, 20);
            this.ResultFile.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отчет:";
            // 
            // ListRes
            // 
            this.ListRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Path,
            this.FileCount});
            this.ListRes.HideSelection = false;
            this.ListRes.Location = new System.Drawing.Point(21, 266);
            this.ListRes.Name = "ListRes";
            this.ListRes.Size = new System.Drawing.Size(752, 172);
            this.ListRes.TabIndex = 11;
            this.ListRes.UseCompatibleStateImageBehavior = false;
            this.ListRes.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "Имя файла";
            this.FileName.Width = 150;
            // 
            // Path
            // 
            this.Path.Text = "Путь к файлу";
            this.Path.Width = 400;
            // 
            // FileCount
            // 
            this.FileCount.Text = "Количество";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FindFolderButton);
            this.Controls.Add(this.FindFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FindWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.Button FindFolderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView ListRes;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader FileCount;
    }
}

