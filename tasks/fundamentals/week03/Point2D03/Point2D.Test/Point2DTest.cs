namespace Points.Test;

using Points;

public class DistTest {

	private void CoordsCheck(Point2D p, double[] answer) {
		
		Assert.Equal(answer[0], p.GetCoords()[0], 0.00001);
		Assert.Equal(answer[1], p.GetCoords()[1], 0.00001);
		Assert.Equal(answer[2], p.GetCoords()[2], 0.00001);
	}

    [Fact]
	public void TestCheckImplementationGetX() {
		Point2D p = new Point2D(1.0, 2.0);
		Assert.Equal(1.0, p.GetX(), 0.00001);
	}
	

    [Fact]
	public void TestCheckImplementationGetY() {
		Point2D p = new Point2D(6.0, 2.0);
		Assert.Equal(2.0, p.GetY(), 0.00001);
	}
	
    [Fact]
	public void TestCheckImplementationGetCoords() {
		Point2D p = new Point2D(11.0, 3.0);
		double[] answer = new double[] {11.0, 3.0};
		CoordsCheck(p, answer);
		//need to check
	}
	
    [Fact]
	public void TestDist1() {
		Point2D a = new Point2D(2.0, 3.5);
		Point2D b = new Point2D(1.0, 3.5);
		Point2D p = Line.FindPoint(a, b, 0.5);
		
		Assert.Equal(1.5, p.GetX(), 0.00001);
		Assert.Equal(3.5, p.GetY(), 0.00001);
		
	}
	
    [Fact]
	public void TestDist2() {
		Point2D a = new Point2D(2.0, 5.5);
		Point2D b = new Point2D(2.0, 3.5);
		Point2D p = Line.FindPoint(a, b, 0.5);
		
		Assert.Equal(2.0, p.GetX(), 0.00001);
		Assert.Equal(4.5, p.GetY(), 0.00001);
		
		
	}
	
    [Fact]
	public void TestDist3() {
		Point2D a = new Point2D(1.0, 1.0);
		Point2D b = new Point2D(0, 0);
		Point2D p = Line.FindPoint(a, b, 0.30);
		
		Assert.Equal(0.7, p.GetX(), 0.00001);
		Assert.Equal(0.7, p.GetY(), 0.00001);
		
		
	}
	
	
    [Fact]
	public void TestDist4() {
		Point2D a = new Point2D(0, 0);
		Point2D b = new Point2D(1.0, 1.0);
		Point2D p = Line.FindPoint(a, b, 0.75);
		
		Assert.Equal(0.75, p.GetX(), 0.00001);
		Assert.Equal(0.75, p.GetY(), 0.00001);
		
		
	}

    [Fact]
	public void TestDist5() {
		Point2D b = new Point2D(2.0, 0.5);
		Point2D a = new Point2D(0, 0);
		Point2D p = Line.FindPoint(a, b, 0.75);
		
		Assert.Equal(1.5, p.GetX(), 0.00001);
		Assert.Equal(0.375, p.GetY(), 0.00001);
		
		
	}
	
    [Fact]
	public void TestNull() {
		Point2D b = new Point2D(2.0, 0.5);
		Point2D a = new Point2D(0, 0);
		Point2D p = Line.FindPoint(a, b, 1.5);
		Assert.Null(p);
	}	
	
	
	
}
