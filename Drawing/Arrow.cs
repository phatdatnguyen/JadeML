namespace JadeChem.Drawing
{
    public class Arrow
    {
        #region Properties
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        #endregion

        #region Constructor
        public Arrow(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
        #endregion
    }
}
