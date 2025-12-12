using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // Set default selections
            cboDashStyle.SelectedItem = "DashDot";
            cboWidth.SelectedItem = "3";
            cboLineJoin.SelectedItem = "Round";
            cboDashCap.SelectedItem = "Triangle";
            cboStartCap.SelectedItem = "Triangle";
            cboEndCap.SelectedItem = "RoundAnchor";
        }

        private void ComboChanged(object sender, EventArgs e)
        {
            drawPanel.Invalidate();
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (cboDashStyle.SelectedItem == null) return;

            try
            {
                // Parse selections
                DashStyle dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle),
                    cboDashStyle.SelectedItem.ToString());
                float width = float.Parse(cboWidth.SelectedItem.ToString());
                LineJoin lineJoin = (LineJoin)Enum.Parse(typeof(LineJoin),
                    cboLineJoin.SelectedItem.ToString());
                DashCap dashCap = (DashCap)Enum.Parse(typeof(DashCap),
                    cboDashCap.SelectedItem.ToString());
                LineCap startCap = (LineCap)Enum.Parse(typeof(LineCap),
                    cboStartCap.SelectedItem.ToString());
                LineCap endCap = (LineCap)Enum.Parse(typeof(LineCap),
                    cboEndCap.SelectedItem.ToString());

                // Create pen with properties
                Pen pen = new Pen(Color.Red, width);
                pen.DashStyle = dashStyle;
                pen.LineJoin = lineJoin;
                pen.DashCap = dashCap;
                pen.StartCap = startCap;
                pen.EndCap = endCap;

                // Draw demonstration lines
                DrawDemonstrationLines(g, pen);

                pen.Dispose();
            }
            catch (Exception ex)
            {
                // Handle any parsing errors
                using (Font font = new Font("Arial", 10))
                {
                    g.DrawString("Error: " + ex.Message, font, Brushes.Red, 10, 10);
                }
            }
        }

        private void DrawDemonstrationLines(Graphics g, Pen pen)
        {
            // Draw straight lines with angles to show LineJoin
            Point[] points1 = {
                new Point(50, 80),
                new Point(250, 50),
                new Point(350, 120)
            };
            g.DrawLines(pen, points1);

            // Draw a curved path to show various properties
            Point[] points2 = {
                new Point(100, 200),
                new Point(200, 300),
                new Point(300, 250),
                new Point(350, 320)
            };
            g.DrawCurve(pen, points2, 0.5f);

            // Draw additional straight line to demonstrate dash pattern
            g.DrawLine(pen, new Point(50, 150), new Point(380, 150));
        }
    }
}
