namespace Kasety
{
    partial class addToQueue
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
            this.users = new System.Windows.Forms.ComboBox();
            this.doQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz użytkownika:";
            // 
            // users
            // 
            this.users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.users.FormattingEnabled = true;
            this.users.Location = new System.Drawing.Point(16, 30);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(256, 21);
            this.users.TabIndex = 1;
            // 
            // doQueue
            // 
            this.doQueue.Location = new System.Drawing.Point(16, 58);
            this.doQueue.Name = "doQueue";
            this.doQueue.Size = new System.Drawing.Size(256, 23);
            this.doQueue.TabIndex = 2;
            this.doQueue.Text = "Zakolejkuj";
            this.doQueue.UseVisualStyleBackColor = true;
            this.doQueue.Click += new System.EventHandler(this.doQueue_Click);
            // 
            // addToQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 90);
            this.Controls.Add(this.doQueue);
            this.Controls.Add(this.users);
            this.Controls.Add(this.label1);
            this.Name = "addToQueue";
            this.Text = "addToQueue";
            this.Load += new System.EventHandler(this.addToQueue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox users;
        private System.Windows.Forms.Button doQueue;
    }
}