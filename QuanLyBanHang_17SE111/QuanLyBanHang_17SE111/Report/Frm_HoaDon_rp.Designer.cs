﻿namespace QuanLyBanHang_17SE111.Report
{
    partial class Frm_HoaDon_rp
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
            this.rpVHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpVHoaDon
            // 
            this.rpVHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpVHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpVHoaDon.Name = "ReportViewer";
            this.rpVHoaDon.Size = new System.Drawing.Size(396, 246);
            this.rpVHoaDon.TabIndex = 0;
            // 
            // Frm_HoaDon_rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Frm_HoaDon_rp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HoaDon_rp";
            this.Load += new System.EventHandler(this.Frm_HoaDon_rp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpVHoaDon;
    }
}