namespace AfinnCypher
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
            this.in_richTextBox = new System.Windows.Forms.RichTextBox();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.out_richTextBox = new System.Windows.Forms.RichTextBox();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_helper = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_b2 = new System.Windows.Forms.TextBox();
            this.textBox_a2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // in_richTextBox
            // 
            this.in_richTextBox.Location = new System.Drawing.Point(8, 102);
            this.in_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.in_richTextBox.Name = "in_richTextBox";
            this.in_richTextBox.Size = new System.Drawing.Size(756, 76);
            this.in_richTextBox.TabIndex = 0;
            this.in_richTextBox.Text = "";
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(8, 182);
            this.encrypt_button.Margin = new System.Windows.Forms.Padding(2);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(90, 34);
            this.encrypt_button.TabIndex = 1;
            this.encrypt_button.Text = "Шифрование";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // out_richTextBox
            // 
            this.out_richTextBox.Location = new System.Drawing.Point(11, 239);
            this.out_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.out_richTextBox.Name = "out_richTextBox";
            this.out_richTextBox.ReadOnly = true;
            this.out_richTextBox.Size = new System.Drawing.Size(753, 101);
            this.out_richTextBox.TabIndex = 2;
            this.out_richTextBox.Text = "";
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(674, 182);
            this.decrypt_button.Margin = new System.Windows.Forms.Padding(2);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(90, 34);
            this.decrypt_button.TabIndex = 3;
            this.decrypt_button.Text = "Расшифровка";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(34, 10);
            this.textBox_a.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(76, 20);
            this.textBox_a.TabIndex = 4;
            this.textBox_a.Text = "1";
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_a_TextChanged);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(34, 46);
            this.textBox_b.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(76, 20);
            this.textBox_b.TabIndex = 5;
            this.textBox_b.Text = "0";
            this.textBox_b.TextChanged += new System.EventHandler(this.textBox_b_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ввод";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вывод";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(344, 182);
            this.clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(90, 34);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_helper);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(340, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(422, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Алфавит";
            // 
            // label_helper
            // 
            this.label_helper.Location = new System.Drawing.Point(116, 37);
            this.label_helper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_helper.Name = "label_helper";
            this.label_helper.Size = new System.Drawing.Size(302, 48);
            this.label_helper.TabIndex = 2;
            this.label_helper.Text = "Можно взять за \'a\': 1; 3; 5; 7; 9; 11; 15; 17; 19\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBox1.Location = new System.Drawing.Point(4, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Английский";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "b2";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "a2";
            this.label6.Visible = false;
            // 
            // textBox_b2
            // 
            this.textBox_b2.Location = new System.Drawing.Point(148, 46);
            this.textBox_b2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_b2.Name = "textBox_b2";
            this.textBox_b2.Size = new System.Drawing.Size(76, 20);
            this.textBox_b2.TabIndex = 14;
            this.textBox_b2.Text = "0";
            this.textBox_b2.Visible = false;
            this.textBox_b2.TextChanged += new System.EventHandler(this.textBox_b2_TextChanged);
            // 
            // textBox_a2
            // 
            this.textBox_a2.Location = new System.Drawing.Point(148, 10);
            this.textBox_a2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_a2.Name = "textBox_a2";
            this.textBox_a2.Size = new System.Drawing.Size(76, 20);
            this.textBox_a2.TabIndex = 13;
            this.textBox_a2.Text = "1";
            this.textBox_a2.Visible = false;
            this.textBox_a2.TextChanged += new System.EventHandler(this.textBox_a2_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(238, 12);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Обычный";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(238, 48);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Рекуррентный";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 351);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_b2);
            this.Controls.Add(this.textBox_a2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.out_richTextBox);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.in_richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "КМЗИ_КИА_748_Лаб1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.RichTextBox out_richTextBox;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox in_richTextBox;
        private System.Windows.Forms.Label label_helper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_b2;
        private System.Windows.Forms.TextBox textBox_a2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

