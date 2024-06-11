namespace Diplom
{
    partial class Eat
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
            this.label1 = new System.Windows.Forms.Label();
            this.eatButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.Alcho = new System.Windows.Forms.Button();
            this.eatLabel = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.alchoLabel = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // eatButton
            // 
            this.eatButton.Location = new System.Drawing.Point(331, 154);
            this.eatButton.Name = "eatButton";
            this.eatButton.Size = new System.Drawing.Size(138, 38);
            this.eatButton.TabIndex = 1;
            this.eatButton.Text = "Еда";
            this.eatButton.UseVisualStyleBackColor = true;
            this.eatButton.Click += new System.EventHandler(this.eatButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.Location = new System.Drawing.Point(331, 198);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(138, 38);
            this.waterButton.TabIndex = 2;
            this.waterButton.Text = "Напитки";
            this.waterButton.UseVisualStyleBackColor = true;
            this.waterButton.Click += new System.EventHandler(this.waterButton_Click);
            // 
            // Alcho
            // 
            this.Alcho.Location = new System.Drawing.Point(331, 242);
            this.Alcho.Name = "Alcho";
            this.Alcho.Size = new System.Drawing.Size(138, 38);
            this.Alcho.TabIndex = 3;
            this.Alcho.Text = "Коктейли";
            this.Alcho.UseVisualStyleBackColor = true;
            this.Alcho.Click += new System.EventHandler(this.Alcho_Click);
            // 
            // eatLabel
            // 
            this.eatLabel.AutoSize = true;
            this.eatLabel.Location = new System.Drawing.Point(475, 167);
            this.eatLabel.Name = "eatLabel";
            this.eatLabel.Size = new System.Drawing.Size(104, 13);
            this.eatLabel.TabIndex = 4;
            this.eatLabel.Text = "0 товаров выбрано";
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Location = new System.Drawing.Point(475, 211);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(104, 13);
            this.waterLabel.TabIndex = 5;
            this.waterLabel.Text = "0 товаров выбрано";
            // 
            // alchoLabel
            // 
            this.alchoLabel.AutoSize = true;
            this.alchoLabel.Location = new System.Drawing.Point(475, 255);
            this.alchoLabel.Name = "alchoLabel";
            this.alchoLabel.Size = new System.Drawing.Size(104, 13);
            this.alchoLabel.TabIndex = 6;
            this.alchoLabel.Text = "0 товаров выбрано";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(363, 374);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 7;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Eat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.alchoLabel);
            this.Controls.Add(this.waterLabel);
            this.Controls.Add(this.eatLabel);
            this.Controls.Add(this.Alcho);
            this.Controls.Add(this.waterButton);
            this.Controls.Add(this.eatButton);
            this.Controls.Add(this.label1);
            this.Name = "Eat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eatButton;
        private System.Windows.Forms.Button waterButton;
        private System.Windows.Forms.Button Alcho;
        private System.Windows.Forms.Label eatLabel;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label alchoLabel;
        private System.Windows.Forms.Button confirm;
    }
}