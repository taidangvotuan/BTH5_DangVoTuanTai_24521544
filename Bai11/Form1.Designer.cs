namespace Bai11
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
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.radioButtonElipse = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.groupBoxPen = new System.Windows.Forms.GroupBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBrushes = new System.Windows.Forms.GroupBox();
            this.radioButtonLinearGradientBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonTextureBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonHatchBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonSolidBrush = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxShapes.SuspendLayout();
            this.groupBoxPen.SuspendLayout();
            this.groupBoxBrushes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.Controls.Add(this.radioButtonElipse);
            this.groupBoxShapes.Controls.Add(this.radioButtonRectangle);
            this.groupBoxShapes.Controls.Add(this.radioButtonLine);
            this.groupBoxShapes.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxShapes.Location = new System.Drawing.Point(12, 21);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(224, 112);
            this.groupBoxShapes.TabIndex = 0;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Shapes";
            // 
            // radioButtonElipse
            // 
            this.radioButtonElipse.AutoSize = true;
            this.radioButtonElipse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonElipse.Location = new System.Drawing.Point(10, 76);
            this.radioButtonElipse.Name = "radioButtonElipse";
            this.radioButtonElipse.Size = new System.Drawing.Size(66, 20);
            this.radioButtonElipse.TabIndex = 2;
            this.radioButtonElipse.TabStop = true;
            this.radioButtonElipse.Text = "Elipse";
            this.radioButtonElipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonRectangle.Location = new System.Drawing.Point(10, 50);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(90, 20);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLine.Location = new System.Drawing.Point(10, 24);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(53, 20);
            this.radioButtonLine.TabIndex = 0;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // groupBoxPen
            // 
            this.groupBoxPen.Controls.Add(this.buttonColor);
            this.groupBoxPen.Controls.Add(this.textBoxWidth);
            this.groupBoxPen.Controls.Add(this.label1);
            this.groupBoxPen.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxPen.Location = new System.Drawing.Point(12, 148);
            this.groupBoxPen.Name = "groupBoxPen";
            this.groupBoxPen.Size = new System.Drawing.Size(224, 112);
            this.groupBoxPen.TabIndex = 1;
            this.groupBoxPen.TabStop = false;
            this.groupBoxPen.Text = "Pen";
            // 
            // buttonColor
            // 
            this.buttonColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonColor.Location = new System.Drawing.Point(51, 57);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(116, 28);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color...";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWidth.Location = new System.Drawing.Point(71, 19);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(71, 22);
            this.textBoxWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // groupBoxBrushes
            // 
            this.groupBoxBrushes.Controls.Add(this.radioButtonLinearGradientBrush);
            this.groupBoxBrushes.Controls.Add(this.radioButtonTextureBrush);
            this.groupBoxBrushes.Controls.Add(this.radioButtonHatchBrush);
            this.groupBoxBrushes.Controls.Add(this.radioButtonSolidBrush);
            this.groupBoxBrushes.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxBrushes.Location = new System.Drawing.Point(12, 275);
            this.groupBoxBrushes.Name = "groupBoxBrushes";
            this.groupBoxBrushes.Size = new System.Drawing.Size(224, 273);
            this.groupBoxBrushes.TabIndex = 1;
            this.groupBoxBrushes.TabStop = false;
            this.groupBoxBrushes.Text = "Brushes";
            // 
            // radioButtonLinearGradientBrush
            // 
            this.radioButtonLinearGradientBrush.AutoSize = true;
            this.radioButtonLinearGradientBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonLinearGradientBrush.Location = new System.Drawing.Point(10, 134);
            this.radioButtonLinearGradientBrush.Name = "radioButtonLinearGradientBrush";
            this.radioButtonLinearGradientBrush.Size = new System.Drawing.Size(150, 20);
            this.radioButtonLinearGradientBrush.TabIndex = 6;
            this.radioButtonLinearGradientBrush.TabStop = true;
            this.radioButtonLinearGradientBrush.Text = "LinearGradientBrush";
            this.radioButtonLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // radioButtonTextureBrush
            // 
            this.radioButtonTextureBrush.AutoSize = true;
            this.radioButtonTextureBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonTextureBrush.Location = new System.Drawing.Point(10, 96);
            this.radioButtonTextureBrush.Name = "radioButtonTextureBrush";
            this.radioButtonTextureBrush.Size = new System.Drawing.Size(107, 20);
            this.radioButtonTextureBrush.TabIndex = 5;
            this.radioButtonTextureBrush.TabStop = true;
            this.radioButtonTextureBrush.Text = "TextureBrush";
            this.radioButtonTextureBrush.UseVisualStyleBackColor = true;
            // 
            // radioButtonHatchBrush
            // 
            this.radioButtonHatchBrush.AutoSize = true;
            this.radioButtonHatchBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonHatchBrush.Location = new System.Drawing.Point(10, 58);
            this.radioButtonHatchBrush.Name = "radioButtonHatchBrush";
            this.radioButtonHatchBrush.Size = new System.Drawing.Size(97, 20);
            this.radioButtonHatchBrush.TabIndex = 4;
            this.radioButtonHatchBrush.TabStop = true;
            this.radioButtonHatchBrush.Text = "HatchBrush";
            this.radioButtonHatchBrush.UseVisualStyleBackColor = true;
            // 
            // radioButtonSolidBrush
            // 
            this.radioButtonSolidBrush.AutoSize = true;
            this.radioButtonSolidBrush.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonSolidBrush.Location = new System.Drawing.Point(10, 21);
            this.radioButtonSolidBrush.Name = "radioButtonSolidBrush";
            this.radioButtonSolidBrush.Size = new System.Drawing.Size(93, 20);
            this.radioButtonSolidBrush.TabIndex = 3;
            this.radioButtonSolidBrush.TabStop = true;
            this.radioButtonSolidBrush.Text = "SolidBrush";
            this.radioButtonSolidBrush.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(266, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 599);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxBrushes);
            this.Controls.Add(this.groupBoxPen);
            this.Controls.Add(this.groupBoxShapes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bai Thi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxShapes.ResumeLayout(false);
            this.groupBoxShapes.PerformLayout();
            this.groupBoxPen.ResumeLayout(false);
            this.groupBoxPen.PerformLayout();
            this.groupBoxBrushes.ResumeLayout(false);
            this.groupBoxBrushes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShapes;
        private System.Windows.Forms.RadioButton radioButtonElipse;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.GroupBox groupBoxPen;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxBrushes;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.RadioButton radioButtonLinearGradientBrush;
        private System.Windows.Forms.RadioButton radioButtonTextureBrush;
        private System.Windows.Forms.RadioButton radioButtonHatchBrush;
        private System.Windows.Forms.RadioButton radioButtonSolidBrush;
        private System.Windows.Forms.Panel panel1;
    }
}

