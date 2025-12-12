using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai10
{
    partial class Form1
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
            this.lblDashStyle = new System.Windows.Forms.Label();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cboWidth = new System.Windows.Forms.ComboBox();
            this.lblLineJoin = new System.Windows.Forms.Label();
            this.cboLineJoin = new System.Windows.Forms.ComboBox();
            this.lblDashCap = new System.Windows.Forms.Label();
            this.cboDashCap = new System.Windows.Forms.ComboBox();
            this.lblStartCap = new System.Windows.Forms.Label();
            this.cboStartCap = new System.Windows.Forms.ComboBox();
            this.lblEndCap = new System.Windows.Forms.Label();
            this.cboEndCap = new System.Windows.Forms.ComboBox();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDashStyle
            // 
            this.lblDashStyle.AutoSize = true;
            this.lblDashStyle.Location = new System.Drawing.Point(27, 31);
            this.lblDashStyle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashStyle.Name = "lblDashStyle";
            this.lblDashStyle.Size = new System.Drawing.Size(75, 16);
            this.lblDashStyle.TabIndex = 0;
            this.lblDashStyle.Text = "Dash Style:";
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.cboDashStyle.Location = new System.Drawing.Point(133, 25);
            this.cboDashStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(199, 24);
            this.cboDashStyle.TabIndex = 1;
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.ComboChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(27, 80);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 16);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // cboWidth
            // 
            this.cboWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWidth.FormattingEnabled = true;
            this.cboWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "8",
            "10",
            "15",
            "20"});
            this.cboWidth.Location = new System.Drawing.Point(133, 74);
            this.cboWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboWidth.Name = "cboWidth";
            this.cboWidth.Size = new System.Drawing.Size(199, 24);
            this.cboWidth.TabIndex = 3;
            this.cboWidth.SelectedIndexChanged += new System.EventHandler(this.ComboChanged);
            // 
            // lblLineJoin
            // 
            this.lblLineJoin.AutoSize = true;
            this.lblLineJoin.Location = new System.Drawing.Point(27, 129);
            this.lblLineJoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLineJoin.Name = "lblLineJoin";
            this.lblLineJoin.Size = new System.Drawing.Size(63, 16);
            this.lblLineJoin.TabIndex = 4;
            this.lblLineJoin.Text = "Line Join:";
            // 
            // cboLineJoin
            // 
            this.cboLineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineJoin.FormattingEnabled = true;
            this.cboLineJoin.Items.AddRange(new object[] {
            "Miter",
            "Bevel",
            "Round",
            "MiterClipped"});
            this.cboLineJoin.Location = new System.Drawing.Point(133, 123);
            this.cboLineJoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLineJoin.Name = "cboLineJoin";
            this.cboLineJoin.Size = new System.Drawing.Size(199, 24);
            this.cboLineJoin.TabIndex = 5;
            this.cboLineJoin.SelectedIndexChanged += new System.EventHandler(this.ComboChanged);
            // 
            // lblDashCap
            // 
            this.lblDashCap.AutoSize = true;
            this.lblDashCap.Location = new System.Drawing.Point(27, 178);
            this.lblDashCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashCap.Name = "lblDashCap";
            this.lblDashCap.Size = new System.Drawing.Size(70, 16);
            this.lblDashCap.TabIndex = 6;
            this.lblDashCap.Text = "Dash Cap:";
            // 
            // cboDashCap
            // 
            this.cboDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashCap.FormattingEnabled = true;
            this.cboDashCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Triangle"});
            this.cboDashCap.Location = new System.Drawing.Point(133, 172);
            this.cboDashCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDashCap.Name = "cboDashCap";
            this.cboDashCap.Size = new System.Drawing.Size(199, 24);
            this.cboDashCap.TabIndex = 7;
            this.cboDashCap.SelectedIndexChanged += new System.EventHandler(this.ComboChanged);
            // 
            // lblStartCap
            // 
            this.lblStartCap.AutoSize = true;
            this.lblStartCap.Location = new System.Drawing.Point(27, 228);
            this.lblStartCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartCap.Name = "lblStartCap";
            this.lblStartCap.Size = new System.Drawing.Size(65, 16);
            this.lblStartCap.TabIndex = 8;
            this.lblStartCap.Text = "Start Cap:";
            // 
            // cboStartCap
            // 
            this.cboStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartCap.FormattingEnabled = true;
            this.cboStartCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor",
            "Custom",
            "AnchorMask"});
            this.cboStartCap.Location = new System.Drawing.Point(133, 222);
            this.cboStartCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboStartCap.Name = "cboStartCap";
            this.cboStartCap.Size = new System.Drawing.Size(199, 24);
            this.cboStartCap.TabIndex = 9;
            this.cboStartCap.SelectedIndexChanged += new System.EventHandler(this.ComboChanged);
            // 
            // lblEndCap
            // 
            this.lblEndCap.AutoSize = true;
            this.lblEndCap.Location = new System.Drawing.Point(27, 277);
            this.lblEndCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndCap.Name = "lblEndCap";
            this.lblEndCap.Size = new System.Drawing.Size(62, 16);
            this.lblEndCap.TabIndex = 10;
            this.lblEndCap.Text = "End Cap:";
            // 
            // cboEndCap
            // 
            this.cboEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndCap.FormattingEnabled = true;
            this.cboEndCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor",
            "Custom",
            "AnchorMask"});
            this.cboEndCap.Location = new System.Drawing.Point(133, 271);
            this.cboEndCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEndCap.Name = "cboEndCap";
            this.cboEndCap.Size = new System.Drawing.Size(199, 24);
            this.cboEndCap.TabIndex = 11;
            this.cboEndCap.SelectedIndexChanged += new System.EventHandler(this.ComboChanged);
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(360, 25);
            this.drawPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(559, 516);
            this.drawPanel.TabIndex = 12;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 567);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.cboEndCap);
            this.Controls.Add(this.lblEndCap);
            this.Controls.Add(this.cboStartCap);
            this.Controls.Add(this.lblStartCap);
            this.Controls.Add(this.cboDashCap);
            this.Controls.Add(this.lblDashCap);
            this.Controls.Add(this.cboLineJoin);
            this.Controls.Add(this.lblLineJoin);
            this.Controls.Add(this.cboWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cboDashStyle);
            this.Controls.Add(this.lblDashStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pen Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashStyle;
        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cboWidth;
        private System.Windows.Forms.Label lblLineJoin;
        private System.Windows.Forms.ComboBox cboLineJoin;
        private System.Windows.Forms.Label lblDashCap;
        private System.Windows.Forms.ComboBox cboDashCap;
        private System.Windows.Forms.Label lblStartCap;
        private System.Windows.Forms.ComboBox cboStartCap;
        private System.Windows.Forms.Label lblEndCap;
        private System.Windows.Forms.ComboBox cboEndCap;
        private System.Windows.Forms.Panel drawPanel;
    }
}

