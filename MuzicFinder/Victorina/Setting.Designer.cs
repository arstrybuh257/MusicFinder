namespace MuzicFinder
{
    partial class Game_Setting_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Setting_Form));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ChoseDirectory_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.cb_AllDirictories = new System.Windows.Forms.CheckBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cb_MusicDuration = new System.Windows.Forms.ComboBox();
            this.cb_GameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 303);
            this.listBox1.TabIndex = 0;
            // 
            // ChoseDirectory_Button
            // 
            this.ChoseDirectory_Button.Location = new System.Drawing.Point(35, 321);
            this.ChoseDirectory_Button.Name = "ChoseDirectory_Button";
            this.ChoseDirectory_Button.Size = new System.Drawing.Size(103, 23);
            this.ChoseDirectory_Button.TabIndex = 1;
            this.ChoseDirectory_Button.Text = "Выбрать папку";
            this.ChoseDirectory_Button.UseVisualStyleBackColor = true;
            this.ChoseDirectory_Button.Click += new System.EventHandler(this.ChoseDirectory_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(156, 321);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(103, 23);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.Text = "Очистить";
            this.Clear_Button.UseVisualStyleBackColor = true;
            // 
            // cb_AllDirictories
            // 
            this.cb_AllDirictories.AutoSize = true;
            this.cb_AllDirictories.Location = new System.Drawing.Point(487, 327);
            this.cb_AllDirictories.Name = "cb_AllDirictories";
            this.cb_AllDirictories.Size = new System.Drawing.Size(118, 17);
            this.cb_AllDirictories.TabIndex = 3;
            this.cb_AllDirictories.Text = "Вложенные папки";
            this.cb_AllDirictories.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(685, 432);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(103, 35);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(685, 473);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(103, 36);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cb_MusicDuration);
            this.groupBox1.Controls.Add(this.cb_GameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(27, 113);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(133, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Со случайного места";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cb_MusicDuration
            // 
            this.cb_MusicDuration.FormattingEnabled = true;
            this.cb_MusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.cb_MusicDuration.Location = new System.Drawing.Point(151, 69);
            this.cb_MusicDuration.Name = "cb_MusicDuration";
            this.cb_MusicDuration.Size = new System.Drawing.Size(43, 21);
            this.cb_MusicDuration.TabIndex = 3;
            this.cb_MusicDuration.Text = "20";
            // 
            // cb_GameDuration
            // 
            this.cb_GameDuration.FormattingEnabled = true;
            this.cb_GameDuration.Items.AddRange(new object[] {
            "60",
            "90",
            "120",
            "150"});
            this.cb_GameDuration.Location = new System.Drawing.Point(151, 36);
            this.cb_GameDuration.Name = "cb_GameDuration";
            this.cb_GameDuration.Size = new System.Drawing.Size(43, 21);
            this.cb_GameDuration.TabIndex = 2;
            this.cb_GameDuration.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры";
            // 
            // Game_Setting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.cb_AllDirictories);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.ChoseDirectory_Button);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game_Setting_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Game_Setting_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ChoseDirectory_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.CheckBox cb_AllDirictories;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.ComboBox cb_MusicDuration;
        private System.Windows.Forms.ComboBox cb_GameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}