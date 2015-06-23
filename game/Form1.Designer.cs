namespace game
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
            this.Start = new System.Windows.Forms.Button();
            this.UI1 = new System.Windows.Forms.Button();
            this.UI2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(-1, -2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // UI1
            // 
            this.UI1.Location = new System.Drawing.Point(94, -2);
            this.UI1.Name = "UI1";
            this.UI1.Size = new System.Drawing.Size(75, 23);
            this.UI1.TabIndex = 1;
            this.UI1.Text = "1способ";
            this.UI1.UseVisualStyleBackColor = true;
            this.UI1.Click += new System.EventHandler(this.UI1_Click);
            // 
            // UI2
            // 
            this.UI2.Location = new System.Drawing.Point(190, -2);
            this.UI2.Name = "UI2";
            this.UI2.Size = new System.Drawing.Size(75, 23);
            this.UI2.TabIndex = 2;
            this.UI2.Text = "2способ";
            this.UI2.UseVisualStyleBackColor = true;
            this.UI2.Click += new System.EventHandler(this.UI2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 317);
            this.Controls.Add(this.UI2);
            this.Controls.Add(this.UI1);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button UI1;
        private System.Windows.Forms.Button UI2;
    }
}

