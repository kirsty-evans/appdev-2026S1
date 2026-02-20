namespace SlidingWindow.Test;

public class SlidingWindowTest
{
    
    [Fact]
    public void Test_SlidingWindow_Get1_0_0()
    {

        int[] view = [1, 2, 3, 4];

        SlidingWindow sw = new SlidingWindow(view, 0, 4);

        int[] expected = [1, 2, 3, 4];

        for(int i = 0; i < expected.Length; i++) {
            int e = expected[i];
            Assert.Equal(e, sw.GetElement(i));
        } 
    }
    
    [Fact]
    public void Test_SlidingWindow_Get2_2_2()
    {

        int[] view = [1, 2, 3, 4];

        SlidingWindow sw = new SlidingWindow(view, 2, 2);

        int[] expected = [3, 4];

        for(int i = 0; i < expected.Length; i++) {
            int e = expected[i];
            Assert.Equal(e, sw.GetElement(i));
        } 
    }
    [Fact]
    public void Test_SlidingWindow_Get3_1_3()
    {

        int[] view = [1, 2, 3, 4];
        

        SlidingWindow sw = new SlidingWindow(view, 1, 3);

        int[] expected = [2, 3, 4];



        for(int i = 0; i < expected.Length; i++) {
            int e = expected[i];
            Assert.Equal(e, sw.GetElement(i));
        } 
    }
    
    [Fact]
    public void Test_SlidingWindow_Set3_1_3()
    {

        int[] view = [1, 2, 3, 4];
        

        SlidingWindow sw = new SlidingWindow(view, 1, 3);

        int[] writable = [10, 10, 10];
        int[] expected = [1, 10, 10, 10];

        for(int i = 0; i < writable.Length; i++) {
            int e = writable[i];
            sw.SetElement(e, i);
        }


        for(int i = 0; i < expected.Length; i++) {
            int e = expected[i];
            Assert.Equal(e, view[i]);
        } 
    }
    
    [Fact]
    public void Test_SlidingWindow_Set3_0_3()
    {

        int[] view = [1, 2, 3, 4];
        
        SlidingWindow sw = new SlidingWindow(view, 0, 4);

        int[] writable = [10, 10, 10];
        int[] expected = [10, 10, 10, 4];

        for(int i = 0; i < writable.Length; i++) {
            int e = writable[i];
            sw.SetElement(e, i);
        }

        for(int i = 0; i < expected.Length; i++) {
            int e = expected[i];
            Assert.Equal(e, view[i]);
        } 
    }

    [Fact]
    public void Test_SlidingWindow_SetGet2_4_6()
    {
        int[] view = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];

        int[] expected = [1, 2, 3, 4, 45, 67, 23, 10, 78, 22, 11, 12];
        SlidingWindow sw = new SlidingWindow(view, 4, 6);

        int[] writable = [45, 67, 23, 10, 78, 22];

        for(int i = 0; i < writable.Length; i++) {
            int e = writable[i];
            sw.SetElement(e, i);
        }

        for(int i = 0; i < expected.Length; i++) {
            int e = expected[i];
            Assert.Equal(e, view[i]);
        } 
    }

    [Fact]
    public void Test_SlidingWindow_SetGetWOffset1_4_6()
    {
        
        int[] view = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
        SlidingWindow sw = new SlidingWindow(view, 4, 6);

        int[] input = [45, 67, 23, 10, 78, 22];
        int[] expected1 = [1, 2, 3, 4, 45, 67];
        int[] expected2 = [23, 10, 78, 22, 11, 12];

        for(int i = 0; i < input.Length; i++) {
            int e = input[i];
            sw.SetElement(e, i);
        }

        sw.SetOffset(0);

        
        for(int i = 0; i < expected1.Length; i++) {
            int e = expected1[i];
            int a = sw.GetElement(i);
            Assert.Equal(e, a);
        }

        sw.SetOffset(6);
        
        for(int i = 0; i < expected2.Length; i++) {
            int e = expected2[i];
            int a = sw.GetElement(i);
            Assert.Equal(e, a);
        }
        
        
    }

    [Fact]
    public void Test_SlidingWindow_SetGetWOffset2_4_6()
    {
        
        int[] view = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
        SlidingWindow sw = new SlidingWindow(view, 0, 6);

        int[] input1 = [20, 40];
        int[] input2 = [100, 200];
        int[] expected1 = [20, 40, 3, 4, 5, 6];
        int[] expected2 = [100, 200, 9, 10, 11, 12];

        for(int i = 0; i < input1.Length; i++) {
            int e = input1[i];
            sw.SetElement(e, i);
        }
        
        sw.SetOffset(6);

        for(int i = 0; i < input2.Length; i++) {
            int e = input2[i];
            sw.SetElement(e, i);
        }
        
        for(int i = 0; i < expected1.Length; i++) {
            int e = expected1[i];
            Assert.Equal(e, view[i]);
        }
        
        for(int i = 0; i < expected2.Length; i++) {
            int e = expected2[i];
            Assert.Equal(e, view[expected1.Length+i]);
        }
        
        
    }
}
    

