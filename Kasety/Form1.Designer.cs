namespace Kasety
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddCassette = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddCassette
            // 
            this.AddCassette.Location = new System.Drawing.Point(140, 30);
            this.AddCassette.Name = "AddCassette";
            this.AddCassette.Size = new System.Drawing.Size(114, 23);
            this.AddCassette.TabIndex = 1;
            this.AddCassette.Text = "Dodaj kasete";
            this.AddCassette.UseVisualStyleBackColor = true;
            this.AddCassette.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(140, 88);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(114, 23);
            this.AddUser.TabIndex = 2;
            this.AddUser.Text = "Dodaj użytkownika";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(140, 118);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(114, 23);
            this.List.TabIndex = 3;
            this.List.Text = "Wyświetl kasety";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.button3_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(140, 59);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(114, 23);
            this.Users.TabIndex = 4;
            this.Users.Text = "Lista użytkowników";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(140, 148);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(114, 23);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Ustawienia";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Ustawienia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 345);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.List);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.AddCassette);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddCassette;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Settings;
    }
}

