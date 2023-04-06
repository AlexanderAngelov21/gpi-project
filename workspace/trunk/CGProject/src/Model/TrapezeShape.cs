using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    [Serializable]
    public class TrapezeShape : Shape
    {
        #region Constructor
        public TrapezeShape(RectangleF trapeze) : base(trapeze)
        {
        }

        public TrapezeShape(TrapezeShape trapeze) : base(trapeze)
        {
        }
        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {

            base.DrawSelf(grfx);

            base.RotateShape(grfx);

            Point[] p1 = { new Point(100, 100), new Point(200, 100), new Point(200, 50), new Point(50, 0) };

            Point[] p = {
                new Point((int)Rectangle.X + ((int)Rectangle.Width / 2), (int)Rectangle.Y),
                new Point((int)Rectangle.X, (int)(Rectangle.Y + Rectangle.Height)),
                 new Point((int)(Rectangle.X + Rectangle.Width), (int)(Rectangle.Y + Rectangle.Height)),
                new Point((int)(Rectangle.X + Rectangle.Width),(int)Rectangle.Y)
                };


            grfx.FillPolygon(new SolidBrush(Color.FromArgb(Opacity, FillColor)), p);
            grfx.DrawPolygon(new Pen(StrokeColor, StrokeWidth), p);

            grfx.ResetTransform();


        }




    }
}
