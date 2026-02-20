namespace SlidingWindow;

public class SlidingWindow
{

	private int[] array; // 1D array of integers
	private int offset; // index of the array where the window will start
	private int length; // length of the window

	public SlidingWindow(int[] array, int offset, int length)
	{
		this.array = array;
		this.offset = offset;
		this.length = length;
	}

	public void SetOffset(int offset)
	{
		this.offset = offset;
		
	}

	public int GetElement(int index)
	{
		return array[offset + index];
	}

	public void SetElement(int value, int index)
	{
		if (index < 0 || index >= length)
		{
			return; // or exception
		}
		array[offset + index] = value;
	}

}
