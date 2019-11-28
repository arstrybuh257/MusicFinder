using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MuzicFinder
{
    public partial class Game_Setting_Form : Form
    {
        public Game_Setting_Form()
        {
            InitializeComponent();
        }

        //Установка настроек
        private void OK_Button_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = cb_AllDirictories.Checked;
            Victorina.gameDuration = Convert.ToInt32(cb_GameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(cb_MusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;



            Victorina.WriteParam();
            Hide();
        }

        //Получение переметров по умолчанию из реестра
        void Set()
        {
            cb_AllDirictories.Checked = Victorina.allDirectories;
            cbRandomStart.Checked = Victorina.randomStart;
            cb_GameDuration.Text = Victorina.gameDuration.ToString();
            cb_MusicDuration.Text = Victorina.musicDuration.ToString();
        }

        //Закрыть форму с Настройками
        private void Cancel_Button_Click(object sender, EventArgs e)
        {

            Set();
            Hide();
        }

        //Выбор директории
        private void ChoseDirectory_Button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles
                    (fbd.SelectedPath,"*mp3",
                    cb_AllDirictories.Checked? 
                    SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);

                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            };
        }

        //Установка параметров при загрузке формы
        private void Game_Setting_Form_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
            Set();
        }
    }
}
