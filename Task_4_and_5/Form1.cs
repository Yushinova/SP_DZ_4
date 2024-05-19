using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_and_5
{
    public partial class Form1 : Form
    {
        public string File_path;
        public string Folder_path;
        public string Word;
        public int count = 0;
        public List<string> List_res = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private async void FindFileButton_Click(object sender, EventArgs e)//поиск в файле
        {
            Word = FindWord.Text;
            File_path = FilePath.Text;
            await Task.Run(() => FindFile(File_path));
            ResultFile.Text = count.ToString();
        }

        private int FindFile(string path)//возвращает количество вхождений
        {
           count = 0;
            try
            {
                string text = String.Empty;
                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    text = reader.ReadToEnd();
                    Console.WriteLine(text);
                }
                if (text != String.Empty)
                {
                    string[] abs = text.Trim().Split(' ', '.', ',', '\n');
                    foreach (var item in abs)
                    {
                        //Console.WriteLine(item);
                        if (item == Word) count++;
                    }
                }
                return count;
            }
           catch (Exception ex) { return 0; }
        }

        private async void FindFolderButton_Click(object sender, EventArgs e)//поиск в папке
        {
            Word = FindWord.Text;
            Folder_path = FolderPath.Text;
            await Task.Run(() => FindFolder());

        }
        private async Task FindFolder()//поиск в папке и подпапках
        {
            int count2 = 0;
            try
            {
                List_res = Directory.GetFiles(Folder_path, "*.txt", SearchOption.AllDirectories).ToList();
                foreach (var item in List_res)
                {
                    count2 = await Task.Run(() => FindFile(item));
                    Invoke(new Action(() => ListRes.Items.Add(System.IO.Path.GetFileName(item)).SubItems.AddRange(new[] { item, count2.ToString() })));

                }
            }
           catch (Exception ex) { }
        }

    }
}
