using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT10
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint, currentPoint;
        private List<Tuple<Point, Point, Pen>> lines = new List<Tuple<Point, Point, Pen>>();

        public Form1()
        {
            InitializeComponent();

            cbDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cbLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cbDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cbStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cbEndCap.DataSource = Enum.GetValues(typeof(LineCap));

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private Pen CreatePen()
        {
            Pen p = new Pen(Color.Red, (float)numWidth.Value);
            p.DashStyle = (DashStyle)cbDashStyle.SelectedItem;
            p.LineJoin = (LineJoin)cbLineJoin.SelectedItem;
            p.DashCap = (DashCap)cbDashCap.SelectedItem;
            p.StartCap = (LineCap)cbStartCap.SelectedItem;
            p.EndCap = (LineCap)cbEndCap.SelectedItem;
            return p;
        }

        private void PanelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            currentPoint = e.Location;
        }

        private void PanelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            currentPoint = e.Location;
            myPanel1.Invalidate();
        }

        private void PanelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            Pen p = CreatePen();
            lines.Add(new Tuple<Point, Point, Pen>(startPoint, e.Location, (Pen)p.Clone()));
            myPanel1.Invalidate();
        }

        private void PanelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var l in lines)
                g.DrawLine(l.Item3, l.Item1, l.Item2);

            if (isDrawing)
            {
                Pen p = CreatePen();
                p.Color = Color.FromArgb(180, p.Color);
                g.DrawLine(p, startPoint, currentPoint);
                p.Dispose();
            }
        }
    }

    public class MyPanel : Panel
    {
        public MyPanel()
        {
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer,
                          true);
            this.UpdateStyles();
        }
    }
}
