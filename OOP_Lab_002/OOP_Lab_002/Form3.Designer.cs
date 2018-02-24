namespace OOP_Lab_002
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Save_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Birth_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.PSN_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LName_textBox = new System.Windows.Forms.TextBox();
            this.SName_texBox = new System.Windows.Forms.TextBox();
            this.FName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Blocked_radio = new System.Windows.Forms.RadioButton();
            this.Unblocked_radio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.I_bank_OFF_radio = new System.Windows.Forms.RadioButton();
            this.I_bank_ON_radio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Mobile_phone_textBox = new System.Windows.Forms.TextBox();
            this.SMS_OFF_radio = new System.Windows.Forms.RadioButton();
            this.SMS_ON_radio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Rasschet_radio = new System.Windows.Forms.RadioButton();
            this.Nakop_radio = new System.Windows.Forms.RadioButton();
            this.Sber_radio = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(9, 335);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(651, 57);
            this.Save_button.TabIndex = 0;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Birth_date_picker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PSN_textBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LName_textBox);
            this.groupBox1.Controls.Add(this.SName_texBox);
            this.groupBox1.Controls.Add(this.FName_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(-1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Birth_date_picker
            // 
            this.Birth_date_picker.Location = new System.Drawing.Point(146, 144);
            this.Birth_date_picker.Name = "Birth_date_picker";
            this.Birth_date_picker.Size = new System.Drawing.Size(172, 26);
            this.Birth_date_picker.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(9, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Дата рождения:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PSN_textBox
            // 
            this.PSN_textBox.Location = new System.Drawing.Point(146, 118);
            this.PSN_textBox.Name = "PSN_textBox";
            this.PSN_textBox.Size = new System.Drawing.Size(172, 26);
            this.PSN_textBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(38, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "№ паспорта:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(54, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отчество:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(56, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(97, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя:";
            // 
            // LName_textBox
            // 
            this.LName_textBox.Location = new System.Drawing.Point(146, 92);
            this.LName_textBox.Name = "LName_textBox";
            this.LName_textBox.Size = new System.Drawing.Size(172, 26);
            this.LName_textBox.TabIndex = 3;
            this.LName_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SName_texBox
            // 
            this.SName_texBox.Location = new System.Drawing.Point(146, 66);
            this.SName_texBox.Name = "SName_texBox";
            this.SName_texBox.Size = new System.Drawing.Size(172, 26);
            this.SName_texBox.TabIndex = 2;
            // 
            // FName_textBox
            // 
            this.FName_textBox.Location = new System.Drawing.Point(146, 40);
            this.FName_textBox.Name = "FName_textBox";
            this.FName_textBox.Size = new System.Drawing.Size(172, 26);
            this.FName_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данные о владельце:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Blocked_radio);
            this.groupBox2.Controls.Add(this.Unblocked_radio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Blocked_radio
            // 
            this.Blocked_radio.AutoSize = true;
            this.Blocked_radio.BackColor = System.Drawing.SystemColors.Control;
            this.Blocked_radio.Location = new System.Drawing.Point(155, 42);
            this.Blocked_radio.Name = "Blocked_radio";
            this.Blocked_radio.Size = new System.Drawing.Size(137, 24);
            this.Blocked_radio.TabIndex = 2;
            this.Blocked_radio.TabStop = true;
            this.Blocked_radio.Text = "Заблокирован";
            this.Blocked_radio.UseVisualStyleBackColor = false;
            // 
            // Unblocked_radio
            // 
            this.Unblocked_radio.AutoSize = true;
            this.Unblocked_radio.BackColor = System.Drawing.SystemColors.Control;
            this.Unblocked_radio.Location = new System.Drawing.Point(155, 12);
            this.Unblocked_radio.Name = "Unblocked_radio";
            this.Unblocked_radio.Size = new System.Drawing.Size(144, 24);
            this.Unblocked_radio.TabIndex = 1;
            this.Unblocked_radio.TabStop = true;
            this.Unblocked_radio.Text = "Разблокирован";
            this.Unblocked_radio.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Состояние счёта:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.I_bank_OFF_radio);
            this.groupBox3.Controls.Add(this.I_bank_ON_radio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(336, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // I_bank_OFF_radio
            // 
            this.I_bank_OFF_radio.AutoSize = true;
            this.I_bank_OFF_radio.BackColor = System.Drawing.SystemColors.Control;
            this.I_bank_OFF_radio.Location = new System.Drawing.Point(165, 42);
            this.I_bank_OFF_radio.Name = "I_bank_OFF_radio";
            this.I_bank_OFF_radio.Size = new System.Drawing.Size(138, 24);
            this.I_bank_OFF_radio.TabIndex = 2;
            this.I_bank_OFF_radio.TabStop = true;
            this.I_bank_OFF_radio.Text = "Не подключен";
            this.I_bank_OFF_radio.UseVisualStyleBackColor = false;
            // 
            // I_bank_ON_radio
            // 
            this.I_bank_ON_radio.AutoSize = true;
            this.I_bank_ON_radio.BackColor = System.Drawing.SystemColors.Control;
            this.I_bank_ON_radio.Location = new System.Drawing.Point(165, 13);
            this.I_bank_ON_radio.Name = "I_bank_ON_radio";
            this.I_bank_ON_radio.Size = new System.Drawing.Size(116, 24);
            this.I_bank_ON_radio.TabIndex = 1;
            this.I_bank_ON_radio.TabStop = true;
            this.I_bank_ON_radio.Text = "Подключен";
            this.I_bank_ON_radio.UseVisualStyleBackColor = false;
            this.I_bank_ON_radio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Интернет-банкинг:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Mobile_phone_textBox);
            this.groupBox4.Controls.Add(this.SMS_OFF_radio);
            this.groupBox4.Controls.Add(this.SMS_ON_radio);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(335, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 184);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(6, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Мобильный номер:";
            // 
            // Mobile_phone_textBox
            // 
            this.Mobile_phone_textBox.Location = new System.Drawing.Point(7, 109);
            this.Mobile_phone_textBox.Name = "Mobile_phone_textBox";
            this.Mobile_phone_textBox.Size = new System.Drawing.Size(171, 26);
            this.Mobile_phone_textBox.TabIndex = 5;
            // 
            // SMS_OFF_radio
            // 
            this.SMS_OFF_radio.AutoSize = true;
            this.SMS_OFF_radio.BackColor = System.Drawing.SystemColors.Control;
            this.SMS_OFF_radio.Location = new System.Drawing.Point(154, 52);
            this.SMS_OFF_radio.Name = "SMS_OFF_radio";
            this.SMS_OFF_radio.Size = new System.Drawing.Size(149, 24);
            this.SMS_OFF_radio.TabIndex = 4;
            this.SMS_OFF_radio.TabStop = true;
            this.SMS_OFF_radio.Text = "Не подключены";
            this.SMS_OFF_radio.UseVisualStyleBackColor = false;
            this.SMS_OFF_radio.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // SMS_ON_radio
            // 
            this.SMS_ON_radio.AutoSize = true;
            this.SMS_ON_radio.BackColor = System.Drawing.SystemColors.Control;
            this.SMS_ON_radio.Location = new System.Drawing.Point(154, 22);
            this.SMS_ON_radio.Name = "SMS_ON_radio";
            this.SMS_ON_radio.Size = new System.Drawing.Size(127, 24);
            this.SMS_ON_radio.TabIndex = 3;
            this.SMS_ON_radio.TabStop = true;
            this.SMS_ON_radio.Text = "Подключены";
            this.SMS_ON_radio.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "СМС-оповещения:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.Rasschet_radio);
            this.groupBox5.Controls.Add(this.Nakop_radio);
            this.groupBox5.Controls.Add(this.Sber_radio);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(0, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(660, 45);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // Rasschet_radio
            // 
            this.Rasschet_radio.AutoSize = true;
            this.Rasschet_radio.BackColor = System.Drawing.SystemColors.Control;
            this.Rasschet_radio.Location = new System.Drawing.Point(255, 10);
            this.Rasschet_radio.Name = "Rasschet_radio";
            this.Rasschet_radio.Size = new System.Drawing.Size(118, 24);
            this.Rasschet_radio.TabIndex = 13;
            this.Rasschet_radio.TabStop = true;
            this.Rasschet_radio.Text = "Рассчётный";
            this.Rasschet_radio.UseVisualStyleBackColor = false;
            // 
            // Nakop_radio
            // 
            this.Nakop_radio.AutoSize = true;
            this.Nakop_radio.BackColor = System.Drawing.SystemColors.Control;
            this.Nakop_radio.Location = new System.Drawing.Point(100, 9);
            this.Nakop_radio.Name = "Nakop_radio";
            this.Nakop_radio.Size = new System.Drawing.Size(149, 24);
            this.Nakop_radio.TabIndex = 12;
            this.Nakop_radio.TabStop = true;
            this.Nakop_radio.Text = "Накопительный";
            this.Nakop_radio.UseVisualStyleBackColor = false;
            // 
            // Sber_radio
            // 
            this.Sber_radio.AutoSize = true;
            this.Sber_radio.BackColor = System.Drawing.SystemColors.Control;
            this.Sber_radio.Location = new System.Drawing.Point(379, 9);
            this.Sber_radio.Name = "Sber_radio";
            this.Sber_radio.Size = new System.Drawing.Size(156, 24);
            this.Sber_radio.TabIndex = 7;
            this.Sber_radio.TabStop = true;
            this.Sber_radio.Text = "Сберегательный";
            this.Sber_radio.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(6, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Тип счёта:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 404);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Save_button);
            this.Name = "Form3";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LName_textBox;
        private System.Windows.Forms.TextBox SName_texBox;
        private System.Windows.Forms.TextBox FName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Blocked_radio;
        private System.Windows.Forms.RadioButton Unblocked_radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton I_bank_OFF_radio;
        private System.Windows.Forms.RadioButton I_bank_ON_radio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PSN_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Mobile_phone_textBox;
        private System.Windows.Forms.RadioButton SMS_OFF_radio;
        private System.Windows.Forms.RadioButton SMS_ON_radio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Rasschet_radio;
        private System.Windows.Forms.RadioButton Nakop_radio;
        private System.Windows.Forms.RadioButton Sber_radio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Birth_date_picker;
    }
}