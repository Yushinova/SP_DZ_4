using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SP_DZ_4
{
    public partial class SetProgress : Form
    {
        int count = 0;
        Random random = new Random();
        List<System.Windows.Forms.ProgressBar> progressBars = new List<System.Windows.Forms.ProgressBar>();
      
        List<string> results = new List<string>();
        public SetProgress()
        {
            InitializeComponent();
        }
        public System.Windows.Forms.ProgressBar MyProgress(int i)//прогресс бар с заданными свойствами и рандомным шагом
        {
            System.Windows.Forms.ProgressBar newProgressBar = new System.Windows.Forms.ProgressBar();

            newProgressBar.Name = "Лошадь №" + (i + 1);
            newProgressBar.Location = new Point(100, 100 + (i * 50));
            newProgressBar.Minimum = 0;
            newProgressBar.Maximum = 100;
            newProgressBar.Step = random.Next(1, 10);
            newProgressBar.Height = 20;
            newProgressBar.Width = 600;

            return newProgressBar;
        }
        public Label MyLabel(int i)
        {
            Label newLabel = new Label();
            newLabel.Location = new Point(100, 70 + (i * 50));
            newLabel.Text = "Лошадь №" + i;
            return newLabel;
        }
        private void setButton_Click(object sender, EventArgs e)//установка прогресс баров
        {
            if(int.TryParse(CountHor.Text, out count))
            {
                count = int.Parse(CountHor.Text);
            }
            
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    System.Windows.Forms.ProgressBar temp = MyProgress(i);
                    Controls.Add(MyLabel(i + 1));
                    Controls.Add(temp);
                    progressBars.Add(temp);
                }
            }

        }
        public void Go(object bar)//заполнение прогресс бара
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Invoke(new Action(() => (bar as System.Windows.Forms.ProgressBar).PerformStep()));
                }
                catch(Exception ex) { }
                Thread.Sleep(500);
                if ((bar as System.Windows.Forms.ProgressBar).Value == 100)//когда достигнуто полное заполнение добавляем лошадь в результирующую таблицу
                {
                    count++;//номер потока
                    results.Add($"{count} место: " + (bar as System.Windows.Forms.ProgressBar).Name);

                    if (count == progressBars.Count)
                    {
                        Thread.Sleep(500);
                        Invoke(new Action(() => SetResult()));
                    }
                    Thread.CurrentThread.Abort();
                }
            }
        }
        private void SetResult()//установка результатов скачки
        {
            foreach (var item in results)
            {
                listRes.Items.Add(item);
            }
            listRes.Visible = true;
        }
        private void StartBut_Click(object sender, EventArgs e)//начало движения лошадок
        {
            count = 0;
            foreach (var item in progressBars)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(Go));
                thread.Start(item);
            }
            StartBut.Enabled = false;
        }

    
    }
}
