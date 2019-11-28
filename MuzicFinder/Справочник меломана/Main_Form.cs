using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System.IO;
using System.Text.RegularExpressions;

namespace MuzicFinder
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

        }

        //Временные поля для выбраных файлов
        public string mp3 = "";
        public string img = "";

        //Метод очистки списка
        public void Listbox1Clear()
        {
            listBox1.Items.Clear();
        }

        //Установка значений для КомбоБоксов
        public void SetComboBoxes()
        {
            SongContext ctx = new SongContext();
            var songs = ctx.Songs.AsQueryable();

            cb_styles.Items.Clear();
            cb_edit_Genre.Items.Clear();
            cbGenre.Items.Clear();
            cbCountry.Items.Clear();
            cb_country.Items.Clear();
            cb_edit_Country.Items.Clear();
            cb_year.Items.Clear();
            foreach (Song s in songs)
            {
                

                if (cb_styles.Items.IndexOf(s.Genre) == -1 && s.Genre!="unknown")
                {
                    cb_styles.Items.Add(s.Genre);
                }

                if (cb_edit_Genre.Items.IndexOf(s.Genre) == -1 && s.Genre != "unknown")
                {
                    cb_edit_Genre.Items.Add(s.Genre);
                }

                if (cbGenre.Items.IndexOf(s.Genre) == -1 && s.Genre != "unknown")
                {
                    cbGenre.Items.Add(s.Genre);
                }

                if (cbCountry.Items.IndexOf(s.Country)==-1 && s.Country != "unknown")
                {
                    cbCountry.Items.Add(s.Country);
                }

                if (cb_country.Items.IndexOf(s.Country) == -1 && s.Country != "unknown")
                {
                    cb_country.Items.Add(s.Country);
                }

                if (cb_edit_Country.Items.IndexOf(s.Country) == -1 && s.Country != "unknown")
                {
                    cb_edit_Country.Items.Add(s.Country);
                }

                if (cb_year.Items.IndexOf(s.Year) == -1 && s.Year != "unknown")
                {
                    cb_year.Items.Add(s.Year);
                    
                }
            }
        }
        
        //Метод удаления песни
        public void DeleteSong()
        {
            DialogResult dr = MessageBox.Show("Вы уверенны, что хотите удалить песню?" +
                    "После удаления отменить его будет невозможно", "Предупреждение",
                    MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                SongContext ctx = new SongContext();
                string[] selectedStr = (listBox1.SelectedItem.ToString()).Split('*');

                ctx.Songs.DeleteOne(t => (t.Title.ToUpper() == selectedStr[0].ToUpper())
                && (t.Autor.ToUpper() == selectedStr[1].ToUpper()));
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            
        }

        //Показать весь список
        public void ShowAll()
        {
            listBox1.Items.Clear();
            SongContext ctx = new SongContext();
            var songs = ctx.Songs.AsQueryable();
            foreach (Song s in songs)
            {
                listBox1.Items.Add(s.Title + "*" + s.Autor);
            }
        }

        //Метод выбора музыкального файла
        public string ChooseMusicFile()
        {
            string filename = "";
            string pattern = @"\w*[.mp3]{4}$";
            Regex rg = new Regex(pattern);
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK && rg.IsMatch(fbd.FileName))
            {
                filename=fbd.FileName;
                filename = filename.Split('\\')[filename.Split('\\').Length - 2] +'\\'+
                    filename.Split('\\')[filename.Split('\\').Length - 1];
            }
            else filename="";

            return filename;

        }


        //Метод выбора файла изображения
        public string ChooseImageFile()
        {
            string filename = "";
            string pattern = @"\w*[.png|.jpg|.PNG|.JPG|.gif|.GIF]{4}$";
            OpenFileDialog fbd = new OpenFileDialog();
            Regex rg = new Regex(pattern);
            if (fbd.ShowDialog() == DialogResult.OK && rg.IsMatch(fbd.FileName))
            {
                filename = fbd.FileName;
                filename = filename.Split('\\')[filename.Split('\\').Length - 2] + '\\' +
                    filename.Split('\\')[filename.Split('\\').Length - 1];
            }
            else filename = "";

            return filename;


        }

        //Вернуться на Стартовую Форму
        private void butBack_Click(object sender, EventArgs e)
        {
            Start_Form f = new Start_Form();
            Close();
            

        }

        //Перейти на Стартовую Форму Игры
        private void but_startGame_Click(object sender, EventArgs e)
        {
            Game_Form_Main f = new Game_Form_Main();
            f.Show();
            Close();
        }

        //Показать весь список
        private void but_ShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        //Поиск по названию
        private void but_NameSearch_Click(object sender, EventArgs e)   
        {
            listBox1.Items.Clear();
            SongContext ctx = new SongContext();
            Regex regex = new Regex(tbTitleSearch.Text, RegexOptions.IgnoreCase);
            var songs = ctx.Songs.AsQueryable().Where(t => regex.IsMatch(t.Title));
            foreach (Song s in songs)
            {
                
                listBox1.Items.Add(s.Title + "*" + s.Autor);
            }
            tbTitleSearch.Clear();
        }

        //Поиск по автору
        private void butAutorSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SongContext ctx = new SongContext();
            Regex regex = new Regex(tbAutorSearch.Text, RegexOptions.IgnoreCase);
            var songs = ctx.Songs.AsQueryable().Where(t => regex.IsMatch(t.Autor));
            foreach (Song s in songs)
            {
                listBox1.Items.Add(s.Title + "*" + s.Autor);
            }
            tbAutorSearch.Clear();
        }

        //При выборе песни, появляется возможность редактировать
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SongContext ctx = new SongContext();
            if (listBox1.SelectedItem == null) return;
            string[] selectedStr = (listBox1.SelectedItem.ToString()).Split('*');
            if (selectedStr != null)
            {
                var song = ctx.Songs.AsQueryable().Where(t => t.Title == selectedStr[0] &&
                  t.Autor == selectedStr[1]);

                foreach (Song s in song)
                {
                    cb_edit_Genre.Text = s.Genre;
                    tb_edit_Title.Text = s.Title;
                    tb_edit_Autor.Text = s.Autor;
                    tb_edit_Year.Text = s.Year;
                    cb_edit_Country.Text = s.Country;
                    tb_edit_Album.Text = s.Album;
                }
            }
            
        }

        //Добавить новую песню
        private void but_add_Click(object sender, EventArgs e)
        {

            SongContext ctx = new SongContext();

            Song s = new Song();
            s.Genre = cbGenre.Text != "" ? cbGenre.Text : "unknown";
            s.Title = tbTitle.Text != "" ? tbTitle.Text : "unknown";
            s.Autor = tbAutor.Text != "" ? tbAutor.Text : "unknown";
            s.Album = tbAlbum.Text != "" ? tbAlbum.Text : "unknown";
            s.Year = tbYear.Text != "" ? tbYear.Text : "unknown";
            s.Country = cbCountry.Text != "" ? cbCountry.Text : "unknown";
            if (mp3 != "")
            {
                s.File = mp3;


                if (img != "" && img != null)
                {
                    s.Image = img;
                }
                else s.Image = @"Исполнители\default.jpg";

                ctx.Insert(s);

                //очистка полей ввода
                cbGenre.Text = "";
                cbCountry.Text = "";
                tbAutor.Text = "";
                tbTitle.Text = "";
                tbAlbum.Text = "";
                tbYear.Text = "";
                but_add_photo.BackColor = Color.SteelBlue;
                but_add_mp3.BackColor = Color.SteelBlue;
                mp3 = "";
                img = "";
            }

            else
            {
                MessageBox.Show("Нужно выбрать музыкальный файл");
            }


            SetComboBoxes();

        }

        //Добавить музыкальный файл
        private void but_add_mp3_Click(object sender, EventArgs e)
        {
            mp3 = ChooseMusicFile();
            if (mp3 != "") but_add_mp3.BackColor = Color.PaleGreen;
        }

        //Добавить изображение
        private void but_add_photo_Click(object sender, EventArgs e)
        {
            img = ChooseImageFile();
            if (img != "") but_add_photo.BackColor = Color.PaleGreen;
            
        }

        //Проигрывать песню при выборе
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Song_Form f = new Song_Form();
            SongContext ctx = new SongContext();
            string[] selectedStr = (listBox1.SelectedItem.ToString()).Split('*');
            var song = ctx.Songs.AsQueryable().Where(t => t.Autor.ToUpper() == selectedStr[1].ToUpper()
              && t.Title.ToUpper() == selectedStr[0].ToUpper());

            foreach (Song s in song)
            {
                f.lblTitle.Text = s.Title;
                f.lblYear.Text = s.Year;
                f.lblAutor.Text = s.Autor;
                f.lblGenre.Text = s.Genre;
                f.lblAlbum.Text = s.Album;
                f.lblCountry.Text = s.Country;
                f.WMP.URL = s.File;
                f.pb_Singer.Load(s.Image);



                f.pb_Singer.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            f.ShowDialog();
        }

        //Удаление песни при нажатии клавиши Delete
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSong();
                SetComboBoxes();
            }
        }

        //Расширенный поиск
        private void but_ex_search_Click(object sender, EventArgs e)
        {
            SongContext ctx = new SongContext();

            Regex regexT = new Regex(tb_title.Text, RegexOptions.IgnoreCase);
            Regex regexAut = new Regex(tb_Singer.Text, RegexOptions.IgnoreCase);
            Regex regexAlb = new Regex(tb_Album.Text, RegexOptions.IgnoreCase);

            var songs = ctx.Songs.AsQueryable().Where(t =>
            (t.Genre == cb_styles.Text || cb_styles.Text == "")
            && (t.Year == cb_year.Text || cb_year.Text == "")
            && (t.Country == cb_country.Text || cb_country.Text == "")
            && (regexT.IsMatch(t.Title) || tb_title.Text == "")
            && (regexAut.IsMatch(t.Autor) || tb_Singer.Text == "")
            && (regexAlb.IsMatch(t.Album) || tb_Album.Text == ""));

            Listbox1Clear();


            foreach (Song s in songs)
            {
                listBox1.Items.Add(s.Title + "*" + s.Autor);
            }
        }

        //Отмена добавления(очистка полей ввода)
        private void but_CancelAdd_Click(object sender, EventArgs e)
        {
            //очистка полей ввода
            cbGenre.Text = "";
            cbCountry.Text = "";
            tbAutor.Text = "";
            tbTitle.Text = "";
            tbAlbum.Text = "";
            tbYear.Text = "";
            but_add_photo.BackColor = Color.SteelBlue;
            but_add_mp3.BackColor = Color.SteelBlue;
            mp3 = "";
            img = "";
        }

        //Очистка листбокса
        private void but_clear_Click(object sender, EventArgs e)
        {
            Listbox1Clear();
        }

        //Удаление песни
        private void but_del_Click(object sender, EventArgs e)
        {
            DeleteSong();
            SetComboBoxes();
        }

        //Изменить песню
        private void but_EditSong_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверенны, что хотите изменить песню?" 
                    , "Предупреждение",
                    MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                SongContext ctx = new SongContext();
                string[] selectedStr = (listBox1.SelectedItem.ToString()).Split('*');
                var song = ctx.Songs.AsQueryable().Where(t => t.Title == selectedStr[0] &&
                  t.Autor == selectedStr[1]);



                Song s = new Song();
                s.Genre = cb_edit_Genre.Text != "" ? cb_edit_Genre.Text : "unknown";
                s.Title = tb_edit_Title.Text != "" ? tb_edit_Title.Text : "unknown";
                s.Autor = tb_edit_Autor.Text != "" ? tb_edit_Autor.Text : "unknown";
                s.Album = tb_edit_Album.Text != "" ? tb_edit_Album.Text : "unknown";
                s.Year = tb_edit_Year.Text != "" ? tb_edit_Year.Text : "unknown";
                s.Country = cb_edit_Country.Text != "" ? cb_edit_Country.Text : "unknown";

                foreach (Song s1 in song)
                {
                    s.File = s1.File;
                    s.Image = s1.Image;
                    s._id = s1._id;
                }


                if (mp3 != "" && mp3 != null)
                {
                    s.File = mp3;
                }


                if (img != "" && img != null)
                {
                    s.Image = img;
                }

                ctx.Songs.ReplaceOne(
                    new BsonDocument{
                { "Title", selectedStr[0] },
                { "Autor", selectedStr[1] },
                    }, s);

                but_edit_img.BackColor = Color.SteelBlue;
                but_edit_mp3.BackColor = Color.SteelBlue;
            }

            SetComboBoxes();
        }

        //Изменение файла
        private void but_edit_mp3_Click(object sender, EventArgs e)
        {
             mp3 = ChooseMusicFile();
            if (mp3 == "") MessageBox.Show("Вы выбрали недопустимый файл. Выберите файл" +
                "с расширением .mp3");
            if (mp3 != "") but_edit_mp3.BackColor = Color.PaleGreen;

        }

        //Изменение картинки
        private void but_edit_img_Click(object sender, EventArgs e)
        {
            img = ChooseImageFile();
            if (img == "") MessageBox.Show("Вы выбрали недопустимый файл.");
            if (img != "") but_edit_img.BackColor = Color.PaleGreen;
        }

        //Показать все песни
        private void but_showall_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            SetComboBoxes();
        }
    }

}
