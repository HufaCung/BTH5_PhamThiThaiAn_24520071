using System.Drawing;
using System.Windows.Forms;

namespace BT10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelLeft;
        private ComboBox cbDashStyle;
        private NumericUpDown numWidth;
        private ComboBox cbLineJoin;
        private ComboBox cbDashCap;
        private ComboBox cbStartCap;
        private ComboBox cbEndCap;
        private Label lbDashStyle;
        private Label lbWidth;
        private Label lbLineJoin;
        private Label lbDashCap;
        private Label lbStartCap;
        private Label lbEndCap;
        private MyPanel myPanel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lbDashStyle = new System.Windows.Forms.Label();
            this.cbDashStyle = new System.Windows.Forms.ComboBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lbLineJoin = new System.Windows.Forms.Label();
            this.cbLineJoin = new System.Windows.Forms.ComboBox();
            this.lbDashCap = new System.Windows.Forms.Label();
            this.cbDashCap = new System.Windows.Forms.ComboBox();
            this.lbStartCap = new System.Windows.Forms.Label();
            this.cbStartCap = new System.Windows.Forms.ComboBox();
            this.lbEndCap = new System.Windows.Forms.Label();
            this.cbEndCap = new System.Windows.Forms.ComboBox();
            this.myPanel1 = new BT10.MyPanel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lbDashStyle);
            this.panelLeft.Controls.Add(this.cbDashStyle);
            this.panelLeft.Controls.Add(this.lbWidth);
            this.panelLeft.Controls.Add(this.numWidth);
            this.panelLeft.Controls.Add(this.lbLineJoin);
            this.panelLeft.Controls.Add(this.cbLineJoin);
            this.panelLeft.Controls.Add(this.lbDashCap);
            this.panelLeft.Controls.Add(this.cbDashCap);
            this.panelLeft.Controls.Add(this.lbStartCap);
            this.panelLeft.Controls.Add(this.cbStartCap);
            this.panelLeft.Controls.Add(this.lbEndCap);
            this.panelLeft.Controls.Add(this.cbEndCap);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(230, 400);
            this.panelLeft.TabIndex = 1;
            // 
            // lbDashStyle
            // 
            this.lbDashStyle.Location = new System.Drawing.Point(20, 20);
            this.lbDashStyle.Name = "lbDashStyle";
            this.lbDashStyle.Size = new System.Drawing.Size(100, 23);
            this.lbDashStyle.TabIndex = 0;
            this.lbDashStyle.Text = "Dash Style:";
            // 
            // cbDashStyle
            // 
            this.cbDashStyle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDashStyle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDashStyle.Location = new System.Drawing.Point(120, 20);
            this.cbDashStyle.Name = "cbDashStyle";
            this.cbDashStyle.Size = new System.Drawing.Size(90, 21);
            this.cbDashStyle.TabIndex = 1;
            // 
            // lbWidth
            // 
            this.lbWidth.Location = new System.Drawing.Point(20, 50);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(100, 23);
            this.lbWidth.TabIndex = 2;
            this.lbWidth.Text = "Width:";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(120, 50);
            this.numWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(90, 20);
            this.numWidth.TabIndex = 3;
            this.numWidth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbLineJoin
            // 
            this.lbLineJoin.Location = new System.Drawing.Point(20, 80);
            this.lbLineJoin.Name = "lbLineJoin";
            this.lbLineJoin.Size = new System.Drawing.Size(100, 23);
            this.lbLineJoin.TabIndex = 4;
            this.lbLineJoin.Text = "Line Join:";
            // 
            // cbLineJoin
            // 
            this.cbLineJoin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLineJoin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLineJoin.Location = new System.Drawing.Point(120, 80);
            this.cbLineJoin.Name = "cbLineJoin";
            this.cbLineJoin.Size = new System.Drawing.Size(90, 21);
            this.cbLineJoin.TabIndex = 5;
            // 
            // lbDashCap
            // 
            this.lbDashCap.Location = new System.Drawing.Point(20, 110);
            this.lbDashCap.Name = "lbDashCap";
            this.lbDashCap.Size = new System.Drawing.Size(100, 23);
            this.lbDashCap.TabIndex = 6;
            this.lbDashCap.Text = "Dash Cap:";
            // 
            // cbDashCap
            // 
            this.cbDashCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDashCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDashCap.Location = new System.Drawing.Point(120, 110);
            this.cbDashCap.Name = "cbDashCap";
            this.cbDashCap.Size = new System.Drawing.Size(90, 21);
            this.cbDashCap.TabIndex = 7;
            // 
            // lbStartCap
            // 
            this.lbStartCap.Location = new System.Drawing.Point(20, 140);
            this.lbStartCap.Name = "lbStartCap";
            this.lbStartCap.Size = new System.Drawing.Size(100, 23);
            this.lbStartCap.TabIndex = 8;
            this.lbStartCap.Text = "Start Cap:";
            // 
            // cbStartCap
            // 
            this.cbStartCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStartCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStartCap.Location = new System.Drawing.Point(120, 140);
            this.cbStartCap.Name = "cbStartCap";
            this.cbStartCap.Size = new System.Drawing.Size(90, 21);
            this.cbStartCap.TabIndex = 9;
            // 
            // lbEndCap
            // 
            this.lbEndCap.Location = new System.Drawing.Point(20, 170);
            this.lbEndCap.Name = "lbEndCap";
            this.lbEndCap.Size = new System.Drawing.Size(100, 23);
            this.lbEndCap.TabIndex = 10;
            this.lbEndCap.Text = "End Cap:";
            // 
            // cbEndCap
            // 
            this.cbEndCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEndCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEndCap.Location = new System.Drawing.Point(120, 170);
            this.cbEndCap.Name = "cbEndCap";
            this.cbEndCap.Size = new System.Drawing.Size(90, 21);
            this.cbEndCap.TabIndex = 11;
            // 
            // myPanel1
            // 
            this.myPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myPanel1.Location = new System.Drawing.Point(235, 0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(536, 399);
            this.myPanel1.TabIndex = 0;
            this.myPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDraw_Paint);
            this.myPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseDown);
            this.myPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseMove);
            this.myPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDraw_MouseUp);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(770, 400);
            this.Controls.Add(this.myPanel1);
            this.Controls.Add(this.panelLeft);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
