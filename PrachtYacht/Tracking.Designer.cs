﻿namespace PrachtYacht
{
    partial class Tracking
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
            this.wbMapsBrowse = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbMapsBrowse
            // 
            this.wbMapsBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMapsBrowse.Location = new System.Drawing.Point(0, 0);
            this.wbMapsBrowse.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMapsBrowse.Name = "wbMapsBrowse";
            this.wbMapsBrowse.Size = new System.Drawing.Size(984, 555);
            this.wbMapsBrowse.TabIndex = 0;
            // 
            // Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 555);
            this.Controls.Add(this.wbMapsBrowse);
            this.Name = "Tracking";
            this.Text = "Tracking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMapsBrowse;
    }
}