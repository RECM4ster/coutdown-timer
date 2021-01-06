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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        
        public Form2(string czas)
        {
            InitializeComponent();
            label2.Text = czas;
            label3.Text = "false";
        }

        
        //Start
        private void button1_Click(object sender, EventArgs e)
        {

            label3.Text = "false";
            var time = int.Parse(label2.Text);
            var pause = Convert.ToBoolean(label3.Text);
            timer(time, pause);


        }

        //Stop


        private void timer(int time, bool pause)
        {
            while (time > 0 && pause == false)
            {
                Thread.Sleep(1000);
                time--;
                updateTime(time);
                label2.Text = time.ToString();
                label2.Refresh();
                if (Convert.ToBoolean(label3.Text) == true)
                {
                    pause = true;
                }
            }
            timer(time, pause);
        }

        private void updateTime(int time)
        {
            int minuty = time / 60;
            int sekundy = time % 60;
            var labelText = "Pozostało " + minuty.ToString() + " minut " + sekundy.ToString() + " sekund ";
            //MessageBox.Show(labelText, "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            label1.Text = String.Format(labelText);
            label1.Refresh();
        }


    }
}
