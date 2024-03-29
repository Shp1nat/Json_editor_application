namespace _4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.update = new System.Windows.Forms.Button();
            this.dobavlenie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clearall = new System.Windows.Forms.Button();
            this.exittheprog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(196, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 342);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(351, 96);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 342);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(508, 96);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 342);
            this.listBox3.TabIndex = 2;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(660, 96);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 91);
            this.update.TabIndex = 3;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dobavlenie
            // 
            this.dobavlenie.Location = new System.Drawing.Point(62, 54);
            this.dobavlenie.Name = "dobavlenie";
            this.dobavlenie.Size = new System.Drawing.Size(114, 36);
            this.dobavlenie.TabIndex = 4;
            this.dobavlenie.Text = "Добавить";
            this.dobavlenie.UseVisualStyleBackColor = true;
            this.dobavlenie.Click += new System.EventHandler(this.dobavlenie_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(508, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 7;
            // 
            // clearall
            // 
            this.clearall.Location = new System.Drawing.Point(660, 220);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(114, 91);
            this.clearall.TabIndex = 8;
            this.clearall.Text = "Очистить";
            this.clearall.UseVisualStyleBackColor = true;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // exittheprog
            // 
            this.exittheprog.Location = new System.Drawing.Point(660, 347);
            this.exittheprog.Name = "exittheprog";
            this.exittheprog.Size = new System.Drawing.Size(114, 91);
            this.exittheprog.TabIndex = 9;
            this.exittheprog.Text = "Выход";
            this.exittheprog.UseVisualStyleBackColor = true;
            this.exittheprog.Click += new System.EventHandler(this.exittheprog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 634);
            this.Controls.Add(this.exittheprog);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dobavlenie);
            this.Controls.Add(this.update);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button dobavlenie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button exittheprog;
    }
}

