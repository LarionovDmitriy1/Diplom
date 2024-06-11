namespace Diplom
{
    partial class ClientQ
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
            this.eat = new System.Windows.Forms.Button();
            this.cleaning = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eat
            // 
            this.eat.Location = new System.Drawing.Point(368, 105);
            this.eat.Name = "eat";
            this.eat.Size = new System.Drawing.Size(114, 34);
            this.eat.TabIndex = 0;
            this.eat.Text = "Доставка еды, напитков в номер";
            this.eat.UseVisualStyleBackColor = true;
            this.eat.Click += new System.EventHandler(this.eat_Click);
            // 
            // cleaning
            // 
            this.cleaning.Location = new System.Drawing.Point(368, 145);
            this.cleaning.Name = "cleaning";
            this.cleaning.Size = new System.Drawing.Size(114, 34);
            this.cleaning.TabIndex = 1;
            this.cleaning.Text = "Уборка номера";
            this.cleaning.UseVisualStyleBackColor = true;
            this.cleaning.Click += new System.EventHandler(this.cleaning_Click);
            // 
            // leave
            // 
            this.leave.Location = new System.Drawing.Point(368, 185);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(114, 34);
            this.leave.TabIndex = 2;
            this.leave.Text = "Съехать с номера";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // ClientQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.cleaning);
            this.Controls.Add(this.eat);
            this.Name = "ClientQ";
            this.Text = "ClientQ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eat;
        private System.Windows.Forms.Button cleaning;
        private System.Windows.Forms.Button leave;
    }
}