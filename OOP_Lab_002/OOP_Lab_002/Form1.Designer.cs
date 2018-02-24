namespace OOP_Lab_002
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Schet_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Remove_button = new System.Windows.Forms.Button();
            this.Info_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.JSON_Im_button = new System.Windows.Forms.Button();
            this.JSON_Ex_button = new System.Windows.Forms.Button();
            this.Operations_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Schet_listBox
            // 
            this.Schet_listBox.FormattingEnabled = true;
            this.Schet_listBox.ItemHeight = 20;
            this.Schet_listBox.Location = new System.Drawing.Point(80, 36);
            this.Schet_listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Schet_listBox.Name = "Schet_listBox";
            this.Schet_listBox.Size = new System.Drawing.Size(213, 344);
            this.Schet_listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список банковских счетов:";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(311, 36);
            this.Add_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(188, 46);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(311, 91);
            this.Remove_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(188, 46);
            this.Remove_button.TabIndex = 3;
            this.Remove_button.Text = "Удалить";
            this.Remove_button.UseVisualStyleBackColor = true;
            // 
            // Info_button
            // 
            this.Info_button.Location = new System.Drawing.Point(311, 147);
            this.Info_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Info_button.Name = "Info_button";
            this.Info_button.Size = new System.Drawing.Size(188, 46);
            this.Info_button.TabIndex = 4;
            this.Info_button.Text = "Информация";
            this.Info_button.UseVisualStyleBackColor = true;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(311, 203);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(188, 46);
            this.Edit_button.TabIndex = 5;
            this.Edit_button.Text = "Редактировать";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // JSON_Im_button
            // 
            this.JSON_Im_button.Location = new System.Drawing.Point(311, 352);
            this.JSON_Im_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JSON_Im_button.Name = "JSON_Im_button";
            this.JSON_Im_button.Size = new System.Drawing.Size(295, 26);
            this.JSON_Im_button.TabIndex = 6;
            this.JSON_Im_button.Text = "Импорт из JSON-файла";
            this.JSON_Im_button.UseVisualStyleBackColor = true;
            // 
            // JSON_Ex_button
            // 
            this.JSON_Ex_button.Location = new System.Drawing.Point(311, 315);
            this.JSON_Ex_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JSON_Ex_button.Name = "JSON_Ex_button";
            this.JSON_Ex_button.Size = new System.Drawing.Size(295, 27);
            this.JSON_Ex_button.TabIndex = 7;
            this.JSON_Ex_button.Text = "Экспорт в JSON-файл";
            this.JSON_Ex_button.UseVisualStyleBackColor = true;
            // 
            // Operations_button
            // 
            this.Operations_button.Location = new System.Drawing.Point(311, 259);
            this.Operations_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Operations_button.Name = "Operations_button";
            this.Operations_button.Size = new System.Drawing.Size(188, 46);
            this.Operations_button.TabIndex = 8;
            this.Operations_button.Text = "Операции со счётом";
            this.Operations_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 413);
            this.Controls.Add(this.Operations_button);
            this.Controls.Add(this.JSON_Ex_button);
            this.Controls.Add(this.JSON_Im_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Info_button);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Schet_listBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Schet_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.Button Info_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button JSON_Im_button;
        private System.Windows.Forms.Button JSON_Ex_button;
        private System.Windows.Forms.Button Operations_button;
    }
}

