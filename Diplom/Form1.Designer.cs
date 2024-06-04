namespace Diplom
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
            this.Registration = new System.Windows.Forms.Button();
            this.Authorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(243, 126);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(303, 73);
            this.Registration.TabIndex = 0;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Authorization
            // 
            this.Authorization.Location = new System.Drawing.Point(243, 222);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(303, 73);
            this.Authorization.TabIndex = 1;
            this.Authorization.Text = "Authorization";
            this.Authorization.UseVisualStyleBackColor = true;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.Registration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Authorization;
    }
}

