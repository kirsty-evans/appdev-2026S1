namespace Points {

	public class Point2D
	{
		double x;
		double y;

		public Point2D(double x, double y) {
			this.x = x;
			this.y = y;
		
		}


		public double GetX() {
			return x;
		}
		public double GetY() {
			return y;
		}

		public double[] GetCoords() {
			return new double[] {x, y};
		}
	}


}
