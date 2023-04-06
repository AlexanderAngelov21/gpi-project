﻿using System;
using System.Drawing;

namespace Draw
{
	[Serializable]
	public class PointShape : Shape
	{
		public	PointShape(RectangleF rect) : base(rect)
		{}
		public PointShape(RectangleShape rectangle) : base(rectangle)
		{}
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				return true;
			else
				return false;
		}

		
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
		}

	}
}
