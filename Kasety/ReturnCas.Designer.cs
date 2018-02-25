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
            this.nrErr = new System.Windows.Forms.Label();
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
            // nrErr
            // 
            this.nrErr.AutoSize = true;
            this.nrErr.ForeColor = System.Drawing.Color.Red;
            this.nrErr.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.nrErr.Location = new System.Drawing.Point(325, 13);
            this.nrErr.Name = "nrErr";
            this.nrErr.Size = new System.Drawing.Size(107, 13);
            this.nrErr.TabIndex = 5;
            this.nrErr.Text = "Błędny numer kasety";
            this.nrErr.Visible = false;
            // 
            // ReturnCas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 116);
            this.Controls.Add(this.nrErr);
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
        private System.Windows.Forms.Label nrErr;
    }
}