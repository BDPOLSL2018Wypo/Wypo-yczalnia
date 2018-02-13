namespace Kasety
{
    partial class FormDodajKasete
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
            this.button1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.TextBox();
            this.AgeCat = new System.Windows.Forms.ComboBox();
            this.DirectorName = new System.Windows.Forms.TextBox();
            this.DirectorLastname = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.TitleErr = new System.Windows.Forms.Label();
            this.GenreErr = new System.Windows.Forms.Label();
            this.DirNameErr = new System.Windows.Forms.Label();
            this.DirLNameErr = new System.Windows.Forms.Label();
            this.PriceErr = new System.Windows.Forms.Label();
            this.labout = new System.Windows.Forms.Label();
            this.AgeCatErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj kasete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(149, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 2;
            this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gatunek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategoria wiekowa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Imie reżysera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nazwisko reżysera:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cena:";
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(149, 41);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(100, 20);
            this.Genre.TabIndex = 8;
            // 
            // AgeCat
            // 
            this.AgeCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeCat.FormattingEnabled = true;
            this.AgeCat.Location = new System.Drawing.Point(149, 75);
            this.AgeCat.Name = "AgeCat";
            this.AgeCat.Size = new System.Drawing.Size(121, 21);
            this.AgeCat.TabIndex = 9;
            // 
            // DirectorName
            // 
            this.DirectorName.Location = new System.Drawing.Point(149, 108);
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.Size = new System.Drawing.Size(100, 20);
            this.DirectorName.TabIndex = 10;
            // 
            // DirectorLastname
            // 
            this.DirectorLastname.Location = new System.Drawing.Point(149, 138);
            this.DirectorLastname.Name = "DirectorLastname";
            this.DirectorLastname.Size = new System.Drawing.Size(100, 20);
            this.DirectorLastname.TabIndex = 11;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(149, 171);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 12;
            // 
            // TitleErr
            // 
            this.TitleErr.AutoSize = true;
            this.TitleErr.ForeColor = System.Drawing.Color.Red;
            this.TitleErr.Location = new System.Drawing.Point(256, 20);
            this.TitleErr.Name = "TitleErr";
            this.TitleErr.Size = new System.Drawing.Size(60, 13);
            this.TitleErr.TabIndex = 13;
            this.TitleErr.Text = "Błąd tytułu";
            this.TitleErr.Visible = false;
            // 
            // GenreErr
            // 
            this.GenreErr.AutoSize = true;
            this.GenreErr.ForeColor = System.Drawing.Color.Red;
            this.GenreErr.Location = new System.Drawing.Point(256, 44);
            this.GenreErr.Name = "GenreErr";
            this.GenreErr.Size = new System.Drawing.Size(72, 13);
            this.GenreErr.TabIndex = 14;
            this.GenreErr.Text = "Błąd gatunku";
            this.GenreErr.Visible = false;
            // 
            // DirNameErr
            // 
            this.DirNameErr.AutoSize = true;
            this.DirNameErr.ForeColor = System.Drawing.Color.Red;
            this.DirNameErr.Location = new System.Drawing.Point(256, 108);
            this.DirNameErr.Name = "DirNameErr";
            this.DirNameErr.Size = new System.Drawing.Size(107, 13);
            this.DirNameErr.TabIndex = 15;
            this.DirNameErr.Text = "Błąd imienia reżysera";
            this.DirNameErr.Visible = false;
            // 
            // DirLNameErr
            // 
            this.DirLNameErr.AutoSize = true;
            this.DirLNameErr.ForeColor = System.Drawing.Color.Red;
            this.DirLNameErr.Location = new System.Drawing.Point(256, 138);
            this.DirLNameErr.Name = "DirLNameErr";
            this.DirLNameErr.Size = new System.Drawing.Size(119, 13);
            this.DirLNameErr.TabIndex = 16;
            this.DirLNameErr.Text = "Błąd nazwiska reżysera";
            this.DirLNameErr.Visible = false;
            // 
            // PriceErr
            // 
            this.PriceErr.AutoSize = true;
            this.PriceErr.ForeColor = System.Drawing.Color.Red;
            this.PriceErr.Location = new System.Drawing.Point(259, 171);
            this.PriceErr.Name = "PriceErr";
            this.PriceErr.Size = new System.Drawing.Size(56, 13);
            this.PriceErr.TabIndex = 17;
            this.PriceErr.Text = "Błąd ceny";
            this.PriceErr.Visible = false;
            // 
            // labout
            // 
            this.labout.AutoSize = true;
            this.labout.Location = new System.Drawing.Point(169, 226);
            this.labout.Name = "labout";
            this.labout.Size = new System.Drawing.Size(0, 13);
            this.labout.TabIndex = 18;
            // 
            // AgeCatErr
            // 
            this.AgeCatErr.AutoSize = true;
            this.AgeCatErr.ForeColor = System.Drawing.Color.Red;
            this.AgeCatErr.Location = new System.Drawing.Point(277, 75);
            this.AgeCatErr.Name = "AgeCatErr";
            this.AgeCatErr.Size = new System.Drawing.Size(120, 13);
            this.AgeCatErr.TabIndex = 19;
            this.AgeCatErr.Text = "Błąd kategorii wiekowej";
            this.AgeCatErr.Visible = false;
            // 
            // FormDodajKasete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.AgeCatErr);
            this.Controls.Add(this.labout);
            this.Controls.Add(this.PriceErr);
            this.Controls.Add(this.DirLNameErr);
            this.Controls.Add(this.DirNameErr);
            this.Controls.Add(this.GenreErr);
            this.Controls.Add(this.TitleErr);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.DirectorLastname);
            this.Controls.Add(this.DirectorName);
            this.Controls.Add(this.AgeCat);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajKasete";
            this.Text = "FormDodajKasete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.ComboBox AgeCat;
        private System.Windows.Forms.TextBox DirectorName;
        private System.Windows.Forms.TextBox DirectorLastname;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label TitleErr;
        private System.Windows.Forms.Label GenreErr;
        private System.Windows.Forms.Label DirNameErr;
        private System.Windows.Forms.Label DirLNameErr;
        private System.Windows.Forms.Label PriceErr;
        private System.Windows.Forms.Label labout;
        private System.Windows.Forms.Label AgeCatErr;
    }
}