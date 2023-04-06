using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{

    [Serializable]

    public class GroupShape : Shape
    {
        #region Constructor

        public GroupShape(RectangleF rect) : base(rect)
        {
        }

        public GroupShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion
        protected List<Shape> subShape = new List<Shape>();
        public List<Shape> SubShape
        {
            get { return subShape; }
            set { subShape = value; }
        }

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                foreach (var item in subShape)
                {
                    if (item.Contains(point)) return true;
                }
                return true;
            }
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

            foreach (var item in subShape)
            {
                item.DrawSelf(grfx);
            }
        }
        public override void Move(float dx, float dy)
        {
            
            foreach (var item in subShape)
            {
                item.Move(dx, dy);
            }
        }

        public override void GroupRotate(float angle)
        {
            base.GroupRotate(angle);
            foreach (var item in SubShape)
            {
                item.ShapeAngle += angle;
            }
        }


        public override void GroupResizeWidth(float width)
        {
            base.GroupResizeWidth(width);
            float maxX = float.MinValue;
            float minX = float.MaxValue;
            foreach (var item in SubShape)
            {
                item.Width = width;
                if (minX > item.Location.X)
                {
                    minX = item.Location.X;
                }
                if (maxX < item.Location.X + item.Width)
                {
                    maxX = item.Location.X + item.Width;
                }

            }
            this.Rectangle = new RectangleF(minX, this.Rectangle.Y, maxX - minX, this.Rectangle.Height);

        }
        public override void GroupResizeHeight(float height)
        {
            base.GroupResizeHeight(height);
            float maxY = float.MinValue;
            float minY = float.MaxValue;
            foreach (var item in SubShape)
            {
                item.Height = height;
                if (minY > item.Location.Y)
                {
                    minY = item.Location.Y;
                }
                if (maxY < item.Location.Y + item.Height)
                {
                    maxY = item.Location.Y + item.Height;
                }

            }
            this.Rectangle = new RectangleF(this.Rectangle.X, minY, this.Rectangle.Width, maxY - minY);

        }


        public override void GroupOpacity(int opacity)
        {
            base.GroupOpacity(opacity);
            foreach (var item in SubShape)
            {
                item.Opacity = opacity;
            }
        }
        public override void GroupFillColor(Color color)
        {
            base.GroupFillColor(color);
            foreach (var item in SubShape)
            {
                item.FillColor = color;
            }
            
        }
        public override void GroupStrokeColor(Color color)
        {
            base.GroupStrokeColor(color);
            foreach (var item in SubShape)
            {
                item.StrokeColor = color;
            }
        }


    }
}