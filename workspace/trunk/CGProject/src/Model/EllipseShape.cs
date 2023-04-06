using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Draw
{
	[Serializable]
	public class EllipseShape : Shape
	{
		#region Constructor
		
		public EllipseShape(RectangleF rect) : base(rect)
		{
		}
		
		public EllipseShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		
		#endregion

		
		
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
			{
				float x = point.X;
				float y = point.Y;
				//rx is semi-major axis
				//ry is semi-minor axis
				float rx = Width / 2;
				float ry = Height / 2;
				//(h,k) cordinates of the center of the ellipse
				float h = Location.X + rx;
				float k = Location.Y + ry;
				//formula: (x-h)^2/rx^2 +(y-k)^2/ry^2<=1
				bool inEllipse =(Math.Pow((x - h), 2) /
					Math.Pow(rx, 2))
					+
					(Math.Pow((y - k), 2) /
					Math.Pow(ry, 2))<=1;
				return inEllipse;
			}
			else
			{
				return false;
			}
		}

		public override void DrawSelf(Graphics grfx)
		{

			base.DrawSelf(grfx);
			base.RotateShape(grfx);

			grfx.FillEllipse(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(StrokeColor, StrokeWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.ResetTransform();

		}
	}
}
