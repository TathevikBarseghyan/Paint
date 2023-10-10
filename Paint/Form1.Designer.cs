namespace Paint
{
    partial class Paint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip1 = new ToolStrip();
            Shapes = new ToolStripMenuItem();
            btnLine = new ToolStripMenuItem();
            btnRectangle = new ToolStripMenuItem();
            btnCircle = new ToolStripMenuItem();
            btn_Black = new ToolStripButton();
            btnRed = new ToolStripButton();
            btnYellow = new ToolStripButton();
            btnGreen = new ToolStripButton();
            Board_PictureBox = new PictureBox();
            btnClear = new ToolStripButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Board_PictureBox).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Shapes, btn_Black, btnRed, btnYellow, btnGreen, btnClear });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // Shapes
            // 
            Shapes.DropDownItems.AddRange(new ToolStripItem[] { btnLine, btnRectangle, btnCircle });
            Shapes.Name = "Shapes";
            Shapes.Size = new Size(70, 27);
            Shapes.Text = "Shapes";
            // 
            // btnLine
            // 
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(158, 26);
            btnLine.Text = "Line";
            btnLine.Click += Click_btnShapes;
            // 
            // btnRectangle
            // 
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(158, 26);
            btnRectangle.Text = "Rectangle";
            // 
            // btnCircle
            // 
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(158, 26);
            btnCircle.Text = "Circle";
            // 
            // btn_Black
            // 
            btn_Black.AutoSize = false;
            btn_Black.BackColor = SystemColors.InactiveCaptionText;
            btn_Black.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_Black.ImageTransparentColor = Color.Magenta;
            btn_Black.Name = "btn_Black";
            btn_Black.Size = new Size(29, 24);
            btn_Black.Text = "Black";
            btn_Black.Click += ColorButton_Click;
            // 
            // btnRed
            // 
            btnRed.AutoSize = false;
            btnRed.BackColor = Color.Red;
            btnRed.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRed.ForeColor = SystemColors.ButtonHighlight;
            btnRed.ImageTransparentColor = Color.Magenta;
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(29, 24);
            btnRed.Text = "Red";
            btnRed.Click += ColorButton_Click;
            // 
            // btnYellow
            // 
            btnYellow.AutoSize = false;
            btnYellow.BackColor = Color.Yellow;
            btnYellow.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnYellow.ForeColor = SystemColors.ButtonHighlight;
            btnYellow.ImageTransparentColor = Color.Magenta;
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(29, 24);
            btnYellow.Text = "Yellow";
            btnYellow.Click += ColorButton_Click;
            // 
            // btnGreen
            // 
            btnGreen.AutoSize = false;
            btnGreen.BackColor = Color.FromArgb(0, 192, 0);
            btnGreen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGreen.ForeColor = SystemColors.ButtonHighlight;
            btnGreen.ImageTransparentColor = Color.Magenta;
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(29, 24);
            btnGreen.Text = "Green";
            btnGreen.Click += ColorButton_Click;
            // 
            // Board_PictureBox
            // 
            Board_PictureBox.Dock = DockStyle.Fill;
            Board_PictureBox.Location = new Point(0, 27);
            Board_PictureBox.Name = "Board_PictureBox";
            Board_PictureBox.Size = new Size(800, 423);
            Board_PictureBox.TabIndex = 3;
            Board_PictureBox.TabStop = false;
            Board_PictureBox.MouseDown += Board_PictureBox_MouseDown;
            Board_PictureBox.MouseMove += Board_PictureBox_MouseMove;
            Board_PictureBox.MouseUp += Board_PictureBox_MouseUp;
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 24);
            btnClear.Text = "Clear";
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Board_PictureBox);
            Controls.Add(toolStrip1);
            Name = "Paint";
            Text = "Paint";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Board_PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnYellow;
        private ToolStripButton btnGreen;
        private ToolStripButton btn_Black;
        private ToolStripButton btnRed;
        private PictureBox Board_PictureBox;
        private ToolStripMenuItem Shapes;
        private ToolStripMenuItem btnLine;
        private ToolStripMenuItem btnRectangle;
        private ToolStripMenuItem btnCircle;
        private ToolStripButton btnClear;
    }
}