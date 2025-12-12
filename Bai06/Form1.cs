using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAllFonts();
        }

        private void LoadAllFonts()
        {
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                FontFamily[] fontFamilies = fontsCollection.Families;
                foreach (FontFamily font in fontFamilies)
                    listBoxFonts.Items.Add(font.Name);
            }
        }

        private void listBoxFonts_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Set height for each item
            e.ItemHeight = 36;
        }

        private void listBoxFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            string fontName = listBoxFonts.Items[e.Index].ToString();

            try
            {
                // Create font with the font family itself
                using (Font font = new Font(fontName, 14, FontStyle.Regular))
                {
                    // Draw the font name using that font
                    Brush brush = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                        ? SystemBrushes.HighlightText
                        : SystemBrushes.WindowText;

                    e.Graphics.DrawString("." + fontName, font, brush, e.Bounds.Left + 5, e.Bounds.Top + 5);
                }
            }
            catch
            {
                // If font can't be created, use default font
                using (Font defaultFont = new Font("Arial", 12, FontStyle.Regular))
                {
                    Brush brush = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                        ? SystemBrushes.HighlightText
                        : SystemBrushes.WindowText;

                    e.Graphics.DrawString("." + fontName + " (unavailable)", defaultFont, brush, e.Bounds.Left + 5, e.Bounds.Top + 5);
                }
            }
            e.DrawFocusRectangle();
        }
    }
}
