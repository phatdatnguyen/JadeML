namespace JadeChem.Drawing
{
    public class SplitArrow
    {
        #region Properties
        public Point StartPoint { get; set; }
        public Point SplitPoint1 { get; set; }
        public Point SplitPoint2 { get; set; }
        #endregion

        #region Constructor
        public SplitArrow(Point startPoint, Point splitPoint1, Point splitPoint2)
        {
            StartPoint = startPoint;
            SplitPoint1 = splitPoint1;
            SplitPoint2 = splitPoint2;
        }
        #endregion
    }
}
