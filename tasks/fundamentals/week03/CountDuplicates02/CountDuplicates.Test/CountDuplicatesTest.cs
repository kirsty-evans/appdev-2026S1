namespace CountDuplicates.Test;

public class CountDupTest
{
    [Fact]
    public void TestNoDups() {
        Assert.Equal(0, CountDuplicates.CountDuplicates(new int[]{1, 2, 3, 4, 5, 6, 7}));
    }
    
    [Fact]
    public void TestOneDupAdjacent() {
        Assert.Equal(1, CountDuplicates.CountDuplicates(new int[]{1, 1, 3, 4, 5, 6, 7}));
    }
    
    [Fact]
    public void TestOneDupNotAdjacent() {
        Assert.Equal(1, CountDuplicates.CountDuplicates(new int[]{1, 2, 3, 1, 5, 6, 7}));
    }
    
    [Fact]
    public void TestNull() {
        Assert.Equal(0, CountDuplicates.CountDuplicates(null));
    }
    
    [Fact]
    public void TestDupsVar1() {
        Assert.Equal(2, CountDuplicates.CountDuplicates(new int[]{1, 2, 3, 20, 5, 6, 6, 0, -1, -6, 4, 5}));
    }
    
    [Fact]
    public void TestDupsVar2() {
        Assert.Equal(5, CountDuplicates.CountDuplicates(new int[]{3, 6, 7, 2, 9, 1, 1, 3, 4, 6, 8, 8, 10, 11, 10, 1}));
    }
    
}
