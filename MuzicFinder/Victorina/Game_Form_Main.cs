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
    public partial class Game_Form_Main : Form
    {
        Game_Setting_Form f = new Game_Setting_Form();
        public Game_Form_Main()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Main_Form f = new Main_Form();
            Close();
            f.Show();
        }

        private void Setting_Buton_Click(object sender, EventArgs e)
        {
            
            f.ShowDialog();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Form_Game f = new Form_Game();
            f.ShowDialog();
        }

        private void Game_Form_Main_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMusic();
        }
    }
}
