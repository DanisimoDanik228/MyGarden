using System.Drawing;

namespace MyGarden
{
    public partial class Form1 : Form
    {
        private const int _sizeSqare = 10;
        private Graphics _graphics;
        private Color _baseColor;
        private bool buttonIsPressed = false;

        private Size _size;

        private bool isValidGardenForm;

        private Point startPointRectangle;
        public Form1()
        {
            InitializeComponent();

            _baseColor = Color.LightGray;

            pictureBoxGarden.Image = new Bitmap(pictureBoxGarden.Width, pictureBoxGarden.Height);
            _graphics = Graphics.FromImage(pictureBoxGarden.Image);
            _graphics.Clear(_baseColor);

            _size = new Size();
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            buttonIsPressed = false;

            button_Apply.Visible = isValidGardenForm;
            isValidGardenForm = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (buttonIsPressed)
            {
                _graphics.Clear(_baseColor);

                Point point = new Point(e.X, e.Y);
                Size size = new Size(int.Abs(e.X - startPointRectangle.X), int.Abs(e.Y - startPointRectangle.Y));

                if (point.X > startPointRectangle.X)
                    point.X = startPointRectangle.X;

                if (point.Y > startPointRectangle.Y)
                    point.Y = startPointRectangle.Y;



                // grid
                for (int i = _sizeSqare; i < size.Width; i += _sizeSqare)
                    _graphics.DrawLine(Pens.line_for_rect, point.X + i, point.Y, point.X + i, point.Y + size.Height);
                for (int i = _sizeSqare; i < size.Height; i += _sizeSqare)
                    _graphics.DrawLine(Pens.line_for_rect, point.X, point.Y + i, point.X + size.Width, point.Y + i);

                // Main Rectangle
                _graphics.DrawRectangle(Pens.main_garden, point.X, point.Y, size.Width, size.Height);

                // Horizontal Number
                var numbersCoordinateHorizontal = GetNumberPoints(size.Width / _sizeSqare, point.X + size.Width / 2, point.Y);
                foreach (var number in numbersCoordinateHorizontal)
                    for (int i = 1; i < number.Length; i++)
                        _graphics.DrawLine(Pens.number, number[i], number[i - 1]);

                // Vertical Number
                var numbersCoordinateVertical = GetNumberPoints(size.Height / _sizeSqare, point.X, point.Y + size.Height / 2, true);
                foreach (var number in numbersCoordinateVertical)
                    for (int i = 1; i < number.Length; i++)
                        _graphics.DrawLine(Pens.number, number[i], number[i - 1]);

                isValidGardenForm = size.Width >= _sizeSqare && size.Height >= _sizeSqare;

                _size.Width = size.Width / _sizeSqare;
                _size.Height = size.Height / _sizeSqare;

                pictureBoxGarden.Invalidate();
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isValidGardenForm = false;
            buttonIsPressed = true;

            button_Apply.Visible = false;

            startPointRectangle = e.Location;
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            buttonIsPressed = false;

            _graphics.Clear(_baseColor);
        }

        private void pictureBoxGarden_MouseLeave(object sender, EventArgs e)
        {
            if (!button_Apply.Visible)
            {
                buttonIsPressed = false;

                button_Apply.Visible = false;

                _graphics.Clear(_baseColor);
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_size);

            this.Visible = false;
            var result = form2.ShowDialog();


            if (result == DialogResult.None)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        private void PrintExample(PictureBox canvas)
        {
            throw new NotImplementedException("Method PrintExample");
        }

        private const int _realSizeDigit = 5;
        private IList<Point[]> GetNumberPoints(int number, int x, int y, bool needSwap = false)
        {
            const int indentation = _realSizeDigit;
            const int size = 3 * 100;

            int dx = size / 100 * _realSizeDigit;
            int dy = size / 100 * _realSizeDigit;

            string strNumber = number.ToString();

            if (needSwap)
            {
                // vertical line

                if (x - dx - indentation > 10)
                    x -= dx + indentation;
                else
                    x += indentation;

                y -= dy * (strNumber.Length - 1) / 2;

                dx = 0;
            }
            else
            {
                // horizontal line

                if (y - dy - indentation > 10)
                    y -= dy + indentation;
                else
                    y += indentation;

                x -= dx * (strNumber.Length - 1) / 2;

                dy = 0;
            }

            List<Point[]> result = new List<Point[]> { };


            for (int i = 0; i < strNumber.Length; i++)
            {
                int digit = strNumber[i] - '0';
                result.Add(Numbers.GetDigit(digit, x + dx * i, y - dy * i, needSwap, size));
            }

            return result;
        }
    }
}
