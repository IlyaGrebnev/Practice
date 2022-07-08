namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label_information = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.textBox_information = new System.Windows.Forms.TextBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_launch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Constantia", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_information.ForeColor = System.Drawing.SystemColors.Info;
            this.label_information.Location = new System.Drawing.Point(245, 86);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(476, 82);
            this.label_information.TabIndex = 0;
            this.label_information.Text = "Информация";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.textBox_information);
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_launch);
            this.panel_main.Location = new System.Drawing.Point(0, 219);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 272);
            this.panel_main.TabIndex = 1;
            this.panel_main.MouseHover += new System.EventHandler(this.panel_main_MouseHover);
            // 
            // textBox_information
            // 
            this.textBox_information.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_information.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_information.Location = new System.Drawing.Point(12, 102);
            this.textBox_information.Multiline = true;
            this.textBox_information.Name = "textBox_information";
            this.textBox_information.Size = new System.Drawing.Size(945, 152);
            this.textBox_information.TabIndex = 4;
            this.textBox_information.Text = "Курсовая работа по дисциплине \"Программирование\"\r\n\r\nТема: \"Разработака с графичес" +
    "ким интерфейсом \"Каталог\"\"\r\n\r\nРазработал: студент группы БИТ 20-11 Гребнев И.Д.";
            this.textBox_information.TextChanged += new System.EventHandler(this.textBox_information_TextChanged);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.Location = new System.Drawing.Point(787, 16);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(98, 33);
            this.label_exit.TabIndex = 3;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.label_exit_MouseHover);
            // 
            // label_launch
            // 
            this.label_launch.AutoSize = true;
            this.label_launch.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_launch.Location = new System.Drawing.Point(44, 16);
            this.label_launch.Name = "label_launch";
            this.label_launch.Size = new System.Drawing.Size(105, 33);
            this.label_launch.TabIndex = 2;
            this.label_launch.Text = "Запуск";
            this.label_launch.Click += new System.EventHandler(this.label_launch_Click);
            this.label_launch.MouseLeave += new System.EventHandler(this.label_launch_MouseLeave);
            this.label_launch.MouseHover += new System.EventHandler(this.label_launch_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(111, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Каталог";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TextBox textBox_information;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_launch;
        private System.Windows.Forms.Label label1;
    }
}