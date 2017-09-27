namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_account = new System.Windows.Forms.Button();
            this.change_ip = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create_account
            // 
            this.create_account.BackColor = System.Drawing.SystemColors.ControlDark;
            this.create_account.Location = new System.Drawing.Point(153, 12);
            this.create_account.Name = "create_account";
            this.create_account.Size = new System.Drawing.Size(111, 50);
            this.create_account.TabIndex = 0;
            this.create_account.Text = "Наебашить аков";
            this.create_account.UseVisualStyleBackColor = false;
            this.create_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // change_ip
            // 
            this.change_ip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.change_ip.Location = new System.Drawing.Point(12, 12);
            this.change_ip.Name = "change_ip";
            this.change_ip.Size = new System.Drawing.Size(113, 50);
            this.change_ip.TabIndex = 1;
            this.change_ip.Text = "Выбор файла с прокси";
            this.change_ip.UseVisualStyleBackColor = false;
            this.change_ip.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 182);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 383);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.change_ip);
            this.Controls.Add(this.create_account);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_account;
        private System.Windows.Forms.Button change_ip;
        private System.Windows.Forms.TextBox textBox1;
    }
}

