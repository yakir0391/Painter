using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WindowsFormsApp1;
namespace WindowsFormsApp1
{
    [Serializable] //!7

   
    public abstract class Figure
    {
        public abstract void Draw(Pen p, Graphics g, float width, float height);
    }

    [Serializable] //!7
    public class MyCircle : Figure
    {
        float _x;  //private
        float _y;
        public MyCircle(float x, float y)
        {
            _x = x;
            _y = y;
        }
        public override void Draw(Pen p, Graphics g, float width, float height)
        {
            g.DrawEllipse(p, _x, _y, width, height);
        }
    }
    public class MyLine: Figure
    {
        float _x;  //private
        float _y;
        public MyLine(float x, float y)
        {
            _x = x;
            _y = y;
        }
        public override void Draw(Pen p, Graphics g, float pendx, float pendy)
        {
          g.DrawLine(p, pendx, pendy ,_x ,_y );
        }
     }
    [Serializable] //!7

    public abstract class MyQuadrangular : Figure
    {
        public override abstract void Draw(Pen p, Graphics g, float width, float height);
    }
    public class MyRectangle : MyQuadrangular
    {
        float _x;
        float _y;
        public MyRectangle(float x, float y)
        {
            _x = x;
            _y = y;
        }
        public override void Draw(Pen p, Graphics g, float width, float height)
        {
            g.DrawRectangle(p, _x, _y, width, height);
        }
    }
    [Serializable] //!7

    public class MySquare : MyQuadrangular
    {
        float _x;
        float _y;
        public MySquare(float x, float y)
        {
            _x = x;
            _y = y;
        }
        public override void Draw(Pen p, Graphics g, float width, float height)
        {
            g.DrawRectangle(p, _x, _y, width, width);
        }
    }
    [Serializable] //!7

    public class FigureList
    {
        public List<Figure> figures;

        public FigureList()
        {
            figures = new List<Figure>();
        }

    }
}