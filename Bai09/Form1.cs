using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            panel1.Paint += panel1_Paint; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string shape = comboBox1.SelectedItem?.ToString();
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = Brushes.Blue;

            Rectangle rectSquare = new Rectangle(70, 50, 150, 150); 
            Rectangle rectEllipse = new Rectangle(70, 50, 200, 120); 
            Rectangle rectCircle = new Rectangle(70, 50, 150, 150); 

            switch (shape)
            {
                case "Circle":
                    g.DrawEllipse(pen, rectCircle);
                    break;
                case "Square":
                    g.DrawRectangle(pen, rectSquare);
                    break;
                case "Ellipse":
                    g.DrawEllipse(pen, rectEllipse);
                    break;
                case "Pie":
                    g.DrawPie(pen, rectCircle, 0, 90);
                    break;
                case "Filled Circle":
                    g.FillEllipse(brush, rectCircle);
                    break;
                case "Filled Square":
                    g.FillRectangle(brush, rectSquare);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(brush, rectEllipse);
                    break;
                case "Filled Pie":
                    g.FillPie(brush, rectCircle, 0, 90); 
                    break;
            }
        }


    }
}
