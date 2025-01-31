﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 3);
        Pen erase = new Pen(Color.White, 20);
        
        int index;
        float x, y, sX, sY, cX, cY;
        FigureList pts = new FigureList();
        ColorDialog cd = new ColorDialog();
        Color new_color;
        

        public Form1()
        {
            InitializeComponent();
            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            
        }



        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
            switch (index)
            {
                case 3:
                    pts.figures.Add(new MyCircle(cX, cY));
                    break;
                case 4:
                    pts.figures.Add(new MyRectangle(cX, cY));
                    break;
                case 5:
                    pts.figures.Add(new MySquare(cX, cY));
                    break;
                case 6:
                    pts.figures.Add(new MyLine(cX, cY));
                    break;
            }
            pic.Invalidate();
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;
            if (index == 3)
            {
                pts.figures.Last().Draw(p, g, sX, sY);
            }
            if (index == 4)
            {
                pts.figures.Last().Draw(p, g, sX, sY);
            }
            if (index == 5)
            {
                pts.figures.Last().Draw(p, g, sX, sY);
            }
            if (index == 6)
            {
                pts.figures.Last().Draw(p, g, e.X, e.Y);
            }


        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void pic_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (paint)
            {
                if (index == 3)
                {
                    pts.figures.Last().Draw(p, g, sX, sY);
                }
                if (index == 4)
                {
                    pts.figures.Last().Draw(p, g, sX, sY);
                }
                if (index == 5)
                {
                    pts.figures.Last().Draw(p, g, sX, sY);
                }
                if (index == 6)
                {
                    pts.figures.Last().Draw(p, g, x, y);
                }
            }

        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
        
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {

                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }


            }
           
          pic.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

        }
        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btn_square_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.BackColor =Color.White;
            pic.Refresh();
            index = 0;

        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f* pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, e.X, e.Y, new_color);
            }
        }
        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "Images (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //pic.Image.Save(saveFileDialog1.FileName);
               bm.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            } 
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();   
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(open.FileName);
                this.bm = bp;
                g = Graphics.FromImage(this.bm);
                pic.Image = this.bm;

            }
        }
    }

}
    