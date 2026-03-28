namespace Points {

	public class Line
	{
		public static Point2D FindPoint(Point2D a, Point2D b, double d) {
			if(d > 1.0 || d < 0) {
				return null;
			}
			
			double x = a.GetX() + ((b.GetX() - a.GetX()) * d);
			double y = a.GetY() + ((b.GetY() - a.GetY()) * d);
			
			return new Point2D(x, y);
		}


	}

}
