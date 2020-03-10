namespace Time
{
    partial class Form1
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
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.textBox_minutes = new System.Windows.Forms.TextBox();
            this.textBox_seconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.label_str = new System.Windows.Forms.Label();
            this.textBox_hours2 = new System.Windows.Forms.TextBox();
            this.textBox_seconds2 = new System.Windows.Forms.TextBox();
            this.textBox_minutes2 = new System.Windows.Forms.TextBox();
            this.button_sec = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_h = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.button_addsec = new System.Windows.Forms.Button();
            this.button_addmin = new System.Windows.Forms.Button();
            this.button_addhour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_hours
            // 
            this.textBox_hours.Location = new System.Drawing.Point(128, 14);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(42, 22);
            this.textBox_hours.TabIndex = 0;
            this.textBox_hours.TextChanged += new System.EventHandler(this.TextBox_hours_TextChanged);
            // 
            // textBox_minutes
            // 
            this.textBox_minutes.Location = new System.Drawing.Point(176, 14);
            this.textBox_minutes.Name = "textBox_minutes";
            this.textBox_minutes.Size = new System.Drawing.Size(42, 22);
            this.textBox_minutes.TabIndex = 1;
            this.textBox_minutes.TextChanged += new System.EventHandler(this.TextBox_minutes_TextChanged);
            // 
            // textBox_seconds
            // 
            this.textBox_seconds.Location = new System.Drawing.Point(224, 14);
            this.textBox_seconds.Name = "textBox_seconds";
            this.textBox_seconds.Size = new System.Drawing.Size(42, 22);
            this.textBox_seconds.TabIndex = 2;
            this.textBox_seconds.TextChanged += new System.EventHandler(this.TextBox_seconds_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите время";
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(128, 83);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(71, 23);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(195, 83);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(71, 23);
            this.button_sub.TabIndex = 5;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.Button_sub_Click);
            // 
            // label_str
            // 
            this.label_str.AutoSize = true;
            this.label_str.Location = new System.Drawing.Point(178, 129);
            this.label_str.Name = "label_str";
            this.label_str.Size = new System.Drawing.Size(40, 17);
            this.label_str.TabIndex = 6;
            this.label_str.Text = "  :  :  ";
            // 
            // textBox_hours2
            // 
            this.textBox_hours2.Location = new System.Drawing.Point(128, 43);
            this.textBox_hours2.Name = "textBox_hours2";
            this.textBox_hours2.Size = new System.Drawing.Size(42, 22);
            this.textBox_hours2.TabIndex = 8;
            this.textBox_hours2.TextChanged += new System.EventHandler(this.TextBox_hours2_TextChanged);
            // 
            // textBox_seconds2
            // 
            this.textBox_seconds2.Location = new System.Drawing.Point(224, 43);
            this.textBox_seconds2.Name = "textBox_seconds2";
            this.textBox_seconds2.Size = new System.Drawing.Size(42, 22);
            this.textBox_seconds2.TabIndex = 9;
            this.textBox_seconds2.TextChanged += new System.EventHandler(this.TextBox_seconds2_TextChanged);
            // 
            // textBox_minutes2
            // 
            this.textBox_minutes2.Location = new System.Drawing.Point(176, 43);
            this.textBox_minutes2.Name = "textBox_minutes2";
            this.textBox_minutes2.Size = new System.Drawing.Size(42, 22);
            this.textBox_minutes2.TabIndex = 10;
            this.textBox_minutes2.TextChanged += new System.EventHandler(this.TextBox_minutes2_TextChanged);
            // 
            // button_sec
            // 
            this.button_sec.Location = new System.Drawing.Point(395, 10);
            this.button_sec.Name = "button_sec";
            this.button_sec.Size = new System.Drawing.Size(83, 26);
            this.button_sec.TabIndex = 11;
            this.button_sec.Text = "секундах";
            this.button_sec.UseVisualStyleBackColor = true;
            this.button_sec.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(395, 43);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(83, 25);
            this.button_min.TabIndex = 12;
            this.button_min.Text = "минутах";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.Button_min_Click);
            // 
            // button_h
            // 
            this.button_h.Location = new System.Drawing.Point(395, 74);
            this.button_h.Name = "button_h";
            this.button_h.Size = new System.Drawing.Size(83, 26);
            this.button_h.TabIndex = 13;
            this.button_h.Text = "часах";
            this.button_h.UseVisualStyleBackColor = true;
            this.button_h.Click += new System.EventHandler(this.Button_h_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Отобразить в";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Добавить";
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(583, 14);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(31, 22);
            this.textBox_add.TabIndex = 16;
            this.textBox_add.TextChanged += new System.EventHandler(this.TextBox_add_TextChanged);
            // 
            // button_addsec
            // 
            this.button_addsec.Location = new System.Drawing.Point(629, 13);
            this.button_addsec.Name = "button_addsec";
            this.button_addsec.Size = new System.Drawing.Size(104, 23);
            this.button_addsec.TabIndex = 17;
            this.button_addsec.Text = "к секундам";
            this.button_addsec.UseVisualStyleBackColor = true;
            this.button_addsec.Click += new System.EventHandler(this.Button_addsec_Click);
            // 
            // button_addmin
            // 
            this.button_addmin.Location = new System.Drawing.Point(629, 45);
            this.button_addmin.Name = "button_addmin";
            this.button_addmin.Size = new System.Drawing.Size(104, 23);
            this.button_addmin.TabIndex = 18;
            this.button_addmin.Text = "к минутам";
            this.button_addmin.UseVisualStyleBackColor = true;
            this.button_addmin.Click += new System.EventHandler(this.Button_addmin_Click);
            // 
            // button_addhour
            // 
            this.button_addhour.Location = new System.Drawing.Point(629, 77);
            this.button_addhour.Name = "button_addhour";
            this.button_addhour.Size = new System.Drawing.Size(104, 23);
            this.button_addhour.TabIndex = 19;
            this.button_addhour.Text = "к часам";
            this.button_addhour.UseVisualStyleBackColor = true;
            this.button_addhour.Click += new System.EventHandler(this.Button_addhour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 178);
            this.Controls.Add(this.button_addhour);
            this.Controls.Add(this.button_addmin);
            this.Controls.Add(this.button_addsec);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_h);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_sec);
            this.Controls.Add(this.textBox_minutes2);
            this.Controls.Add(this.textBox_seconds2);
            this.Controls.Add(this.textBox_hours2);
            this.Controls.Add(this.label_str);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_seconds);
            this.Controls.Add(this.textBox_minutes);
            this.Controls.Add(this.textBox_hours);
            this.Name = "Form1";
            this.Text = "Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_hours;
        private System.Windows.Forms.TextBox textBox_minutes;
        private System.Windows.Forms.TextBox textBox_seconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Label label_str;
        private System.Windows.Forms.TextBox textBox_hours2;
        private System.Windows.Forms.TextBox textBox_seconds2;
        private System.Windows.Forms.TextBox textBox_minutes2;
        private System.Windows.Forms.Button button_sec;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_h;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.Button button_addsec;
        private System.Windows.Forms.Button button_addmin;
        private System.Windows.Forms.Button button_addhour;
    }
}

