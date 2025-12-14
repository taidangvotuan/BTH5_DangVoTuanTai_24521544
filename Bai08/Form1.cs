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
            StartClock(); // Khởi động đồng hồ
        }

        private void CalculateCenter()
        {
            centerX = this.ClientSize.Width / 2;
            centerY = this.ClientSize.Height / 2;

            // Lấy bán kính nhỏ hơn để đồng hồ không bị tràn form
            radius = Math.Min(centerX, centerY) - 40;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CalculateCenter(); // Tính lại tâm & bán kính
            this.Invalidate(); // Yêu cầu vẽ lại form
        }

        private void StartClock()
        {
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi 1 giây
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
            g.SmoothingMode = SmoothingMode.AntiAlias; // Làm mượt nét vẽ

            // Vẽ 60 chấm phút quanh mặt đồng hồ
            for (int i = 0; i < 60; i++)
            {
                // Mỗi phút tương ứng 6 độ
                double angle = i * 6 * Math.PI / 180;

                // Chấm giờ (mỗi 5 phút) to hơn
                int dotSize = (i % 5 == 0) ? 3 : 2;

                int x = centerX + (int)(radius * Math.Sin(angle));
                int y = centerY - (int)(radius * Math.Cos(angle));

                g.FillEllipse(
                    Brushes.White,
                    x - dotSize, y - dotSize,
                    dotSize * 2, dotSize * 2
                );
            }

            // Vẽ 12 chấm giờ lớn
            for (int i = 0; i < 12; i++)
            {
                // Mỗi giờ cách nhau 30 độ
                double angle = i * 30 * Math.PI / 180;
                int markerRadius = 12;

                int x = centerX + (int)((radius - 5) * Math.Sin(angle));
                int y = centerY - (int)((radius - 5) * Math.Cos(angle));

                g.FillEllipse(
                    Brushes.White,
                    x - markerRadius, y - markerRadius,
                    markerRadius * 2, markerRadius * 2
                );
            }

            // Lấy thời gian hiện tại
            DateTime now = DateTime.Now;
            int hour = now.Hour % 12; // Đồng hồ 12 giờ
            int minute = now.Minute;
            int second = now.Second;

            // Tính góc quay cho từng kim 
            // Kim giờ: 30° mỗi giờ + 0.5° mỗi phút
            double hourAngle = (hour * 30 + minute * 0.5) * Math.PI / 180;

            // Kim phút: 6° mỗi phút + 0.1° mỗi giây
            double minuteAngle = (minute * 6 + second * 0.1) * Math.PI / 180;

            // Kim giây: 6° mỗi giây
            double secondAngle = second * 6 * Math.PI / 180;

            // Vẽ các kim đồng hồ
            DrawHand(g, hourAngle, radius * 0.5, 8, Color.White);    // Kim giờ
            DrawHand(g, minuteAngle, radius * 0.7, 6, Color.White); // Kim phút
            DrawHand(g, secondAngle, radius * 0.85, 3, Color.White);// Kim giây

            // Vẽ tâm đồng hồ
            g.FillEllipse(Brushes.White, centerX - 8, centerY - 8, 16, 16);
        }

        private void DrawHand(Graphics g, double angle, double length, int width, Color color)
        {
            // Tính tọa độ điểm cuối kim
            int endX = centerX + (int)(length * Math.Sin(angle));
            int endY = centerY - (int)(length * Math.Cos(angle));

            using (Pen pen = new Pen(color, width))
            {
                pen.StartCap = LineCap.Round; // Bo tròn đầu kim
                pen.EndCap = LineCap.Round;

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