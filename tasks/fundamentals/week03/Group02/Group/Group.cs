namespace Group;

public class Group
{

	private int size;
	private int currentMembers;
	private	Member[] members;
	public Group(int size)
	{
		this.size = size;
		currentMembers = 0;
		members = new Member[size];

		
	}

	public bool AddMember(Member member)
	{
		if (currentMembers < size)
			{
				members[currentMembers] = member;
				currentMembers++;
				return true;
			}

		return false;
			
		}
	

	public bool RemoveMember(Member member)
	{


		for (int i = 0; i < currentMembers; i++)
		{
			if (members[i] == member)
			{
				members[i] = members[currentMembers - 1]; // Move the last member to the current position so there is no gap
				members[currentMembers - 1] = null; // Clear the last position
				currentMembers--;
				return true;
			}
		}

		return false;
	}

	public Member[] AllMembers()
	{
		Member[] allMembers = new Member[currentMembers];
		for (int i = 0; i < currentMembers; i++)
		{
			allMembers[i] = members[i];
		}

		return allMembers;
	}


	public Member? GetMember(int memberNo)
	{
		for (int i = 0; i < currentMembers; i++)
		{
			if (members[i].GetMemberNo() == memberNo)
			{
				return members[i];
			}
		}
		return null;
	}


	public int GroupSize()
	{
		return currentMembers;;
	}

}
