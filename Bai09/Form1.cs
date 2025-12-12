using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        private string selectedShape = "Filled Ellipse";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxShape.SelectedIndex = 6; // Filled Ellipse
            drawPanel.Invalidate();
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShape = comboBoxShape.SelectedItem.ToString();
            drawPanel.Invalidate();
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int centerX = drawPanel.Width / 2;
            int centerY = drawPanel.Height / 2;
            int width = drawPanel.Width - 60;
            int height = drawPanel.Height - 60;

            Rectangle rect = new Rectangle(centerX - width / 2, centerY - height / 2, width, height);

            Pen pen = new Pen(Color.DarkRed, 3);
            Brush brush = new SolidBrush(Color.DarkRed);

            switch (selectedShape)
            {
                case "Circle":
                    int diameter = Math.Min(width, height);
                    g.DrawEllipse(pen, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);
                    break;

                case "Square":
                    int size = Math.Min(width, height);
                    g.DrawRectangle(pen, centerX - size / 2, centerY - size / 2, size, size);
                    break;

                case "Ellipse":
                    g.DrawEllipse(pen, rect);
                    break;

                case "Pie":
                    g.DrawPie(pen, rect, 0, 270);
                    break;

                case "Filled Circle":
                    diameter = Math.Min(width, height);
                    g.FillEllipse(brush, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);
                    break;

                case "Filled Square":
                    size = Math.Min(width, height);
                    g.FillRectangle(brush, centerX - size / 2, centerY - size / 2, size, size);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(brush, rect);
                    break;

                case "Filled Pie":
                    g.FillPie(brush, rect, 0, 270);
                    break;
            }

            pen.Dispose();
            brush.Dispose();
        }
    }
}
