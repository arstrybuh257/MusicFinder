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
    public partial class Form_Game : Form
    {
        public string name { get; set;}
        Random rnd = new Random();
        int musicDuration=Victorina.musicDuration;

        public Form_Game()
        {
            InitializeComponent();
        }

        //Метод выбора случайной песни из списка
        string MakeMusic()
        {
            if (Victorina.list.Count == 0)
            {
                musicDuration = Victorina.musicDuration;
                EndGame();
                return "";
            }
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                 
                WMP.URL = Victorina.list[n];

                string name=Victorina.list[n].Split('\\')[Victorina.list[n].Split('\\').Length - 1];
                Victorina.list.RemoveAt(n);

                MelodyCount.Text = Convert.ToString(Victorina.list.Count);

                return name;
            }
        }

        //Следущая песня
        private void Next_Click(object sender, EventArgs e)
        {
            timer1.Start();
            name=MakeMusic();

        }

        //Установка значений для формы при ее загрузке
        private void Form_Game_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            MelodyCount.Text = Convert.ToString(Victorina.list.Count);
            progressBar1.Maximum = Victorina.gameDuration;
            labelTime.Text = musicDuration.ToString();
        }

        //Закрытие формы
        private void Form_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndGame();
        }

        //Пауза
        private void button1_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        //Метод окончания игры
        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();

            if (label_counter1.Text == label_counter2.Text)
            {
                DialogResult result=MessageBox.Show($"Ничья со счетом" +
                $"  {label_counter1.Text} : {label_counter2.Text}","Конец игры",
                MessageBoxButtons.OK);
                if(result==DialogResult.OK)Close();
            }
            else
            {
                string winner = Convert.ToInt32(label_counter1.Text)
                         > Convert.ToInt32(label_counter1.Text) ? "Игрок 1" : "Игрок 2";
                DialogResult result = MessageBox.Show($"Победил {winner} cо счетом" +
                         $"  {label_counter1.Text} : {label_counter2.Text}");
                if (result == DialogResult.OK) Close();
            }
        }

        //Ход игры при течении времени
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = musicDuration.ToString();
            musicDuration--;
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();                
                return;
            }
            if (musicDuration == 0)
            {
                GamePause();
                MessageBox.Show("Время вышло", "Правильный ответ: " + name,
                    MessageBoxButtons.OK);

                labelTime.Text = musicDuration.ToString();
                
            }
        }

        //Продолжить
        private void button2_Click(object sender, EventArgs e)
        {
            GameContinue();
        }

        //Метод для паузы
        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        //Продолженгие игры
        void GameContinue()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        //Нажатие игроками на клавиши
        private void Form_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                GamePause();
                CheckForm cf = new CheckForm(name);
                cf.label1.Text = "Игрок 1";
                if(cf.ShowDialog() == DialogResult.Yes)
                {
                    label_counter1.Text =
                        Convert.ToString( Convert.ToInt32(label_counter1.Text)+1);
                    
                }
                
            }
            if (e.KeyData == Keys.P)
            {
                CheckForm cf = new CheckForm(name);
                cf.label1.Text = "Игрок 2";
                GamePause();
                if (cf.ShowDialog() == DialogResult.Yes)
                {
                    label_counter2.Text =
                        Convert.ToString(Convert.ToInt32(label_counter2.Text) + 1);

                }

            }
        }

        //Для старта песни со случайного места
        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
            {
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition =
                        rnd.Next(0, (int)(WMP.currentMedia.duration / 2));
                }
            }
        }

        //Пауза
        private void button1_Click_1(object sender, EventArgs e)
        {
            GamePause();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клавиши для игроков  Игрок1: Q    Игрок2: P","Справка");
        }
    }
}
