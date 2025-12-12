namespace Bai06
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
            this.listBoxFonts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxFonts
            // 
            this.listBoxFonts.FormattingEnabled = true;
            this.listBoxFonts.HorizontalScrollbar = true;
            this.listBoxFonts.IntegralHeight = false;
            this.listBoxFonts.ItemHeight = 16;
            this.listBoxFonts.Location = new System.Drawing.Point(18, 12);
            this.listBoxFonts.Name = "listBoxFonts";
            this.listBoxFonts.Size = new System.Drawing.Size(549, 612);
            this.listBoxFonts.TabIndex = 0;
            this.listBoxFonts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFonts_DrawItem);
            this.listBoxFonts.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBoxFonts_MeasureItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 640);
            this.Controls.Add(this.listBoxFonts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "All Fonts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFonts;
    }
}

