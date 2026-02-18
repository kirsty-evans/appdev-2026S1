namespace Group;

public class Member
{

	// Used as part of the type, it is for generating the sequences
	private static int MemberNoSequenceValue = 1;

	// Below are the instance fields
	
	private int memberNo;
	private string name;

	/// <summary>
	/// Constructor <c>Member</c>, public constructor for the type
	/// </summary>
	public Member(string name)
	{
		memberNo = NextMemberNoSequenceValue();
		this.name = name;
	}

	/// <summary>
	/// Method <c>NextMemberNoSequenceValue</c>
	/// YOU CAN IGNORE THIS METHOD
	/// It is used to generate the next member number upon construction
	/// </summary>
	private static int NextMemberNoSequenceValue()
	{
		int v = MemberNoSequenceValue;
		MemberNoSequenceValue++;
		return v;
	}


	/// <summary>
	/// Method <c>GetName</c> Returns the name of the member
	/// </summary>
	public string GetName()
	{
		return name;
	}

	/// <summary>
	/// Method <c>GetMemberNo</c> Returns the member number of the Member
	/// </summary>
	public int GetMemberNo()
	{
		return memberNo;
	}

}
