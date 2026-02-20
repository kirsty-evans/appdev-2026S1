namespace Group.Test;

internal enum TestAction
{
    None,
    Add,
    Remove,
    Get,
    GetSize,
    All
}

internal class GroupTestAction
{

    public TestAction Action { get; set; } = TestAction.None;
    public Member? Member { get; set; } = null;
    public int MemberNo { get; set; } = -1;
    public bool ExpectedBool { get; set; } = false;
    public int ExpectedInt { get; set; } = -1;
    public Member[] ExpectedAll { get; set; } = new Member[1];

    public GroupTestAction(TestAction action, Member? member,
        int expectedInt, bool expectedBool, Member[] expectedAll)
    {
        this.Action = action;
        this.Member = member;
        this.MemberNo = member != null ? member.GetMemberNo() : -1;
        this.ExpectedBool = expectedBool;
        this.ExpectedInt = expectedInt;
        this.ExpectedAll = expectedAll;
    }

    public static GroupTestAction MakeAdd(bool b, Member? m)
    {
        return new GroupTestAction(TestAction.Add, m, m.GetMemberNo(),
            b, null);
    }
    public static GroupTestAction MakeRemove(bool b, Member? m)
    {
        return new GroupTestAction(TestAction.Remove, m, m.GetMemberNo(),
            b, null);
    }
    public static GroupTestAction MakeGet(bool b, Member? m)
    {
        return new GroupTestAction(TestAction.Get, m, m.GetMemberNo(),
            b, null);
    }
    public static GroupTestAction MakeAll(Member[] members)
    {
        return new GroupTestAction(TestAction.All, null, members.Length,
            false, members);
    }
    public static GroupTestAction MakeSize(int size)
    {
        return new GroupTestAction(TestAction.GetSize, null, size,
            false, null);
    }
}


public class GroupTest
{
    private static Member[] MemberDefaults = {
        new Member("Jeff"),
        new Member("Alice"),
        new Member("Bob"),
        new Member("Lucy"),
        new Member("Robin")
    };

    private void TestHelper(
        Group group,
        Member[] currentMembers,
        GroupTestAction[] actions)
    {

        foreach(Member m in currentMembers)
        {
            group.AddMember(m);
        }

        foreach(GroupTestAction a in actions)
        {
            if(a.Action == TestAction.Add)
            {
                Member m = a.Member;
                bool expectedB = a.ExpectedBool;
                bool rb = group.AddMember(m);
                Assert.Equal(expectedB, rb);
            }
            else if (a.Action == TestAction.Remove)
            {
                Member m = a.Member;
                bool expectedB = a.ExpectedBool;
                bool rb = group.RemoveMember(m);
                Assert.Equal(expectedB, rb);
                
            }
            else if(a.Action == TestAction.Get)
            {
                int memberNo = a.MemberNo;
                Member? expectedMember = a.Member;
                
                Member? gottenM = group.GetMember(memberNo);
                Assert.Equal(expectedMember, gottenM);
            }
            else if(a.Action == TestAction.GetSize)
            {
                int expected = a.ExpectedInt;
                int size = group.GroupSize();
                Assert.Equal(expected, size);
            }
            else if(a.Action == TestAction.All)
            {
                Member[] expectedAll = a.ExpectedAll;
                Member[] gottenAll = group.AllMembers();
                Assert.Equal(expectedAll, gottenAll);
            }
        }
    }
    [Fact]
    public void Test_GroupGetSize_1()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeSize(2)
        });
        
        
    }

    [Fact]
    public void Test_GroupAllMembers_1()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeAll(new Member[] {
                MemberDefaults[0],
                MemberDefaults[1],
            })
        });
        
        
    }

    [Fact]
    public void Test_GroupAddNormal_1()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
        },
        new GroupTestAction[] {
            GroupTestAction.MakeAdd(true, MemberDefaults[2]),
            GroupTestAction.MakeAdd(true, MemberDefaults[3]),
            GroupTestAction.MakeSize(2)
        });
        
        
    }

    [Fact]
    public void Test_GroupAddNormal_2()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeAdd(true, MemberDefaults[2]),
            GroupTestAction.MakeAdd(true, MemberDefaults[3]),
            GroupTestAction.MakeSize(4)
        });

    }

    [Fact]
    public void Test_GroupAdd_AtCapacity_3()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeAdd(true, MemberDefaults[2]),
            GroupTestAction.MakeAdd(true, MemberDefaults[3]),
            GroupTestAction.MakeAdd(false, MemberDefaults[4]),
        });

    }

    [Fact]
    public void Test_GroupAdd_AtCapacity_4()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeAdd(true, MemberDefaults[2]),
            GroupTestAction.MakeAdd(true, MemberDefaults[3]),
            GroupTestAction.MakeAdd(false, MemberDefaults[4]),
            GroupTestAction.MakeAdd(false, MemberDefaults[1]),
        });

    }

    [Fact]
    public void Test_GroupRemove_1()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeRemove(true, MemberDefaults[0]),
            GroupTestAction.MakeSize(1),
        });

    }

    [Fact]
    public void Test_GroupRemove_2()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeRemove(true, MemberDefaults[0]),
            GroupTestAction.MakeRemove(true, MemberDefaults[1]),
            GroupTestAction.MakeSize(0),
        });

    }
    
    [Fact]
    public void Test_GroupRemove_3()
    {
        int size = 4;
        Group g = new Group(size);
        TestHelper(g,
        new Member[] {
            MemberDefaults[0],
            MemberDefaults[1],
        },
        new GroupTestAction[] {
            GroupTestAction.MakeRemove(true, MemberDefaults[0]),
            GroupTestAction.MakeRemove(true, MemberDefaults[1]),
            GroupTestAction.MakeRemove(false, MemberDefaults[2]),
            GroupTestAction.MakeRemove(false, MemberDefaults[0]),
            GroupTestAction.MakeSize(0),
        });

    }
}
