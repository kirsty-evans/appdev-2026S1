namespace GroupProject;


public class Group
{
	Member[] members;
	int size = 0;
	
	public Group(int size)
	{
		members = new Member[size];
	}


	public bool AddMember(Member member)
	{
		if(size >= members.Length) {
			return false;
		}
	
		for(int i = 0; i < members.Length; i++) {
			if(members[i] == null) {
				members[i] = member;
				size++;
				break;
			}
		}
		return true;
	}

	public bool RemoveMember(Member member)
	{	
		for(int i = 0; i < members.Length; i++) {
			if(members[i] != null &&
				members[i].GetMemberNo() ==
				member.GetMemberNo()) {

				members[i] = null;
				size--;
				return true;
			}
		}
		return false;
		
	}

	// public bool AddMember(Member member)
	// {
	// 	if(size < members.Length) {
	// 		members[size] = member;
	// 		size += 1;
	// 		return true;
	// 	}
	// 	return false;
	// }

	

	// public bool RemoveMember(Member member)
	// {
	// 	// Sol-1 Move everything after i
	// 	// down one index

	// 	//1 find the member
	// 	int index = -1;
	// 	for(int i = 0; i < size; i++) {
	// 		if(members[i].GetMemberNo() == member.GetMemberNo()) {
	// 			index = i;
	// 			break;
	// 		}
	// 	}

	// 	if(index >= 0) {
	// 		// Sets the element to null in the array
	// 		members[index] = null;

	// 		/*
	// 		Remove(9)
	// 			| 1 | 6  | 9 | 10 | 55 |

						   
	// 			| 1 | 6  | 10 | 55 | (55) | 

	// 		*/
	// 		//2 Remove and shift elements down
	// 		for(int i = index; i < size-1; i++) {
	// 			members[i] = members[i+1];
	// 		}
	// 		size--;
	// 		return true;
	// 	}
	// 	return false;
	// }

	public Member[] AllMembers()
	{
		Member[] presentMembers =
			new Member[size];
		for(int i = 0; i < size; i++) {
			presentMembers[i] = members[i];
		}
		return presentMembers;
	}


	public Member? GetMember(int memberNo)
	{
		Member? match = null;
		for(int i = 0; i < size; i++) {
			if(members[i].GetMemberNo()
				== memberNo) {
				match = members[i];
				break;		
			}
		}
		
		return match;
	}


	public int GroupSize()
	{
		return size;
	}

}
