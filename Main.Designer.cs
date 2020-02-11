namespace BANK
{
    partial class Main
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
            this.AddCardBtn = new System.Windows.Forms.Button();
            this.UseCardBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCardBtn
            // 
            this.AddCardBtn.Location = new System.Drawing.Point(147, 82);
            this.AddCardBtn.Name = "AddCardBtn";
            this.AddCardBtn.Size = new System.Drawing.Size(110, 39);
            this.AddCardBtn.TabIndex = 0;
            this.AddCardBtn.Text = "Зарегестрировать карту";
            this.AddCardBtn.UseVisualStyleBackColor = true;
            this.AddCardBtn.Click += new System.EventHandler(this.AddCardBtn_Click);
            // 
            // UseCardBtn
            // 
            this.UseCardBtn.Location = new System.Drawing.Point(522, 82);
            this.UseCardBtn.Name = "UseCardBtn";
            this.UseCardBtn.Size = new System.Drawing.Size(110, 39);
            this.UseCardBtn.TabIndex = 1;
            this.UseCardBtn.Text = "Использовать карту\r\n";
            this.UseCardBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(319, 334);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(110, 39);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 565);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.UseCardBtn);
            this.Controls.Add(this.AddCardBtn);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCardBtn;
        private System.Windows.Forms.Button UseCardBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}