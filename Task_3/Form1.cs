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

namespace Task_3
{
    public partial class Form1 : Form
    {
        public int count;
        public int Max_count;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Start_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(MaxCount.Text, out Max_count))
            {
                Max_count = int.Parse(MaxCount.Text);
            }
            await Task.Run(() => GoFib());
            ResultFib.Text = count.ToString();
        }
     
        private async Task GoFib()//поиск и вывод чисел фибоначчи
        {
            int a = 0, b = 1, c = 0;

            while (a <= Max_count)
            {
                Invoke(new Action(() => ProgressFib.Text = a.ToString()));
                count++;
                a = b + a;
                b = c;
                c = a;
                await Task.Delay(1000);      
            }
        }
    }
}
