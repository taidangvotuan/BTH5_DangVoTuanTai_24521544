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
            InitializeDefaultValues(); // Gán giá trị mặc định cho các ComboBox
        }

        private void InitializeDefaultValues()
        {
            cboDashStyle.SelectedItem = "DashDot";     // Kiểu nét đứt
            cboWidth.SelectedItem = "3";               // Độ dày nét vẽ
            cboLineJoin.SelectedItem = "Round";        // Kiểu nối góc
            cboDashCap.SelectedItem = "Triangle";      // Kiểu đầu nét đứt
            cboStartCap.SelectedItem = "Triangle";     // Kiểu đầu nét bắt đầu
            cboEndCap.SelectedItem = "RoundAnchor";    // Kiểu đầu nét kết thúc
        }

        private void ComboChanged(object sender, EventArgs e)
        {
            // Yêu cầu vẽ lại panel để cập nhật kiểu vẽ mới
            drawPanel.Invalidate();
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Làm mượt nét vẽ

            // Nếu chưa chọn DashStyle thì không vẽ
            if (cboDashStyle.SelectedItem == null) return;

            try
            {
                // Đọc và chuyển dữ liệu từ ComboBox
                DashStyle dashStyle =
                    (DashStyle)Enum.Parse(typeof(DashStyle),
                    cboDashStyle.SelectedItem.ToString());

                float width =
                    float.Parse(cboWidth.SelectedItem.ToString());

                LineJoin lineJoin =
                    (LineJoin)Enum.Parse(typeof(LineJoin),
                    cboLineJoin.SelectedItem.ToString());

                DashCap dashCap =
                    (DashCap)Enum.Parse(typeof(DashCap),
                    cboDashCap.SelectedItem.ToString());

                LineCap startCap =
                    (LineCap)Enum.Parse(typeof(LineCap),
                    cboStartCap.SelectedItem.ToString());

                LineCap endCap =
                    (LineCap)Enum.Parse(typeof(LineCap),
                    cboEndCap.SelectedItem.ToString());

                // Tạo Pen và gán các thuộc tính
                Pen pen = new Pen(Color.Red, width);
                pen.DashStyle = dashStyle;   // Kiểu nét liền / đứt
                pen.LineJoin = lineJoin;     // Kiểu nối góc
                pen.DashCap = dashCap;       // Kiểu đầu nét đứt
                pen.StartCap = startCap;     // Kiểu đầu bắt đầu
                pen.EndCap = endCap;         // Kiểu đầu kết thúc

                // Vẽ các đường minh họa
                DrawDemonstrationLines(g, pen);

                // Giải phóng tài nguyên
                pen.Dispose();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu chọn giá trị không hợp lệ
                using (Font font = new Font("Arial", 10))
                {
                    g.DrawString("Error: " + ex.Message,
                        font, Brushes.Red, 10, 10);
                }
            }
        }

        private void DrawDemonstrationLines(Graphics g, Pen pen)
        {
            // Đường gấp khúc để minh họa LineJoin
            Point[] points1 =
            {
                new Point(50, 80),
                new Point(250, 50),
                new Point(350, 120)
            };
            g.DrawLines(pen, points1);

            // Đường cong để minh họa DashStyle & DashCap
            Point[] points2 =
            {
                new Point(100, 200),
                new Point(200, 300),
                new Point(300, 250),
                new Point(350, 320)
            };
            g.DrawCurve(pen, points2, 0.5f);

            // Đường thẳng ngang để quan sát rõ nét đứt
            g.DrawLine(pen,
                new Point(50, 150),
                new Point(380, 150));
        }
    }
}
