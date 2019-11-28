namespace MuzicFinder
{
    partial class Start_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Form));
            this.but_start = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_start
            // 
            this.but_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_start.BackgroundImage")));
            this.but_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_start.Location = new System.Drawing.Point(281, 189);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(214, 112);
            this.but_start.TabIndex = 0;
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // but_exit
            // 
            this.but_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_exit.BackgroundImage")));
            this.but_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_exit.Location = new System.Drawing.Point(281, 342);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(214, 112);
            this.but_exit.TabIndex = 1;
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 519);
            this.ControlBox = false;
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_start);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Start_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.Button but_exit;
    }
}

