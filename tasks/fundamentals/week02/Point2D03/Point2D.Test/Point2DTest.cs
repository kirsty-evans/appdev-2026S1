namespace Point2D.Test;

using Point2D.Point2D;
using Point2D.Line;

public class DistTest {

    [Fact]
	public void TestCheckImplementationGetX() {
		Point2D p = new Point2D(1.0, 2.0);
		Assert.Equals(1.0, p.getX(), 0.00001);
	}
	

    [Fact]
	public void TestCheckImplementationGetY() {
		Point2D p = new Point2D(6.0, 2.0);
		Assert.Equals(2.0, p.getY(), 0.00001);
	}
	
    [Fact]
	public void TestCheckImplementationGetCoords() {
		Point2D p = new Point2D(11.0, 3.0);
		Assert.Equals(new double[] {11.0, 3.0}, p.getCoords(), 0.00001); //need to check
	}
	
    [Fact]
	public void TestDist1() {
		Point2D a = new Point2D(2.0, 3.5);
		Point2D b = new Point2D(1.0, 3.5);
		Point2D p = Line.findPoint(a, b, 0.5);
		
		Assert.Equals(1.5, p.getX(), 0.00001);
		Assert.Equals(3.5, p.getY(), 0.00001);
		
	}
	
    [Fact]
	public void TestDist2() {
		Point2D a = new Point2D(2.0, 5.5);
		Point2D b = new Point2D(2.0, 3.5);
		Point2D p = Line.findPoint(a, b, 0.5);
		
		Assert.Equals(2.0, p.getX(), 0.00001);
		Assert.Equals(4.5, p.getY(), 0.00001);
		
		
	}
	
    [Fact]
	public void TestDist3() {
		Point2D a = new Point2D(1.0, 1.0);
		Point2D b = new Point2D(0, 0);
		Point2D p = Line.findPoint(a, b, 0.30);
		
		Assert.Equals(0.7, p.getX(), 0.00001);
		Assert.Equals(0.7, p.getY(), 0.00001);
		
		
	}
	
	
    [Fact]
	public void TestDist4() {
		Point2D a = new Point2D(0, 0);
		Point2D b = new Point2D(1.0, 1.0);
		Point2D p = Line.findPoint(a, b, 0.75);
		
		Assert.Equals(0.75, p.getX(), 0.00001);
		Assert.Equals(0.75, p.getY(), 0.00001);
		
		
	}

    [Fact]
	public void TestDist5() {
		Point2D b = new Point2D(2.0, 0.5);
		Point2D a = new Point2D(0, 0);
		Point2D p = Line.findPoint(a, b, 0.75);
		
		Assert.Equals(1.5, p.getX(), 0.00001);
		Assert.Equals(0.375, p.getY(), 0.00001);
		
		
	}
	
    [Fact]
	public void TestNull() {
		Point2D b = new Point2D(2.0, 0.5);
		Point2D a = new Point2D(0, 0);
		Point2D p = Line.findPoint(a, b, 1.5);
		Aseert.Null(p);
	}	
	
	
	
}
