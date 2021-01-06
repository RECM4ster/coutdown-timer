using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataFromTextbox = textBox1.Text;
            int czas;
            var komunikat = int.TryParse(dataFromTextbox, out czas);
            
            if (komunikat)
            {
                this.Hide();
                Form2 f2 = new Form2(dataFromTextbox); 
                f2.Show();

            }

            else
            { 
                label2.Text = "Podana Wartość musi być liczbowa";
            }

        }
    }
}
