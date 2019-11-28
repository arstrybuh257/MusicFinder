using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzicFinder
{
    //Стартовая форма
    public partial class Start_Form : Form
    {
      
        public Start_Form()
        {
            InitializeComponent();
        }

        //Закрытие всего прложения
        private void but_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Переход на главную форму
        private void but_start_Click(object sender, EventArgs e)
        {
            Main_Form f = new Main_Form();
            f.Show();
            
            
        }
    }
}
