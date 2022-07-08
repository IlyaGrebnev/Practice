namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.label_caption = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_caption
            // 
            this.label_caption.AutoSize = true;
            this.label_caption.Font = new System.Drawing.Font("Constantia", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_caption.ForeColor = System.Drawing.SystemColors.Info;
            this.label_caption.Location = new System.Drawing.Point(381, 9);
            this.label_caption.Name = "label_caption";
            this.label_caption.Size = new System.Drawing.Size(190, 56);
            this.label_caption.TabIndex = 0;
            this.label_caption.Text = "Каталог";
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(78, 520);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(825, 18);
            this.label_university.TabIndex = 1;
            this.label_university.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_information);
            this.panel_main.Controls.Add(this.label_start);
            this.panel_main.Location = new System.Drawing.Point(0, 425);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 66);
            this.panel_main.TabIndex = 2;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_exit.Location = new System.Drawing.Point(783, 12);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(98, 33);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.label_exit_MouseHover);
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_information.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_information.Location = new System.Drawing.Point(365, 12);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(194, 33);
            this.label_information.TabIndex = 1;
            this.label_information.Text = "Информация";
            this.label_information.Click += new System.EventHandler(this.label_information_Click);
            this.label_information.MouseLeave += new System.EventHandler(this.label_information_MouseLeave);
            this.label_information.MouseHover += new System.EventHandler(this.label_information_MouseHover);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_start.Location = new System.Drawing.Point(44, 12);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(105, 33);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "Запуск";
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            this.label_start.MouseLeave += new System.EventHandler(this.label_start_MouseLeave);
            this.label_start.MouseHover += new System.EventHandler(this.label_start_MouseHover);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::WindowsFormsApp1.Properties.Resources._1640037686_36_phonoteka_org_p_biblioteka_vnutri_fon_krasivo_38;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(12, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(960, 330);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_caption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Каталог";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_caption;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

