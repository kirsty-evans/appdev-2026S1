namespace Points {

	public class Line
	{
		public static Point2D FindPoint(Point2D a, Point2D b, double d) {
			
			// d is how far along the line from a to b the point is 
			// for example, d = 0.5 is halfway along the line
			// d has to be between 0 and 1 otherwise the point is out of range

			if (d < 0.0 || d > 1.0) {
				return null; // or throw an exception
			}

			double x = a.GetX() + ((b.GetX() - a.GetX()) * d);
			double y = a.GetY() + ((b.GetY() - a.GetY()) * d);


		 	return new Point2D(x, y);
		}
		}


	}
