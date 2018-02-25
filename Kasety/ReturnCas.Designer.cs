namespace Kasety
{
    partial class ReturnCas
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
            this.index = new System.Windows.Forms.TextBox();
            this.ret = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.personel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz numer kasety:";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(140, 10);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(178, 20);
            this.index.TabIndex = 1;
            // 
            // ret
            // 
            this.ret.Location = new System.Drawing.Point(16, 73);
            this.ret.Name = "ret";
            this.ret.Size = new System.Drawing.Size(75, 23);
            this.ret.TabIndex = 2;
            this.ret.Text = "Oddaj";
            this.ret.UseVisualStyleBackColor = true;
            this.ret.Click += new System.EventHandler(this.ret_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pracownik przyjmujący:";
            // 
            // personel
            // 
            this.personel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personel.FormattingEnabled = true;
            this.personel.Location = new System.Drawing.Point(140, 40);
            this.personel.Name = "personel";
            this.personel.Size = new System.Drawing.Size(178, 21);
            this.personel.TabIndex = 4;
            // 
            // ReturnCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 116);
            this.Controls.Add(this.personel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ret);
            this.Controls.Add(this.index);
            this.Controls.Add(this.label1);
            this.Name = "ReturnCas";
            this.Text = "ReturnCas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Button ret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox personel;
    }
}