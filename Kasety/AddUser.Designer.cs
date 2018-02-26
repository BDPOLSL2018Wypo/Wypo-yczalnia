namespace Kasety
{
    partial class AddUser
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
            this.dodaj = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.ErrName = new System.Windows.Forms.Label();
            this.ErrSName = new System.Windows.Forms.Label();
            this.ErrAddr = new System.Windows.Forms.Label();
            this.ErrBdate = new System.Windows.Forms.Label();
            this.ErrPost = new System.Windows.Forms.Label();
            this.ErrStr = new System.Windows.Forms.Label();
            this.ErrPhone = new System.Windows.Forms.Label();
            this.ErrEmail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(128, 287);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(100, 23);
            this.dodaj.TabIndex = 57;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FormattingEnabled = true;
            this.role.Location = new System.Drawing.Point(128, 247);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(100, 21);
            this.role.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Rola:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Numer telefonu:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(128, 220);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(128, 194);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Kod pocztowy:";
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(128, 168);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(100, 20);
            this.postcode.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ulica:";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(128, 142);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 20);
            this.street.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Adres:";
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(128, 116);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(100, 20);
            this.addr.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Data urodzenia:";
            // 
            // bdate
            // 
            this.bdate.Location = new System.Drawing.Point(128, 77);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(100, 20);
            this.bdate.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nazwisko:";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(128, 51);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Imie:";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(128, 25);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 39;
            // 
            // ErrName
            // 
            this.ErrName.AutoSize = true;
            this.ErrName.ForeColor = System.Drawing.Color.Red;
            this.ErrName.Location = new System.Drawing.Point(235, 28);
            this.ErrName.Name = "ErrName";
            this.ErrName.Size = new System.Drawing.Size(63, 13);
            this.ErrName.TabIndex = 58;
            this.ErrName.Text = "Błędne imie";
            this.ErrName.Visible = false;
            // 
            // ErrSName
            // 
            this.ErrSName.AutoSize = true;
            this.ErrSName.ForeColor = System.Drawing.Color.Red;
            this.ErrSName.Location = new System.Drawing.Point(234, 54);
            this.ErrSName.Name = "ErrSName";
            this.ErrSName.Size = new System.Drawing.Size(89, 13);
            this.ErrSName.TabIndex = 59;
            this.ErrSName.Text = "Błędne nazwisko";
            this.ErrSName.Visible = false;
            // 
            // ErrAddr
            // 
            this.ErrAddr.AutoSize = true;
            this.ErrAddr.ForeColor = System.Drawing.Color.Red;
            this.ErrAddr.Location = new System.Drawing.Point(234, 119);
            this.ErrAddr.Name = "ErrAddr";
            this.ErrAddr.Size = new System.Drawing.Size(70, 13);
            this.ErrAddr.TabIndex = 61;
            this.ErrAddr.Text = "Błędny adres";
            this.ErrAddr.Visible = false;
            this.ErrAddr.Click += new System.EventHandler(this.ErrAddr_Click);
            // 
            // ErrBdate
            // 
            this.ErrBdate.AutoSize = true;
            this.ErrBdate.ForeColor = System.Drawing.Color.Red;
            this.ErrBdate.Location = new System.Drawing.Point(235, 80);
            this.ErrBdate.Name = "ErrBdate";
            this.ErrBdate.Size = new System.Drawing.Size(115, 13);
            this.ErrBdate.TabIndex = 60;
            this.ErrBdate.Text = "Błędna data urodzenia";
            this.ErrBdate.Visible = false;
            // 
            // ErrPost
            // 
            this.ErrPost.AutoSize = true;
            this.ErrPost.ForeColor = System.Drawing.Color.Red;
            this.ErrPost.Location = new System.Drawing.Point(233, 171);
            this.ErrPost.Name = "ErrPost";
            this.ErrPost.Size = new System.Drawing.Size(110, 13);
            this.ErrPost.TabIndex = 63;
            this.ErrPost.Text = "Błędny kod pocztowy";
            this.ErrPost.Visible = false;
            // 
            // ErrStr
            // 
            this.ErrStr.AutoSize = true;
            this.ErrStr.ForeColor = System.Drawing.Color.Red;
            this.ErrStr.Location = new System.Drawing.Point(234, 145);
            this.ErrStr.Name = "ErrStr";
            this.ErrStr.Size = new System.Drawing.Size(67, 13);
            this.ErrStr.TabIndex = 62;
            this.ErrStr.Text = "Błędna ulica";
            this.ErrStr.Visible = false;
            // 
            // ErrPhone
            // 
            this.ErrPhone.AutoSize = true;
            this.ErrPhone.ForeColor = System.Drawing.Color.Red;
            this.ErrPhone.Location = new System.Drawing.Point(234, 223);
            this.ErrPhone.Name = "ErrPhone";
            this.ErrPhone.Size = new System.Drawing.Size(114, 13);
            this.ErrPhone.TabIndex = 65;
            this.ErrPhone.Text = "Błędny numer telefonu";
            this.ErrPhone.Visible = false;
            // 
            // ErrEmail
            // 
            this.ErrEmail.AutoSize = true;
            this.ErrEmail.ForeColor = System.Drawing.Color.Red;
            this.ErrEmail.Location = new System.Drawing.Point(235, 197);
            this.ErrEmail.Name = "ErrEmail";
            this.ErrEmail.Size = new System.Drawing.Size(68, 13);
            this.ErrEmail.TabIndex = 64;
            this.ErrEmail.Text = "Błędny email";
            this.ErrEmail.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Format DD.MM.YYYY";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 330);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ErrPhone);
            this.Controls.Add(this.ErrEmail);
            this.Controls.Add(this.ErrPost);
            this.Controls.Add(this.ErrStr);
            this.Controls.Add(this.ErrAddr);
            this.Controls.Add(this.ErrBdate);
            this.Controls.Add(this.ErrSName);
            this.Controls.Add(this.ErrName);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.street);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstname);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label ErrName;
        private System.Windows.Forms.Label ErrSName;
        private System.Windows.Forms.Label ErrAddr;
        private System.Windows.Forms.Label ErrBdate;
        private System.Windows.Forms.Label ErrPost;
        private System.Windows.Forms.Label ErrStr;
        private System.Windows.Forms.Label ErrPhone;
        private System.Windows.Forms.Label ErrEmail;
        private System.Windows.Forms.Label label11;
    }
}