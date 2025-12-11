using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => this.Invalidate();
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;
            int radius = Math.Min(cx, cy) - 20;

            for (int i = 0; i < 60; i++)
            {
                double angle = i * 6 * Math.PI / 180;
                int x = cx + (int)(Math.Cos(angle - Math.PI / 2) * (radius - 10));
                int y = cy + (int)(Math.Sin(angle - Math.PI / 2) * (radius - 10));

                int size = (i % 5 == 0) ? 20 : 8;
                g.FillEllipse(Brushes.White
                    , x - size / 2, y - size / 2, size, size);
            }

            DateTime now = DateTime.Now;

            float hour = now.Hour % 12 + now.Minute / 60f;
            float minute = now.Minute + now.Second / 60f;

            DrawKiteHand(g, cx, cy, hour * 30, 100, 25, Color.White); // 30 độ mỗi giờ

            DrawKiteHand(g, cx, cy, minute * 6, 140, 15, Color.White); // 6 độ mỗi phút

            double secondAngle = now.Second * 6;
            g.TranslateTransform(cx, cy);
            g.RotateTransform((float)secondAngle);
            g.DrawLine(new Pen(Color.White, 2), 0, 0, 0, 160);
            g.ResetTransform();

        }
        private void DrawKiteHand(Graphics g, int cx, int cy, float angleDegrees, int length, int width, Color color)
        {
            Point[] kite = new Point[]
            {
                new Point(0, -length),
                new Point(width / 2, 0),
                new Point(0, width / 2),
                new Point(-width / 2, 0)
            };

            var matrix = new System.Drawing.Drawing2D.Matrix();
            matrix.RotateAt(angleDegrees, new PointF(0, 0));
            matrix.Translate(cx, cy, System.Drawing.Drawing2D.MatrixOrder.Append);

            matrix.TransformPoints(kite);

            using (Pen pen = new Pen(color, 2)) 
            {
                g.DrawPolygon(pen, kite);
            }
        }
    }
}
