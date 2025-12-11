using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                button1.BackColor = selectedColor;
                textBox1.ForeColor = selectedColor;
                ApplyFormat();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                comboBoxFont.Items.Add(font.Name);
            }

            // Gắn sự kiện thay đổi cho các control
            comboBoxFont.SelectedIndexChanged += (s, ev) => ApplyFormat();
            comboBoxSize.SelectedIndexChanged += (s, ev) => ApplyFormat();
            chbox_B.CheckedChanged += (s, ev) => ApplyFormat();
            chbox_I.CheckedChanged += (s, ev) => ApplyFormat();
            chbox_U.CheckedChanged += (s, ev) => ApplyFormat();
            radbtn_Left.CheckedChanged += (s, ev) => ApplyFormat();
            radbtn_Center.CheckedChanged += (s, ev) => ApplyFormat();
            radbtn_Right.CheckedChanged += (s, ev) => ApplyFormat();
        }

        private void ApplyFormat()
        {
            string fontName = comboBoxFont.SelectedItem?.ToString() ?? "Arial";
            float fontSize = float.Parse(comboBoxSize.SelectedItem?.ToString() ?? "12");

            FontStyle style = FontStyle.Regular;
            if (chbox_B.Checked) style |= FontStyle.Bold;
            if (chbox_I.Checked) style |= FontStyle.Italic;
            if (chbox_U.Checked) style |= FontStyle.Underline;

            textBox1.Font = new Font(fontName, fontSize, style);

            if (radbtn_Left.Checked) textBox1.TextAlign = HorizontalAlignment.Left;
            else if (radbtn_Center.Checked) textBox1.TextAlign = HorizontalAlignment.Center;
            else if (radbtn_Right.Checked) textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFormat();
        }

        private void comboBoxFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string fontName = comboBoxFont.Items[e.Index].ToString();

            e.DrawBackground();

            using (Font f = new Font(fontName, e.Font.Size))
            {
                e.Graphics.DrawString(fontName, f, Brushes.Black, e.Bounds);
            }

            e.DrawFocusRectangle();
        }
    }
}
