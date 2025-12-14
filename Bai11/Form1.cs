using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        private Color selectedColor = Color.Black;
        private Point startPoint, endPoint;
        private bool isDrawing = false;

        // Bitmap dùng để lưu các hình đã vẽ (vẽ vĩnh viễn)
        private Bitmap drawingBitmap;

        // Graphics vẽ trực tiếp lên bitmap
        private Graphics drawingGraphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Giá trị mặc định
            radioButtonLine.Checked = true;
            radioButtonSolidBrush.Checked = true;
            textBoxWidth.Text = "3";

            // Khởi tạo bitmap bằng kích thước panel
            drawingBitmap = new Bitmap(panel1.Width, panel1.Height);

            // Tạo Graphics từ bitmap
            drawingGraphics = Graphics.FromImage(drawingBitmap);
            drawingGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            drawingGraphics.Clear(Color.White);

            // Đăng ký các sự kiện chuột & vẽ
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;
            panel1.Paint += Panel1_Paint;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = selectedColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    selectedColor = colorDialog.Color;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                endPoint = e.Location;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                panel1.Invalidate(); // Vẽ lại để preview
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                endPoint = e.Location;

                // Vẽ vĩnh viễn lên bitmap
                DrawShape(drawingGraphics, startPoint, endPoint, false);

                panel1.Invalidate();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ toàn bộ bitmap (các hình đã vẽ)
            e.Graphics.DrawImage(drawingBitmap, 0, 0);

            // Vẽ preview khi đang kéo chuột
            if (isDrawing)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawShape(e.Graphics, startPoint, endPoint, true);
            }
        }

        private void DrawShape(Graphics g, Point start, Point end, bool isPreview)
        {
            // Lấy độ dày nét
            float width = 3;
            if (!float.TryParse(textBoxWidth.Text, out width))
                width = 3;

            // Tính hình chữ nhật bao
            Rectangle rect = GetRectangle(start, end);

            // Vẽ Line
            if (radioButtonLine.Checked)
            {
                using (Pen pen = new Pen(selectedColor, width))
                {
                    g.DrawLine(pen, start, end);
                }
                return;
            }

            // Rectangle & Ellipse cần Brush
            Brush brush = GetSelectedBrush(rect);

            if (brush != null)
            {
                if (radioButtonRectangle.Checked)
                    g.FillRectangle(brush, rect);
                else if (radioButtonElipse.Checked)
                    g.FillEllipse(brush, rect);

                brush.Dispose();
            }

            // Vẽ viền
            using (Pen pen = new Pen(selectedColor, width))
            {
                if (radioButtonRectangle.Checked)
                    g.DrawRectangle(pen, rect);
                else if (radioButtonElipse.Checked)
                    g.DrawEllipse(pen, rect);
            }
        }

        private Brush GetSelectedBrush(Rectangle rect)
        {
            // Kiểm tra kích thước hợp lệ
            if (rect.Width <= 0 || rect.Height <= 0)
                return new SolidBrush(Color.Green);

            if (radioButtonSolidBrush.Checked)
                return new SolidBrush(Color.Green);

            else if (radioButtonHatchBrush.Checked)
                return new HatchBrush(
                    HatchStyle.Horizontal,
                    Color.Blue,
                    Color.Green);

            else if (radioButtonTextureBrush.Checked)
            {
                // Tạo texture bitmap
                Bitmap texture = new Bitmap(20, 20);
                using (Graphics gTex = Graphics.FromImage(texture))
                {
                    gTex.Clear(Color.LightGreen);
                    gTex.FillRectangle(Brushes.Green, 0, 0, 10, 10);
                    gTex.FillRectangle(Brushes.Green, 10, 10, 10, 10);
                    gTex.FillEllipse(Brushes.DarkGreen, 5, 5, 10, 10);
                }
                return new TextureBrush(texture);
            }

            else if (radioButtonLinearGradientBrush.Checked)
            {
                if (rect.Width > 1 && rect.Height > 1)
                {
                    return new LinearGradientBrush(
                        rect,
                        Color.Red,
                        Color.Green,
                        LinearGradientMode.Vertical);
                }
            }

            return new SolidBrush(Color.Green);
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);

            return new Rectangle(x, y, width, height);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            drawingGraphics?.Dispose();
            drawingBitmap?.Dispose();
            base.OnFormClosing(e);
        }
    }
}