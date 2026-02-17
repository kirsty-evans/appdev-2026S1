namespace RowMajor;

public class RowMajorArray
{

    private int[] array;
    public int Width { get; private set; }
    public int Height { get; private set; }

    public RowMajorArray(int[] array, int width, int height) {
            this.array = array;
            this.Width = width;
            this.Height = height;
    }

    public int Get(int x, int y) {
        //  Retrieves an element from the array using x, y coordinates. 
        //  Given an array where there are 3 rows and 10 elements per a row, calling Get(5, 1) will get the element at index 15.
        

        // working out the formula..
        // (5,0) index would be 5
        // (5,1) index would be 15
        // (5,2) index would be 25
        // so the formula is x + (y*width)

        return this.array[y*this.Width + x];

    }

    // public void Set(int x, int y, int v) {


    }

