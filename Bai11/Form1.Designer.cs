using System.Windows.Forms;

namespace BT11
{
    partial class Form1
    {
        private GroupBox groupBox1;
        private RadioButton rbLine;
        private RadioButton rbRectangle;
        private RadioButton rbEllipse;

        private GroupBox groupBox2;
        private Label label1;
        private NumericUpDown numWidth;
        private Button btnColor;

        private GroupBox groupBox3;
        private RadioButton rbSolid;
        private RadioButton rbHatch;
        private RadioButton rbTexture;
        private RadioButton rbGradient;

        private MyPanel panelDraw;

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rbLine = new RadioButton();
            rbRectangle = new RadioButton();
            rbEllipse = new RadioButton();

            groupBox2 = new GroupBox();
            label1 = new Label();
            numWidth = new NumericUpDown();
            btnColor = new Button();

            groupBox3 = new GroupBox();
            rbSolid = new RadioButton();
            rbHatch = new RadioButton();
            rbTexture = new RadioButton();
            rbGradient = new RadioButton();

            panelDraw = new MyPanel();

            groupBox1.Text = "Shapes";
            groupBox1.SetBounds(10, 10, 150, 100);

            rbLine.Text = "Line";
            rbLine.Checked = true;
            rbLine.SetBounds(15, 20, 100, 20);

            rbRectangle.Text = "Rectangle";
            rbRectangle.SetBounds(15, 45, 100, 20);

            rbEllipse.Text = "Ellipse";
            rbEllipse.SetBounds(15, 70, 100, 20);

            groupBox1.Controls.AddRange(new Control[] { rbLine, rbRectangle, rbEllipse });

            groupBox2.Text = "Pen";
            groupBox2.SetBounds(10, 120, 150, 100);

            label1.Text = "Width:";
            label1.SetBounds(10, 25, 40, 20);

            numWidth.Minimum = 1;
            numWidth.Value = 1;
            numWidth.SetBounds(60, 25, 60, 20);

            btnColor.Text = "Color...";
            btnColor.SetBounds(35, 60, 75, 25);
            btnColor.Click += btnColor_Click;

            groupBox2.Controls.AddRange(new Control[] { label1, numWidth, btnColor });

            groupBox3.Text = "Brushes";
            groupBox3.SetBounds(10, 230, 150, 120);

            rbSolid.Text = "SolidBrush";
            rbSolid.Checked = true;
            rbSolid.SetBounds(15, 25, 100, 20);

            rbHatch.Text = "HatchBrush";
            rbHatch.SetBounds(15, 50, 100, 20);

            rbTexture.Text = "TextureBrush";
            rbTexture.SetBounds(15, 75, 100, 20);

            rbGradient.Text = "Gradient";
            rbGradient.SetBounds(15, 100, 100, 20);

            groupBox3.Controls.AddRange(new Control[] { rbSolid, rbHatch, rbTexture, rbGradient });

            panelDraw.SetBounds(170, 10, 700, 500);
            panelDraw.BorderStyle = BorderStyle.FixedSingle;
            panelDraw.Paint += panelDraw_Paint;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;

            ClientSize = new System.Drawing.Size(900, 530);
            Text = "Bai Thi";
            Controls.AddRange(new Control[] { groupBox1, groupBox2, groupBox3, panelDraw });
        }
    }
}
