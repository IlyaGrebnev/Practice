namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label_caption = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_back = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_caption
            // 
            this.label_caption.AutoSize = true;
            this.label_caption.Font = new System.Drawing.Font("Constantia", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_caption.ForeColor = System.Drawing.SystemColors.Info;
            this.label_caption.Location = new System.Drawing.Point(677, 9);
            this.label_caption.Name = "label_caption";
            this.label_caption.Size = new System.Drawing.Size(202, 55);
            this.label_caption.TabIndex = 0;
            this.label_caption.Text = "Каталог";
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(71, 518);
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
            this.panel_main.Controls.Add(this.label_back);
            this.panel_main.Location = new System.Drawing.Point(0, 425);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 66);
            this.panel_main.TabIndex = 2;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.Location = new System.Drawing.Point(824, 16);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(98, 33);
            this.label_exit.TabIndex = 1;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.label_exit_MouseHover);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_back.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_back.Location = new System.Drawing.Point(68, 16);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(93, 33);
            this.label_back.TabIndex = 0;
            this.label_back.Text = "Назад";
            this.label_back.Click += new System.EventHandler(this.label_back_Click);
            this.label_back.MouseLeave += new System.EventHandler(this.label_back_MouseLeave);
            this.label_back.MouseHover += new System.EventHandler(this.label_back_MouseHover);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 81);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(960, 338);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 22);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(114, 42);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Запуск";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(168, 22);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(114, 42);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.label_caption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Расчет итоговых значений";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_caption;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}