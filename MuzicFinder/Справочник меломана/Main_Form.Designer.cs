namespace MuzicFinder
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_search = new System.Windows.Forms.TabPage();
            this.butShowAll = new System.Windows.Forms.Button();
            this.butAutorSearch = new System.Windows.Forms.Button();
            this.butNameSearch = new System.Windows.Forms.Button();
            this.tbAutorSearch = new System.Windows.Forms.TextBox();
            this.tbTitleSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_expandSearch = new System.Windows.Forms.TabPage();
            this.but_ex_search = new System.Windows.Forms.Button();
            this.tb_Album = new System.Windows.Forms.TextBox();
            this.tb_Singer = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.cb_styles = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.TabPage();
            this.but_Cancel_Add = new System.Windows.Forms.Button();
            this.but_add_photo = new System.Windows.Forms.Button();
            this.but_add_mp3 = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.but_add = new System.Windows.Forms.Button();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tp_edit = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.but_edit_img = new System.Windows.Forms.Button();
            this.but_edit_mp3 = new System.Windows.Forms.Button();
            this.cb_edit_Country = new System.Windows.Forms.ComboBox();
            this.cb_edit_Genre = new System.Windows.Forms.ComboBox();
            this.but_EditSong = new System.Windows.Forms.Button();
            this.tb_edit_Year = new System.Windows.Forms.TextBox();
            this.tb_edit_Album = new System.Windows.Forms.TextBox();
            this.tb_edit_Autor = new System.Windows.Forms.TextBox();
            this.tb_edit_Title = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tp_game = new System.Windows.Forms.TabPage();
            this.but_startGame = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_ShowAll1 = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tp_search.SuspendLayout();
            this.tp_expandSearch.SuspendLayout();
            this.Add.SuspendLayout();
            this.tp_edit.SuspendLayout();
            this.tp_game.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(556, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 382);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_search);
            this.tabControl1.Controls.Add(this.tp_expandSearch);
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Controls.Add(this.tp_edit);
            this.tabControl1.Controls.Add(this.tp_game);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(312, 395);
            this.tabControl1.TabIndex = 1;
            // 
            // tp_search
            // 
            this.tp_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_search.BackgroundImage")));
            this.tp_search.Controls.Add(this.butShowAll);
            this.tp_search.Controls.Add(this.butAutorSearch);
            this.tp_search.Controls.Add(this.butNameSearch);
            this.tp_search.Controls.Add(this.tbAutorSearch);
            this.tp_search.Controls.Add(this.tbTitleSearch);
            this.tp_search.Controls.Add(this.label2);
            this.tp_search.Controls.Add(this.label1);
            this.tp_search.Location = new System.Drawing.Point(4, 22);
            this.tp_search.Name = "tp_search";
            this.tp_search.Padding = new System.Windows.Forms.Padding(3);
            this.tp_search.Size = new System.Drawing.Size(304, 369);
            this.tp_search.TabIndex = 0;
            this.tp_search.Text = "Поиск";
            this.tp_search.UseVisualStyleBackColor = true;
            // 
            // butShowAll
            // 
            this.butShowAll.BackColor = System.Drawing.Color.SteelBlue;
            this.butShowAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butShowAll.BackgroundImage")));
            this.butShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShowAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butShowAll.Location = new System.Drawing.Point(29, 321);
            this.butShowAll.Name = "butShowAll";
            this.butShowAll.Size = new System.Drawing.Size(247, 39);
            this.butShowAll.TabIndex = 7;
            this.butShowAll.Text = "Показать все песни";
            this.butShowAll.UseVisualStyleBackColor = false;
            this.butShowAll.Click += new System.EventHandler(this.but_ShowAll_Click);
            // 
            // butAutorSearch
            // 
            this.butAutorSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butAutorSearch.BackgroundImage")));
            this.butAutorSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAutorSearch.Location = new System.Drawing.Point(92, 228);
            this.butAutorSearch.Name = "butAutorSearch";
            this.butAutorSearch.Size = new System.Drawing.Size(120, 63);
            this.butAutorSearch.TabIndex = 5;
            this.butAutorSearch.UseVisualStyleBackColor = true;
            this.butAutorSearch.Click += new System.EventHandler(this.butAutorSearch_Click);
            // 
            // butNameSearch
            // 
            this.butNameSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butNameSearch.BackgroundImage")));
            this.butNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butNameSearch.Location = new System.Drawing.Point(92, 77);
            this.butNameSearch.Name = "butNameSearch";
            this.butNameSearch.Size = new System.Drawing.Size(120, 63);
            this.butNameSearch.TabIndex = 4;
            this.butNameSearch.UseVisualStyleBackColor = true;
            this.butNameSearch.Click += new System.EventHandler(this.but_NameSearch_Click);
            // 
            // tbAutorSearch
            // 
            this.tbAutorSearch.Location = new System.Drawing.Point(58, 202);
            this.tbAutorSearch.Name = "tbAutorSearch";
            this.tbAutorSearch.Size = new System.Drawing.Size(184, 20);
            this.tbAutorSearch.TabIndex = 3;
            // 
            // tbTitleSearch
            // 
            this.tbTitleSearch.Location = new System.Drawing.Point(58, 51);
            this.tbTitleSearch.Name = "tbTitleSearch";
            this.tbTitleSearch.Size = new System.Drawing.Size(184, 20);
            this.tbTitleSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск по исполнителю";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по названию";
            // 
            // tp_expandSearch
            // 
            this.tp_expandSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_expandSearch.BackgroundImage")));
            this.tp_expandSearch.Controls.Add(this.but_ex_search);
            this.tp_expandSearch.Controls.Add(this.tb_Album);
            this.tp_expandSearch.Controls.Add(this.tb_Singer);
            this.tp_expandSearch.Controls.Add(this.tb_title);
            this.tp_expandSearch.Controls.Add(this.label9);
            this.tp_expandSearch.Controls.Add(this.label10);
            this.tp_expandSearch.Controls.Add(this.label11);
            this.tp_expandSearch.Controls.Add(this.cb_country);
            this.tp_expandSearch.Controls.Add(this.cb_year);
            this.tp_expandSearch.Controls.Add(this.cb_styles);
            this.tp_expandSearch.Controls.Add(this.label12);
            this.tp_expandSearch.Controls.Add(this.label13);
            this.tp_expandSearch.Controls.Add(this.label14);
            this.tp_expandSearch.Location = new System.Drawing.Point(4, 22);
            this.tp_expandSearch.Name = "tp_expandSearch";
            this.tp_expandSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tp_expandSearch.Size = new System.Drawing.Size(304, 369);
            this.tp_expandSearch.TabIndex = 3;
            this.tp_expandSearch.Text = "Расш. поиск";
            this.tp_expandSearch.UseVisualStyleBackColor = true;
            // 
            // but_ex_search
            // 
            this.but_ex_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_ex_search.BackgroundImage")));
            this.but_ex_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_ex_search.Location = new System.Drawing.Point(69, 275);
            this.but_ex_search.Name = "but_ex_search";
            this.but_ex_search.Size = new System.Drawing.Size(165, 69);
            this.but_ex_search.TabIndex = 24;
            this.but_ex_search.UseVisualStyleBackColor = true;
            this.but_ex_search.Click += new System.EventHandler(this.but_ex_search_Click);
            // 
            // tb_Album
            // 
            this.tb_Album.Location = new System.Drawing.Point(113, 207);
            this.tb_Album.Name = "tb_Album";
            this.tb_Album.Size = new System.Drawing.Size(121, 20);
            this.tb_Album.TabIndex = 23;
            // 
            // tb_Singer
            // 
            this.tb_Singer.Location = new System.Drawing.Point(159, 171);
            this.tb_Singer.Name = "tb_Singer";
            this.tb_Singer.Size = new System.Drawing.Size(121, 20);
            this.tb_Singer.TabIndex = 22;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(120, 138);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(121, 20);
            this.tb_title.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 33);
            this.label9.TabIndex = 20;
            this.label9.Text = "Альбом";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(5, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 33);
            this.label10.TabIndex = 19;
            this.label10.Text = "Исполнитель";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 33);
            this.label11.TabIndex = 18;
            this.label11.Text = "Название";
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(110, 92);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(121, 21);
            this.cb_country.TabIndex = 17;
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(142, 58);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(121, 21);
            this.cb_year.TabIndex = 16;
            // 
            // cb_styles
            // 
            this.cb_styles.FormattingEnabled = true;
            this.cb_styles.Location = new System.Drawing.Point(171, 25);
            this.cb_styles.Name = "cb_styles";
            this.cb_styles.Size = new System.Drawing.Size(121, 21);
            this.cb_styles.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 33);
            this.label12.TabIndex = 14;
            this.label12.Text = "Страна";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(7, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 33);
            this.label13.TabIndex = 13;
            this.label13.Text = "Год выхода";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(0, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 33);
            this.label14.TabIndex = 12;
            this.label14.Text = "Стиль музыки";
            // 
            // Add
            // 
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.Controls.Add(this.but_Cancel_Add);
            this.Add.Controls.Add(this.but_add_photo);
            this.Add.Controls.Add(this.but_add_mp3);
            this.Add.Controls.Add(this.cbCountry);
            this.Add.Controls.Add(this.cbGenre);
            this.Add.Controls.Add(this.but_add);
            this.Add.Controls.Add(this.tbYear);
            this.Add.Controls.Add(this.tbAlbum);
            this.Add.Controls.Add(this.tbAutor);
            this.Add.Controls.Add(this.tbTitle);
            this.Add.Controls.Add(this.label8);
            this.Add.Controls.Add(this.label7);
            this.Add.Controls.Add(this.label6);
            this.Add.Controls.Add(this.label5);
            this.Add.Controls.Add(this.label4);
            this.Add.Controls.Add(this.label3);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(304, 369);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // but_Cancel_Add
            // 
            this.but_Cancel_Add.BackColor = System.Drawing.Color.White;
            this.but_Cancel_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_Cancel_Add.BackgroundImage")));
            this.but_Cancel_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_Cancel_Add.Location = new System.Drawing.Point(218, 248);
            this.but_Cancel_Add.Name = "but_Cancel_Add";
            this.but_Cancel_Add.Size = new System.Drawing.Size(68, 53);
            this.but_Cancel_Add.TabIndex = 19;
            this.but_Cancel_Add.UseVisualStyleBackColor = false;
            this.but_Cancel_Add.Click += new System.EventHandler(this.but_CancelAdd_Click);
            // 
            // but_add_photo
            // 
            this.but_add_photo.BackColor = System.Drawing.Color.SteelBlue;
            this.but_add_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_add_photo.Location = new System.Drawing.Point(11, 286);
            this.but_add_photo.Name = "but_add_photo";
            this.but_add_photo.Size = new System.Drawing.Size(121, 47);
            this.but_add_photo.TabIndex = 18;
            this.but_add_photo.Text = "Выбрать картинку";
            this.but_add_photo.UseVisualStyleBackColor = false;
            this.but_add_photo.Click += new System.EventHandler(this.but_add_photo_Click);
            // 
            // but_add_mp3
            // 
            this.but_add_mp3.BackColor = System.Drawing.Color.SteelBlue;
            this.but_add_mp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_add_mp3.Location = new System.Drawing.Point(11, 233);
            this.but_add_mp3.Name = "but_add_mp3";
            this.but_add_mp3.Size = new System.Drawing.Size(121, 47);
            this.but_add_mp3.TabIndex = 17;
            this.but_add_mp3.Text = "Выбрать файл";
            this.but_add_mp3.UseVisualStyleBackColor = false;
            this.but_add_mp3.Click += new System.EventHandler(this.but_add_mp3_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(149, 184);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(121, 21);
            this.cbCountry.TabIndex = 16;
            // 
            // but_add
            // 
            this.but_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_add.BackgroundImage")));
            this.but_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_add.Location = new System.Drawing.Point(218, 307);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(68, 53);
            this.but_add.TabIndex = 14;
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(149, 149);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(121, 20);
            this.tbYear.TabIndex = 12;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(149, 114);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(121, 20);
            this.tbAlbum.TabIndex = 11;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(149, 78);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(121, 20);
            this.tbAutor.TabIndex = 10;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(149, 43);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(121, 20);
            this.tbTitle.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Страна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Год выпуска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Альбом";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Исполнитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Жанр";
            // 
            // tp_edit
            // 
            this.tp_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_edit.BackgroundImage")));
            this.tp_edit.Controls.Add(this.label21);
            this.tp_edit.Controls.Add(this.but_edit_img);
            this.tp_edit.Controls.Add(this.but_edit_mp3);
            this.tp_edit.Controls.Add(this.cb_edit_Country);
            this.tp_edit.Controls.Add(this.cb_edit_Genre);
            this.tp_edit.Controls.Add(this.but_EditSong);
            this.tp_edit.Controls.Add(this.tb_edit_Year);
            this.tp_edit.Controls.Add(this.tb_edit_Album);
            this.tp_edit.Controls.Add(this.tb_edit_Autor);
            this.tp_edit.Controls.Add(this.tb_edit_Title);
            this.tp_edit.Controls.Add(this.label15);
            this.tp_edit.Controls.Add(this.label16);
            this.tp_edit.Controls.Add(this.label17);
            this.tp_edit.Controls.Add(this.label18);
            this.tp_edit.Controls.Add(this.label19);
            this.tp_edit.Controls.Add(this.label20);
            this.tp_edit.Location = new System.Drawing.Point(4, 22);
            this.tp_edit.Name = "tp_edit";
            this.tp_edit.Padding = new System.Windows.Forms.Padding(3);
            this.tp_edit.Size = new System.Drawing.Size(304, 369);
            this.tp_edit.TabIndex = 4;
            this.tp_edit.Text = "Изменить";
            this.tp_edit.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(16, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(282, 39);
            this.label21.TabIndex = 35;
            this.label21.Text = "Редактирование";
            // 
            // but_edit_img
            // 
            this.but_edit_img.BackColor = System.Drawing.Color.SteelBlue;
            this.but_edit_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit_img.Location = new System.Drawing.Point(6, 313);
            this.but_edit_img.Name = "but_edit_img";
            this.but_edit_img.Size = new System.Drawing.Size(121, 47);
            this.but_edit_img.TabIndex = 34;
            this.but_edit_img.Text = "Изменить картинку";
            this.but_edit_img.UseVisualStyleBackColor = false;
            this.but_edit_img.Click += new System.EventHandler(this.but_edit_img_Click);
            // 
            // but_edit_mp3
            // 
            this.but_edit_mp3.BackColor = System.Drawing.Color.SteelBlue;
            this.but_edit_mp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_edit_mp3.Location = new System.Drawing.Point(6, 264);
            this.but_edit_mp3.Name = "but_edit_mp3";
            this.but_edit_mp3.Size = new System.Drawing.Size(121, 47);
            this.but_edit_mp3.TabIndex = 33;
            this.but_edit_mp3.Text = "Изменить файл";
            this.but_edit_mp3.UseVisualStyleBackColor = false;
            this.but_edit_mp3.Click += new System.EventHandler(this.but_edit_mp3_Click);
            // 
            // cb_edit_Country
            // 
            this.cb_edit_Country.FormattingEnabled = true;
            this.cb_edit_Country.Location = new System.Drawing.Point(161, 223);
            this.cb_edit_Country.Name = "cb_edit_Country";
            this.cb_edit_Country.Size = new System.Drawing.Size(121, 21);
            this.cb_edit_Country.TabIndex = 32;
            // 
            // cb_edit_Genre
            // 
            this.cb_edit_Genre.FormattingEnabled = true;
            this.cb_edit_Genre.Location = new System.Drawing.Point(161, 48);
            this.cb_edit_Genre.Name = "cb_edit_Genre";
            this.cb_edit_Genre.Size = new System.Drawing.Size(121, 21);
            this.cb_edit_Genre.TabIndex = 31;
            // 
            // but_EditSong
            // 
            this.but_EditSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_EditSong.BackgroundImage")));
            this.but_EditSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_EditSong.Location = new System.Drawing.Point(230, 307);
            this.but_EditSong.Name = "but_EditSong";
            this.but_EditSong.Size = new System.Drawing.Size(68, 53);
            this.but_EditSong.TabIndex = 30;
            this.but_EditSong.UseVisualStyleBackColor = true;
            this.but_EditSong.Click += new System.EventHandler(this.but_EditSong_Click);
            // 
            // tb_edit_Year
            // 
            this.tb_edit_Year.Location = new System.Drawing.Point(161, 188);
            this.tb_edit_Year.Name = "tb_edit_Year";
            this.tb_edit_Year.Size = new System.Drawing.Size(121, 20);
            this.tb_edit_Year.TabIndex = 29;
            // 
            // tb_edit_Album
            // 
            this.tb_edit_Album.Location = new System.Drawing.Point(161, 153);
            this.tb_edit_Album.Name = "tb_edit_Album";
            this.tb_edit_Album.Size = new System.Drawing.Size(121, 20);
            this.tb_edit_Album.TabIndex = 28;
            // 
            // tb_edit_Autor
            // 
            this.tb_edit_Autor.Location = new System.Drawing.Point(161, 117);
            this.tb_edit_Autor.Name = "tb_edit_Autor";
            this.tb_edit_Autor.Size = new System.Drawing.Size(121, 20);
            this.tb_edit_Autor.TabIndex = 27;
            // 
            // tb_edit_Title
            // 
            this.tb_edit_Title.Location = new System.Drawing.Point(161, 82);
            this.tb_edit_Title.Name = "tb_edit_Title";
            this.tb_edit_Title.Size = new System.Drawing.Size(121, 20);
            this.tb_edit_Title.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(18, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "Страна";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(18, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "Год выпуска";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(18, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "Альбом";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(18, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 25);
            this.label18.TabIndex = 22;
            this.label18.Text = "Исполнитель";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(18, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 25);
            this.label19.TabIndex = 21;
            this.label19.Text = "Название";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(18, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 25);
            this.label20.TabIndex = 20;
            this.label20.Text = "Жанр";
            // 
            // tp_game
            // 
            this.tp_game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_game.BackgroundImage")));
            this.tp_game.Controls.Add(this.but_startGame);
            this.tp_game.Location = new System.Drawing.Point(4, 22);
            this.tp_game.Name = "tp_game";
            this.tp_game.Padding = new System.Windows.Forms.Padding(3);
            this.tp_game.Size = new System.Drawing.Size(304, 369);
            this.tp_game.TabIndex = 1;
            this.tp_game.Text = "Игра";
            this.tp_game.UseVisualStyleBackColor = true;
            // 
            // but_startGame
            // 
            this.but_startGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_startGame.BackgroundImage")));
            this.but_startGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_startGame.Location = new System.Drawing.Point(-4, 59);
            this.but_startGame.Name = "but_startGame";
            this.but_startGame.Size = new System.Drawing.Size(312, 223);
            this.but_startGame.TabIndex = 0;
            this.but_startGame.UseVisualStyleBackColor = true;
            this.but_startGame.Click += new System.EventHandler(this.but_startGame_Click);
            // 
            // butBack
            // 
            this.butBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butBack.BackgroundImage")));
            this.butBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butBack.Location = new System.Drawing.Point(22, 440);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(116, 61);
            this.butBack.TabIndex = 2;
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but_ShowAll1);
            this.panel1.Controls.Add(this.but_del);
            this.panel1.Controls.Add(this.but_clear);
            this.panel1.Location = new System.Drawing.Point(556, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 102);
            this.panel1.TabIndex = 3;
            // 
            // but_ShowAll1
            // 
            this.but_ShowAll1.BackColor = System.Drawing.Color.SteelBlue;
            this.but_ShowAll1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.but_ShowAll1.Location = new System.Drawing.Point(3, 62);
            this.but_ShowAll1.Name = "but_ShowAll1";
            this.but_ShowAll1.Size = new System.Drawing.Size(265, 37);
            this.but_ShowAll1.TabIndex = 2;
            this.but_ShowAll1.Text = "Показать все песни";
            this.but_ShowAll1.UseVisualStyleBackColor = false;
            this.but_ShowAll1.Click += new System.EventHandler(this.but_showall_Click);
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.SteelBlue;
            this.but_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_del.Location = new System.Drawing.Point(143, 4);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(125, 52);
            this.but_del.TabIndex = 1;
            this.but_del.Text = "Удалить песню";
            this.but_del.UseVisualStyleBackColor = false;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_clear
            // 
            this.but_clear.BackColor = System.Drawing.Color.SteelBlue;
            this.but_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_clear.Location = new System.Drawing.Point(3, 3);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(125, 52);
            this.but_clear.TabIndex = 0;
            this.but_clear.Text = "Очистить список";
            this.but_clear.UseVisualStyleBackColor = false;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(149, 9);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 15;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(839, 523);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник меломана";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_search.ResumeLayout(false);
            this.tp_search.PerformLayout();
            this.tp_expandSearch.ResumeLayout(false);
            this.tp_expandSearch.PerformLayout();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.tp_edit.ResumeLayout(false);
            this.tp_edit.PerformLayout();
            this.tp_game.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_search;
        private System.Windows.Forms.Button butAutorSearch;
        private System.Windows.Forms.Button butNameSearch;
        private System.Windows.Forms.TextBox tbAutorSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_game;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button but_startGame;
        private System.Windows.Forms.Button butShowAll;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbTitleSearch;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button but_add_photo;
        private System.Windows.Forms.Button but_add_mp3;
        private System.Windows.Forms.TabPage tp_expandSearch;
        private System.Windows.Forms.Button but_ex_search;
        private System.Windows.Forms.TextBox tb_Album;
        private System.Windows.Forms.TextBox tb_Singer;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.ComboBox cb_styles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button but_Cancel_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.TabPage tp_edit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button but_edit_img;
        private System.Windows.Forms.Button but_edit_mp3;
        private System.Windows.Forms.ComboBox cb_edit_Country;
        private System.Windows.Forms.ComboBox cb_edit_Genre;
        private System.Windows.Forms.Button but_EditSong;
        private System.Windows.Forms.TextBox tb_edit_Year;
        private System.Windows.Forms.TextBox tb_edit_Album;
        private System.Windows.Forms.TextBox tb_edit_Autor;
        private System.Windows.Forms.TextBox tb_edit_Title;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button but_ShowAll1;
        private System.Windows.Forms.ComboBox cbGenre;
    }
}