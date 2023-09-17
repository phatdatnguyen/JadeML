using System.Drawing.Drawing2D;

namespace JadeChem.Drawing
{
    public static class Drawing
    {
        #region Methods
        public static void DrawArrow(Graphics g, Pen pen, Brush brush, Arrow arrow)
        {
            // Calculate the angle and length of the arrow
            float angle = (float)Math.Atan2(arrow.EndPoint.Y - arrow.StartPoint.Y, arrow.EndPoint.X - arrow.StartPoint.X);

            // Draw the line
            g.DrawLine(pen, arrow.StartPoint, arrow.EndPoint);

            // Draw the arrowhead
            float arrowSize = 10; // Adjust the size of the arrowhead as needed
            PointF[] arrowPoints = new PointF[3];
            arrowPoints[0] = new PointF(arrow.EndPoint.X, arrow.EndPoint.Y);
            arrowPoints[1] = new PointF(arrow.EndPoint.X - arrowSize * (float)Math.Cos(angle + Math.PI / 6), arrow.EndPoint.Y - arrowSize * (float)Math.Sin(angle + Math.PI / 6));
            arrowPoints[2] = new PointF(arrow.EndPoint.X - arrowSize * (float)Math.Cos(angle - Math.PI / 6), arrow.EndPoint.Y - arrowSize * (float)Math.Sin(angle - Math.PI / 6));
            g.FillPolygon(brush, arrowPoints);
        }

        public static void DrawSplitArrow(Graphics g, Pen pen, Brush brush, SplitArrow splitArrow)
        {
            // Draw the line from the start point to the first split point
            g.DrawLine(pen, splitArrow.StartPoint, splitArrow.SplitPoint1);

            // Draw the line from the start point to the second split point
            g.DrawLine(pen, splitArrow.StartPoint, splitArrow.SplitPoint2);

            // Calculate the angle and length of the arrowheads
            float angle1 = (float)Math.Atan2(splitArrow.StartPoint.Y - splitArrow.SplitPoint1.Y, splitArrow.StartPoint.X - splitArrow.SplitPoint1.X);
            float angle2 = (float)Math.Atan2(splitArrow.StartPoint.Y - splitArrow.SplitPoint2.Y, splitArrow.StartPoint.X - splitArrow.SplitPoint2.X);
            float arrowSize = 10; // Adjust the size of the arrowheads as needed

            // Calculate the arrow points for the first arrowhead
            PointF[] arrowPoints1 = new PointF[3];
            arrowPoints1[0] = new PointF(splitArrow.SplitPoint1.X + arrowSize * (float)Math.Cos(angle1 + Math.PI / 6), splitArrow.SplitPoint1.Y + arrowSize * (float)Math.Sin(angle1 + Math.PI / 6));
            arrowPoints1[1] = splitArrow.SplitPoint1;
            arrowPoints1[2] = new PointF(splitArrow.SplitPoint1.X + arrowSize * (float)Math.Cos(angle1 - Math.PI / 6), splitArrow.SplitPoint1.Y + arrowSize * (float)Math.Sin(angle1 - Math.PI / 6));

            // Draw the first arrowhead
            g.FillPolygon(brush, arrowPoints1);

            // Calculate the arrow points for the second arrowhead
            PointF[] arrowPoints2 = new PointF[3];
            arrowPoints2[0] = new PointF(splitArrow.SplitPoint2.X + arrowSize * (float)Math.Cos(angle2 + Math.PI / 6), splitArrow.SplitPoint2.Y + arrowSize * (float)Math.Sin(angle2 + Math.PI / 6));
            arrowPoints2[1] = splitArrow.SplitPoint2;
            arrowPoints2[2] = new PointF(splitArrow.SplitPoint2.X + arrowSize * (float)Math.Cos(angle2 - Math.PI / 6), splitArrow.SplitPoint2.Y + arrowSize * (float)Math.Sin(angle2 - Math.PI / 6));

            // Draw the second arrowhead
            g.FillPolygon(brush, arrowPoints2);
        }

        public static GraphicsPath GetRoundedRectanglePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius);
            path.CloseFigure();

            return path;
        }
        #endregion
    }
}
