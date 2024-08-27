using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGarden
{
    public partial class Form2 : Form
    {
        private DataTable table;

        private int _sizeHend = 0;

        private Point startPoint = new Point(3, 3);
        private Color _baseColor;
        private Graphics _graphics;
        private int _sizeSqare;
        private Size _size;
        private DialogResult result;

        public Form2()
        {
            InitializeComponent();
  
            _sizeSqare = 15;

            pictureBoxGarden.Image = new Bitmap(pictureBoxGarden.Width, pictureBoxGarden.Height);
            _graphics = Graphics.FromImage(pictureBoxGarden.Image);
            _graphics.Clear(_baseColor);

            table = new DataTable();
            {
                table.Columns.Add("Название");
                table.Columns.Add("Срок созревания");
                table.Columns.Add("Дата высадки");
                table.Columns.Add("Как часто поливать");
                table.Columns.Add("Цена");

                table.Rows.Add("Дуб", "20 лет", "Март", "Раз в неделю", "$200");
                table.Rows.Add("Клен", "15 лет", "Апрель", "Раз в неделю", "$180");
                table.Rows.Add("Береза", "10 лет", "Апрель", "Раз в неделю", "$150");
                table.Rows.Add("Сосна", "30 лет", "Май", "Раз в две недели", "$250");
                table.Rows.Add("Ель", "25 лет", "Май", "Раз в две недели", "$230");
                table.Rows.Add("Яблоня", "5 лет", "Март", "Раз в неделю", "$100");
                table.Rows.Add("Груша", "6 лет", "Март", "Раз в неделю", "$120");
                table.Rows.Add("Вишня", "4 года", "Апрель", "Раз в неделю", "$90");
                table.Rows.Add("Слива", "5 лет", "Апрель", "Раз в неделю", "$110");
                table.Rows.Add("Липа", "20 лет", "Май", "Раз в неделю", "$210");
            }


            dataGridView1.DataSource = table;
        }

        public Form2(Size size) : this()
        {
            result = new DialogResult();
            result = DialogResult.OK;

            _size = size;
        }
        private void PrintStartGrid()
        {
            _graphics.Clear(_baseColor);

            // grid
            for (int i = 0; i < _size.Width; i++)
                _graphics.DrawLine(Pens.line_for_rect, _sizeSqare * i + startPoint.X, +startPoint.Y, _sizeSqare * i + startPoint.X, _size.Height * _sizeSqare + startPoint.Y);
            for (int i = 0; i < _size.Height; i++)
                _graphics.DrawLine(Pens.line_for_rect, +startPoint.X, _sizeSqare * i + startPoint.Y, _size.Width * _sizeSqare + startPoint.X, _sizeSqare * i + startPoint.Y);

            // Main Rectangle
            _graphics.DrawRectangle(Pens.main_garden, +startPoint.X, +startPoint.Y, _size.Width * _sizeSqare + startPoint.X, _size.Height * _sizeSqare + startPoint.Y);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_size.Width == 0 || _size.Height == 0)
            {
                throw new InvalidSizeGarden($"Square Garden must be better 0. You -> {_size}");
            }
            else
            {
                PrintStartGrid();
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            _sizeHend = 1;
            label1.Text = _sizeHend.ToString();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            _sizeHend = 3;
            label1.Text = _sizeHend.ToString();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            _sizeHend = 5;
            label1.Text = _sizeHend.ToString();
        }

        private void pictureBoxGarden_MouseMove(object sender, MouseEventArgs e)
        {
            PrintStartGrid();

            int x = e.X / _sizeSqare * _sizeSqare + startPoint.X + (int)Pens.line_for_rect.Width;
            int y = e.Y / _sizeSqare * _sizeSqare + startPoint.Y + (int)Pens.line_for_rect.Width;

            int currSize = _sizeSqare - (int)Pens.line_for_rect.Width;

            for (int i = 0; i < _sizeHend; i++)
            {
                int y1 = y;

                for (int j = 0; j < _sizeHend; j++)
                {
                    _graphics.FillRectangle(Pens.select_Rects.Brush, x,y1, currSize, currSize);

                    y1 += _sizeSqare;
                }

                x += _sizeSqare;
            }

            pictureBoxGarden.Invalidate();
        }
    }
}
