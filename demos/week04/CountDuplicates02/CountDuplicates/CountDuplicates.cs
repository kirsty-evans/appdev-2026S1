namespace CountDuplicates;

public class CountDuplicate
{

	private static bool AlreadyExists(int[] knownArray, int size, int possibleEntry)
	{
		for(int i = 0; i < size; i++)
		{
			if(possibleEntry == knownArray[i])
			{
				return true;
			}
		}
		return false;
	}

	public static int CountDuplicates(int[] a) {

		if(a == null) {
			return 0;
		}

		int entryNumber = 0;
		int[] knownDuplicates = new int[a.Length];

		for(int i = 0; i < a.Length; i++)
		{
			int toFind = a[i];
			
			for(int j = 0; j < a.Length; j++)
			{
				if(toFind == a[j] && i != j
					&& !AlreadyExists(knownDuplicates, entryNumber, toFind))
				{
					knownDuplicates[entryNumber] = toFind;
					entryNumber++;
					break;
				}	
			}
		}
		
		
		return entryNumber;
	}

}
