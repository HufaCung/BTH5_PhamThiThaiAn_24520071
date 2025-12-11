namespace Bai04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbox_B = new System.Windows.Forms.CheckBox();
            this.chbox_I = new System.Windows.Forms.CheckBox();
            this.chbox_U = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbtn_Left = new System.Windows.Forms.RadioButton();
            this.radbtn_Center = new System.Windows.Forms.RadioButton();
            this.radbtn_Right = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(216, 86);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(183, 23);
            this.comboBoxFont.TabIndex = 0;
            this.comboBoxFont.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxFont_DrawItem);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.comboBoxSize.Location = new System.Drawing.Point(514, 86);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(168, 24);
            this.comboBoxSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sansita", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sansita", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // chbox_B
            // 
            this.chbox_B.AutoSize = true;
            this.chbox_B.Font = new System.Drawing.Font("Sansita", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_B.Location = new System.Drawing.Point(161, 162);
            this.chbox_B.Name = "chbox_B";
            this.chbox_B.Size = new System.Drawing.Size(42, 26);
            this.chbox_B.TabIndex = 4;
            this.chbox_B.Text = "B";
            this.chbox_B.UseVisualStyleBackColor = true;
            // 
            // chbox_I
            // 
            this.chbox_I.AutoSize = true;
            this.chbox_I.Font = new System.Drawing.Font("Sansita", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_I.Location = new System.Drawing.Point(266, 162);
            this.chbox_I.Name = "chbox_I";
            this.chbox_I.Size = new System.Drawing.Size(37, 26);
            this.chbox_I.TabIndex = 5;
            this.chbox_I.Text = "I";
            this.chbox_I.UseVisualStyleBackColor = true;
            // 
            // chbox_U
            // 
            this.chbox_U.AutoSize = true;
            this.chbox_U.Font = new System.Drawing.Font("Sansita", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_U.Location = new System.Drawing.Point(360, 162);
            this.chbox_U.Name = "chbox_U";
            this.chbox_U.Size = new System.Drawing.Size(42, 26);
            this.chbox_U.TabIndex = 6;
            this.chbox_U.Text = "U";
            this.chbox_U.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 26);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbtn_Right);
            this.groupBox1.Controls.Add(this.radbtn_Center);
            this.groupBox1.Controls.Add(this.radbtn_Left);
            this.groupBox1.Font = new System.Drawing.Font("Sansita", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(158, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allign Text";
            // 
            // radbtn_Left
            // 
            this.radbtn_Left.AutoSize = true;
            this.radbtn_Left.Location = new System.Drawing.Point(92, 25);
            this.radbtn_Left.Name = "radbtn_Left";
            this.radbtn_Left.Size = new System.Drawing.Size(47, 20);
            this.radbtn_Left.TabIndex = 0;
            this.radbtn_Left.TabStop = true;
            this.radbtn_Left.Text = "Left";
            this.radbtn_Left.UseVisualStyleBackColor = true;
            // 
            // radbtn_Center
            // 
            this.radbtn_Center.AutoSize = true;
            this.radbtn_Center.Location = new System.Drawing.Point(92, 60);
            this.radbtn_Center.Name = "radbtn_Center";
            this.radbtn_Center.Size = new System.Drawing.Size(63, 20);
            this.radbtn_Center.TabIndex = 1;
            this.radbtn_Center.TabStop = true;
            this.radbtn_Center.Text = "Center";
            this.radbtn_Center.UseVisualStyleBackColor = true;
            // 
            // radbtn_Right
            // 
            this.radbtn_Right.AutoSize = true;
            this.radbtn_Right.Location = new System.Drawing.Point(92, 94);
            this.radbtn_Right.Name = "radbtn_Right";
            this.radbtn_Right.Size = new System.Drawing.Size(56, 20);
            this.radbtn_Right.TabIndex = 2;
            this.radbtn_Right.TabStop = true;
            this.radbtn_Right.Text = "Right";
            this.radbtn_Right.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sansita", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Color";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 134);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbox_U);
            this.Controls.Add(this.chbox_I);
            this.Controls.Add(this.chbox_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFont;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbox_B;
        private System.Windows.Forms.CheckBox chbox_I;
        private System.Windows.Forms.CheckBox chbox_U;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbtn_Right;
        private System.Windows.Forms.RadioButton radbtn_Center;
        private System.Windows.Forms.RadioButton radbtn_Left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

