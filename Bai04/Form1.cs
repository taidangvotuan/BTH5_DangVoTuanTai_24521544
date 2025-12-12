using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private Color currentColor = Color.HotPink;

        public Form1()
        {
            InitializeComponent();
            LoadSystemFonts();
            InitializeFontSizes();
            RegisterEvents(); // Đăng ký tất cả sự kiện

            // Khởi tạo màu button
            buttonColor.BackColor = currentColor;

            // Chọn mặc định Center
            radioButtonCenter.Checked = true;

            UpdateTextFormat();
        }

        private void LoadSystemFonts()
        {
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                FontFamily[] fontFamilies = fontsCollection.Families;
                foreach (FontFamily font in fontFamilies)
                {
                    comboBoxFont.Items.Add(font.Name);
                }
            }

            comboBoxFont.SelectedIndex = comboBoxFont.Items.IndexOf("Arial");
            if (comboBoxFont.SelectedIndex == -1 && comboBoxFont.Items.Count > 0)
                comboBoxFont.SelectedIndex = 0;
        }

        private void InitializeFontSizes()
        {
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                comboBoxSize.Items.Add(size);
            }

            comboBoxSize.SelectedIndex = comboBoxSize.Items.IndexOf(28);
            if (comboBoxSize.SelectedIndex == -1)
                comboBoxSize.SelectedIndex = 4;
        }

        // QUAN TRỌNG: Đăng ký tất cả sự kiện
        private void RegisterEvents()
        {
            // Sự kiện cho ComboBox
            comboBoxFont.SelectedIndexChanged += UpdateFormat_Changed;
            comboBoxSize.SelectedIndexChanged += UpdateFormat_Changed;

            // Sự kiện cho CheckBox
            checkBoxBold.CheckedChanged += UpdateFormat_Changed;
            checkBoxItalic.CheckedChanged += UpdateFormat_Changed;
            checkBoxUnderline.CheckedChanged += UpdateFormat_Changed;

            // Sự kiện cho RadioButton
            radioButtonLeft.CheckedChanged += UpdateFormat_Changed;
            radioButtonCenter.CheckedChanged += UpdateFormat_Changed;
            radioButtonRight.CheckedChanged += UpdateFormat_Changed;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = currentColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                    buttonColor.BackColor = currentColor;
                    UpdateTextFormat();
                }
            }
        }

        private void UpdateFormat_Changed(object sender, EventArgs e)
        {
            UpdateTextFormat();
        }

        private void UpdateTextFormat()
        {
            if (comboBoxFont.SelectedItem == null || comboBoxSize.SelectedItem == null)
                return;

            try
            {
                string fontName = comboBoxFont.SelectedItem.ToString();
                float fontSize = Convert.ToSingle(comboBoxSize.SelectedItem);

                // Tạo FontStyle
                FontStyle style = FontStyle.Regular;
                if (checkBoxBold.Checked) style |= FontStyle.Bold;
                if (checkBoxItalic.Checked) style |= FontStyle.Italic;
                if (checkBoxUnderline.Checked) style |= FontStyle.Underline;

                // Áp dụng Font và màu
                richTextBoxPreview.Font = new Font(fontName, fontSize, style);
                richTextBoxPreview.ForeColor = currentColor;

                // Áp dụng căn lề
                if (radioButtonLeft.Checked)
                    richTextBoxPreview.SelectionAlignment = HorizontalAlignment.Left;
                else if (radioButtonCenter.Checked)
                    richTextBoxPreview.SelectionAlignment = HorizontalAlignment.Center;
                else if (radioButtonRight.Checked)
                    richTextBoxPreview.SelectionAlignment = HorizontalAlignment.Right;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying format: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
