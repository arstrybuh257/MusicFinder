using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace MuzicFinder
{
    public partial class Song_Form : Form
    {
        public Song_Form()
        {
            InitializeComponent();
        }

        

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void Song_Form_Load(object sender, EventArgs e)
        {
            
            
            WMP.Ctlcontrols.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.play();
        }

        private void Song_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
        }
    }
}
