namespace Counter;

public class Counter

{

	private int count;
	private int originalStart;
	public Counter() {
		count = 0;
		originalStart = 0;
		
	}

	public Counter(int start)
	{

		count = start;
		originalStart = start;
		
	}


	public void Forward()
	{
		count++;
	}


	public void Backward()
	{
		count--;
	}


	public int Get()
	{
		return count;
	}

	public void Reset()
	{
		count = originalStart;
	}
}
