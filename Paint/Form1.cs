using System.Drawing;
using System.Drawing.Imaging;
using System.Net;

namespace Paint
{
    enum SelectedShape
    {
        Line,
        Rectangle,
        Circle
    }
    public partial class Paint : Form
    {
        Bitmap Bitmap = new Bitmap(1920, 1080);
        Pen Pen = new Pen(Color.Black, 5);
        bool IsDrawing = false;
        int penSize = 5;
        private SelectedShape currentShape;
        Point startPoint;
        Point endPoint;
        Image OpenFile;

        public Paint()
        {
            InitializeComponent();

            for (int i = 0; i < Bitmap.Width; i++)
            {
                for (int j = 0; j < Bitmap.Height; j++)
                {
                    Bitmap.SetPixel(i, j, Color.White);
                }
            }
        }

        private void Board_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            IsDrawing = true;
        }

        private void Board_PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            Invalidate();
            IsDrawing = false;
        }

        private void Board_PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                Graphics graphics = Graphics.FromImage(Bitmap);

                switch (currentShape)
                {
                    case SelectedShape.Line:
                        if (startPoint != Point.Empty)
                        {
                            graphics.DrawLine(Pen, startPoint, new Point(e.X, e.Y));
                        }
                        startPoint = new Point(e.X, e.Y);
                        break;
                    case SelectedShape.Rectangle:
                        int x = (startPoint.X > endPoint.X) ? startPoint.X : endPoint.X;
                        int y = (startPoint.Y > endPoint.Y) ? startPoint.Y : endPoint.Y;
                        int width = Math.Abs(startPoint.X - endPoint.X);
                        int height = Math.Abs(startPoint.Y - endPoint.Y);
                        graphics.DrawRectangle(Pen, x, y, width, height);
                        break;
                    case SelectedShape.Circle:
                        int radius = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
                        int centerX = startPoint.X - radius;
                        int centerY = startPoint.Y - radius;

                        using (Pen circlePen = new Pen(Pen.Color, penSize))
                        {
                            graphics.DrawEllipse(circlePen, centerX, centerY, radius * 2, radius * 2);
                        }
                        break;
                }
                Invalidate();
                Board_PictureBox.Image = Bitmap;

            }

        }
        private void ColorButton_Click(object sender, EventArgs e)
        {

            ToolStripButton button = (ToolStripButton)sender;

            switch (button.Name)
            {
                case "btnBlack":
                    Pen.Color = Color.Black;
                    break;
                case "btnRed":
                    Pen.Color = Color.Red;
                    break;
                case "btnYellow":
                    Pen.Color = Color.Yellow;
                    break;
                case "btnGreen":
                    Pen.Color = Color.Green;
                    break;
            }
        }

        private void Click_btnShapes(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            switch (menuItem.Name)
            {
                case "btnLine":
                    currentShape = SelectedShape.Line;
                    break;
                case "btnRectangle":
                    currentShape = SelectedShape.Rectangle;
                    break;
                case "btnCircle":
                    currentShape = SelectedShape.Circle;
                    break;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(Bitmap);
            graphics.Clear(Color.White);
            Refresh();
        }

        private void SaveAsToolStrip_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image *.bmp|";
            saveFileDialog.Title = "SAve an Image File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.Board_PictureBox.Image.Save(fileStream, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.Board_PictureBox.Image.Save(fileStream, ImageFormat.Bmp);

                        break;
                }
                fileStream.Close();
            }
        }

        private void OpenToolStrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                OpenFile = Image.FromFile(openFileDialog.FileName);
                Board_PictureBox.Image = OpenFile;
            }
        }
    }
}