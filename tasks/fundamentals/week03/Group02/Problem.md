
# Making groups and teams

You have been tasked with completing the class `Group`, you will need to complete the following methods along with the constructor for the Group type.

* `Group(int size)` - `size` is the maximum size of the group that this group can hold. It is not the number of members that have been added to the group itself.

* `bool AddMember(Member member)` - Adds a member to the group. If the group has reached its capacity, the member would not be able to join, the method should return `false`, otherwise if the member is added, the method should return `true`.

* `bool RemoveMember(Member member)` - Removes a member from the group, you will need to ensure that all members are still accessible and that you have not accidentally cut off someone. If the member does not exist within the `Group`, the method wll return `false`, otherwise the method will return `true`.

* `Member[] AllMembers()` - Simple getting method to return all members that are part of the group and sized specifically to the number of members that are present.


* `Member? GetMember(int memberNo)` - Gets a member based on the `memberNo`. If the member exist, it should return the object, otherwise it will return null. 


* `int GroupSize()` - Will return the size of the group (or how many members are part of it).

You will need to look at the `Member` type and see what fields would be used and how a member can be compared to another. Read over the documentation of each method (it will be above the method definition).

## How to test

You can test your code by using `dotnet test`.
