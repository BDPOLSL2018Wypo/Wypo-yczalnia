﻿namespace Kasety
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddCassette = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.returning = new System.Windows.Forms.Button();
            this.Queue = new System.Windows.Forms.Button();
            this.EditTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCassette
            // 
            this.AddCassette.Location = new System.Drawing.Point(12, 12);
            this.AddCassette.Name = "AddCassette";
            this.AddCassette.Size = new System.Drawing.Size(114, 23);
            this.AddCassette.TabIndex = 1;
            this.AddCassette.Text = "Dodaj kasete";
            this.AddCassette.UseVisualStyleBackColor = true;
            this.AddCassette.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(140, 41);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(114, 23);
            this.AddUser.TabIndex = 2;
            this.AddUser.Text = "Dodaj użytkownika";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(12, 41);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(114, 23);
            this.List.TabIndex = 3;
            this.List.Text = "Wyświetl kasety";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.button3_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(140, 12);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(114, 23);
            this.Users.TabIndex = 4;
            this.Users.Text = "Lista użytkowników";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(140, 99);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(114, 23);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Ustawienia";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Ustawienia_Click);
            // 
            // returning
            // 
            this.returning.Location = new System.Drawing.Point(12, 70);
            this.returning.Name = "returning";
            this.returning.Size = new System.Drawing.Size(114, 23);
            this.returning.TabIndex = 6;
            this.returning.Text = "Oddanie";
            this.returning.UseVisualStyleBackColor = true;
            this.returning.Click += new System.EventHandler(this.returning_Click);
            // 
            // Queue
            // 
            this.Queue.Location = new System.Drawing.Point(12, 99);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(114, 23);
            this.Queue.TabIndex = 7;
            this.Queue.Text = "Kolejka";
            this.Queue.UseVisualStyleBackColor = true;
            this.Queue.Click += new System.EventHandler(this.Queue_Click);
            // 
            // EditTitle
            // 
            this.EditTitle.Location = new System.Drawing.Point(140, 70);
            this.EditTitle.Name = "EditTitle";
            this.EditTitle.Size = new System.Drawing.Size(114, 23);
            this.EditTitle.TabIndex = 8;
            this.EditTitle.Text = "Edytuj Tytuły";
            this.EditTitle.UseVisualStyleBackColor = true;
            this.EditTitle.Click += new System.EventHandler(this.EditTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 142);
            this.Controls.Add(this.EditTitle);
            this.Controls.Add(this.Queue);
            this.Controls.Add(this.returning);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.List);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.AddCassette);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddCassette;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button returning;
        private System.Windows.Forms.Button Queue;
        private System.Windows.Forms.Button EditTitle;
    }
}

