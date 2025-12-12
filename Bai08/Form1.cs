using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int centerX, centerY, radius;

        public Form1()
        {
            InitializeComponent();
            StartClock();
        }

        private void CalculateCenter()
        {
            centerX = this.ClientSize.Width / 2;
            centerY = this.ClientSize.Height / 2;
            radius = Math.Min(centerX, centerY) - 40;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CalculateCenter();
            this.Invalidate();
        }

        private void StartClock()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw 60 minute dots
            for (int i = 0; i < 60; i++)
            {
                double angle = i * 6 * Math.PI / 180; // 6 degrees per dot
                int dotSize = (i % 5 == 0) ? 3 : 2; // Larger dots for hours

                int x = centerX + (int)(radius * Math.Sin(angle));
                int y = centerY - (int)(radius * Math.Cos(angle));

                g.FillEllipse(Brushes.White, x - dotSize, y - dotSize, dotSize * 2, dotSize * 2);
            }

            // Draw 12 hour markers (larger circles)
            for (int i = 0; i < 12; i++)
            {
                double angle = i * 30 * Math.PI / 180; // 30 degrees per hour
                int markerRadius = 12;

                int x = centerX + (int)((radius - 5) * Math.Sin(angle));
                int y = centerY - (int)((radius - 5) * Math.Cos(angle));

                g.FillEllipse(Brushes.White, x - markerRadius, y - markerRadius,
                    markerRadius * 2, markerRadius * 2);
            }

            // Get current time
            DateTime now = DateTime.Now;
            int hour = now.Hour % 12;
            int minute = now.Minute;
            int second = now.Second;

            // Calculate angles (12 o'clock is 0 degrees)
            double hourAngle = (hour * 30 + minute * 0.5) * Math.PI / 180;
            double minuteAngle = (minute * 6 + second * 0.1) * Math.PI / 180;
            double secondAngle = second * 6 * Math.PI / 180;

            // Draw hour hand
            DrawHand(g, hourAngle, radius * 0.5, 8, Color.White);

            // Draw minute hand
            DrawHand(g, minuteAngle, radius * 0.7, 6, Color.White);

            // Draw second hand
            DrawHand(g, secondAngle, radius * 0.85, 3, Color.White);

            // Draw center circle
            g.FillEllipse(Brushes.White, centerX - 8, centerY - 8, 16, 16);
        }

        private void DrawHand(Graphics g, double angle, double length, int width, Color color)
        {
            // Calculate end point
            int endX = centerX + (int)(length * Math.Sin(angle));
            int endY = centerY - (int)(length * Math.Cos(angle));

            // Create pen
            using (Pen pen = new Pen(color, width))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                // Draw the hand
                g.DrawLine(pen, centerX, centerY, endX, endY);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer?.Stop();
            timer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
