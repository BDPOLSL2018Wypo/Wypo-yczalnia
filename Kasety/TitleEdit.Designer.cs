﻿namespace Kasety
{
    partial class TitleEdit
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
            this.TitleList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TitleList)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleList
            // 
            this.TitleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TitleList.Location = new System.Drawing.Point(3, 12);
            this.TitleList.Name = "TitleList";
            this.TitleList.ReadOnly = true;
            this.TitleList.Size = new System.Drawing.Size(1147, 446);
            this.TitleList.TabIndex = 0;
            this.TitleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TitleList_CellContentClick);
            // 
            // TitleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 470);
            this.Controls.Add(this.TitleList);
            this.Name = "TitleEdit";
            this.Text = "TitleEdit";
            this.Load += new System.EventHandler(this.TitleEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TitleList;
    }
}