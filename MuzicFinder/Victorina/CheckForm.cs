using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MuzicFinder
{
    public partial class CheckForm : Form
    {
        public string name { get; set; }
        int timeanswer=10;
        public CheckForm()
        {
            InitializeComponent();
        }

        public CheckForm(string n)
        {
            InitializeComponent();
            name =n;
            
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {
            timeanswer = 5;
            progressBar1.Maximum = timeanswer;
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form_Game f = new Form_Game();
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
                timer1.Stop();
                
                MessageBox.Show("Время вышло", "Правильный ответ: +" + name, 
                    MessageBoxButtons.OK);
            }
        }

        private void CheckForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
