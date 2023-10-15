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
            Board_PictureBox = new PictureBox();
            Shapes = new ToolStripMenuItem();
            btnLine = new ToolStripMenuItem();
            btnRectangle = new ToolStripMenuItem();
            btnCircle = new ToolStripMenuItem();
            btn_Black = new ToolStripButton();
            btnRed = new ToolStripButton();
            btnYellow = new ToolStripButton();
            btnGreen = new ToolStripButton();
            btnClear = new ToolStripButton();
            toolStrip = new ToolStrip();
            File = new ToolStripMenuItem();
            NewToolStrip = new ToolStripMenuItem();
            OpenToolStrip = new ToolStripMenuItem();
            SaveAsToolStrip = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Board_PictureBox).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // Board_PictureBox
            // 
            Board_PictureBox.Dock = DockStyle.Fill;
            Board_PictureBox.Location = new Point(0, 27);
            Board_PictureBox.Name = "Board_PictureBox";
            Board_PictureBox.Size = new Size(800, 424);
            Board_PictureBox.TabIndex = 3;
            Board_PictureBox.TabStop = false;
            Board_PictureBox.MouseDown += Board_PictureBox_MouseDown;
            Board_PictureBox.MouseMove += Board_PictureBox_MouseMove;
            Board_PictureBox.MouseUp += Board_PictureBox_MouseUp;
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
            btnRectangle.Click += Click_btnShapes;
            // 
            // btnCircle
            // 
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(158, 26);
            btnCircle.Text = "Circle";
            btnCircle.Click += Click_btnShapes;
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
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 24);
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { File, Shapes, btn_Black, btnRed, btnYellow, btnGreen, btnClear });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 27);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { NewToolStrip, OpenToolStrip, SaveAsToolStrip });
            File.Name = "File";
            File.Size = new Size(46, 27);
            File.Text = "File";
            // 
            // NewToolStrip
            // 
            NewToolStrip.Name = "NewToolStrip";
            NewToolStrip.ShortcutKeys = Keys.Control | Keys.N;
            NewToolStrip.Size = new Size(224, 26);
            NewToolStrip.Text = "New";
            NewToolStrip.Click += btnClear_Click;
            // 
            // OpenToolStrip
            // 
            OpenToolStrip.Name = "OpenToolStrip";
            OpenToolStrip.ShortcutKeys = Keys.Control | Keys.O;
            OpenToolStrip.Size = new Size(224, 26);
            OpenToolStrip.Text = "Open";
            OpenToolStrip.Click += OpenToolStrip_Click;
            // 
            // SaveAsToolStrip
            // 
            SaveAsToolStrip.Name = "SaveAsToolStrip";
            SaveAsToolStrip.ShortcutKeys = Keys.Control | Keys.S;
            SaveAsToolStrip.Size = new Size(224, 26);
            SaveAsToolStrip.Text = "Save As";
            SaveAsToolStrip.Click += SaveAsToolStrip_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(Board_PictureBox);
            Controls.Add(toolStrip);
            Name = "Paint";
            Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)Board_PictureBox).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Board_PictureBox;
        private ToolStripMenuItem Shapes;
        private ToolStripMenuItem btnLine;
        private ToolStripMenuItem btnRectangle;
        private ToolStripMenuItem btnCircle;
        private ToolStripButton btn_Black;
        private ToolStripButton btnRed;
        private ToolStripButton btnYellow;
        private ToolStripButton btnGreen;
        private ToolStripButton btnClear;
        private ToolStrip toolStrip;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem File;
        private ToolStripMenuItem NewToolStrip;
        private ToolStripMenuItem OpenToolStrip;
        private ToolStripMenuItem SaveAsToolStrip;
    }
}