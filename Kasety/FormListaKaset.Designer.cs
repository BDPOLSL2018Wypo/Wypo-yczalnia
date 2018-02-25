namespace Kasety
{
    partial class FormListaKaset
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
            this.Lista = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.TextBox();
            this.Finder = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wyp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista.Location = new System.Drawing.Point(13, 88);
            this.Lista.Name = "Lista";
            this.Lista.ReadOnly = true;
            this.Lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Lista.Size = new System.Drawing.Size(1128, 325);
            this.Lista.TabIndex = 0;
            this.Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_CellContentClick);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(13, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(156, 20);
            this.title.TabIndex = 1;
            // 
            // Finder
            // 
            this.Finder.Location = new System.Drawing.Point(13, 49);
            this.Finder.Name = "Finder";
            this.Finder.Size = new System.Drawing.Size(75, 23);
            this.Finder.TabIndex = 2;
            this.Finder.Text = "Znajdź";
            this.Finder.UseVisualStyleBackColor = true;
            this.Finder.Click += new System.EventHandler(this.Finder_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(94, 49);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Resetuj";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // wyp
            // 
            this.wyp.Location = new System.Drawing.Point(178, 49);
            this.wyp.Name = "wyp";
            this.wyp.Size = new System.Drawing.Size(143, 23);
            this.wyp.TabIndex = 5;
            this.wyp.Text = "Wypożycz wybrane tytuły";
            this.wyp.UseVisualStyleBackColor = true;
            this.wyp.Click += new System.EventHandler(this.wyp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zabookowane kasety:";
            // 
            // FormListaKaset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1154, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wyp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Finder);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Lista);
            this.Name = "FormListaKaset";
            this.Text = "FormListaKaset";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListaKaset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button Finder;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wyp;
        private System.Windows.Forms.Label label2;
    }
}