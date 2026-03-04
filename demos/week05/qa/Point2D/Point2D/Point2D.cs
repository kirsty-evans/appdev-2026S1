namespace Points {

	public class Point2D
	{
		private double x = 0;
		private double y = 0;
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
