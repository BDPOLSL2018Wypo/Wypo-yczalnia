namespace Kasety
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.TextBox();
            this.punish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.daysErr = new System.Windows.Forms.Label();
            this.punishErr = new System.Windows.Forms.Label();
            this.Saved = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dni do zwrotu:";
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(94, 59);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(100, 20);
            this.days.TabIndex = 2;
            // 
            // punish
            // 
            this.punish.Location = new System.Drawing.Point(94, 23);
            this.punish.Name = "punish";
            this.punish.Size = new System.Drawing.Size(100, 20);
            this.punish.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zapisz ustawienia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // daysErr
            // 
            this.daysErr.AutoSize = true;
            this.daysErr.ForeColor = System.Drawing.Color.Red;
            this.daysErr.Location = new System.Drawing.Point(235, 65);
            this.daysErr.Name = "daysErr";
            this.daysErr.Size = new System.Drawing.Size(30, 13);
            this.daysErr.TabIndex = 6;
            this.daysErr.Text = "Błąd";
            this.daysErr.Visible = false;
            // 
            // punishErr
            // 
            this.punishErr.AutoSize = true;
            this.punishErr.ForeColor = System.Drawing.Color.Red;
            this.punishErr.Location = new System.Drawing.Point(235, 26);
            this.punishErr.Name = "punishErr";
            this.punishErr.Size = new System.Drawing.Size(30, 13);
            this.punishErr.TabIndex = 7;
            this.punishErr.Text = "Błąd";
            this.punishErr.Visible = false;
            // 
            // Saved
            // 
            this.Saved.AutoSize = true;
            this.Saved.ForeColor = System.Drawing.Color.Green;
            this.Saved.Location = new System.Drawing.Point(200, 102);
            this.Saved.Name = "Saved";
            this.Saved.Size = new System.Drawing.Size(104, 13);
            this.Saved.TabIndex = 8;
            this.Saved.Text = "Zapisano ustawienia";
            this.Saved.Visible = false;
            // 
            // err
            // 
            this.err.AutoSize = true;
            this.err.ForeColor = System.Drawing.Color.Red;
            this.err.Location = new System.Drawing.Point(201, 102);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(30, 13);
            this.err.TabIndex = 9;
            this.err.Text = "Błąd";
            this.err.Visible = false;
            this.err.Click += new System.EventHandler(this.err_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 137);
            this.Controls.Add(this.err);
            this.Controls.Add(this.Saved);
            this.Controls.Add(this.punishErr);
            this.Controls.Add(this.daysErr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.punish);
            this.Controls.Add(this.days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.TextBox punish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label daysErr;
        private System.Windows.Forms.Label punishErr;
        private System.Windows.Forms.Label Saved;
        private System.Windows.Forms.Label err;
    }
}