using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT11
{
    public partial class Form1 : Form
    {
        Bitmap canvas;
        bool isDrawing;
        Point p1, p2;
        Color lineColor = Color.Black;
        Bitmap textureImg;

        public Form1()
        {
            InitializeComponent();

            canvas = new Bitmap(panelDraw.Width, panelDraw.Height);
            panelDraw.BackgroundImage = canvas;

            GenerateTexture();
        }

        void GenerateTexture()
        {
            int w = 60;
            int h = 40;

            textureImg = new Bitmap(w, h);

            using (Graphics g = Graphics.FromImage(textureImg))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Color globeColor = Color.FromArgb(20, 70, 110);
                Color lineColor = Color.White;
                float lineThickness = 2.5f;

                int cx = w / 2;
                int cy = h / 2;

                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, w, h);
                g.SetClip(path);

                using (SolidBrush sb = new SolidBrush(globeColor))
                {
                    g.FillRectangle(sb, 0, 0, w, h);
                }

                using (Pen p = new Pen(lineColor, lineThickness))
                {
                    g.DrawLine(p, 0, cy, w, cy);
                    g.DrawLine(p, 0, h / 4, w, h / 4);
                    g.DrawLine(p, 0, h * 3 / 4, w, h * 3 / 4);

                    g.DrawLine(p, cx, 0, cx, h);

                    int offsetInner = w / 4;
                    int offsetOuter = w / 2;

                    void DrawCurve(int dx)
                    {
                        g.DrawBezier(p,
                            cx, 0,
                            cx - dx, h / 3,
                            cx - dx, h * 2 / 3,
                            cx, h);

                        g.DrawBezier(p,
                            cx, 0,
                            cx + dx, h / 3,
                            cx + dx, h * 2 / 3,
                            cx, h);
                    }

                    DrawCurve(offsetInner);
                    DrawCurve(offsetOuter);
                }

                g.ResetClip();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                lineColor = dlg.Color;
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            isDrawing = true;
            p1 = p2 = e.Location;
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            p2 = e.Location;
            panelDraw.Invalidate();
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            p2 = e.Location;

            using (Graphics g = Graphics.FromImage(canvas))
                DrawShape(g);

            panelDraw.Invalidate();
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing) DrawShape(e.Graphics);
        }

        void DrawShape(Graphics g)
        {
            Rectangle r = GetRect(p1, p2);

            if (rbLine.Checked)
            {
                using (Pen p = new Pen(lineColor, (float)numWidth.Value))
                    g.DrawLine(p, p1, p2);
                return;
            }

            if (r.Width == 0 || r.Height == 0) return;

            Brush brush = null;

            if (rbSolid.Checked)
            {
                brush = new SolidBrush(Color.Green);
            }
            else if (rbHatch.Checked)
            {
                brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
            else if (rbTexture.Checked)
            {
                brush = new TextureBrush(textureImg);
            }
            else if (rbGradient.Checked)
            {
                brush = new LinearGradientBrush(r, Color.Red, Color.Green, LinearGradientMode.Vertical);
            }

            using (brush)
            {
                if (rbRectangle.Checked)
                    g.FillRectangle(brush, r);
                else
                    g.FillEllipse(brush, r);
            }
        }

        Rectangle GetRect(Point a, Point b)
        {
            return new Rectangle(
                Math.Min(a.X, b.X),
                Math.Min(a.Y, b.Y),
                Math.Abs(a.X - b.X),
                Math.Abs(a.Y - b.Y));
        }

        public class MyPanel : Panel
        {
            public MyPanel()
            {
                DoubleBuffered = true;
                SetStyle(ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint |
                         ControlStyles.OptimizedDoubleBuffer, true);
            }
        }
    }
}