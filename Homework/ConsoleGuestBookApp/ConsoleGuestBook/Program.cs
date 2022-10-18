using ConsoleGuestBook;

Guest.WelcomeMessage();
Dictionary<string, int> partyList = new Dictionary<string, int>();
bool closeList = false;
int count = 0;

do
{
    // get information about family name and members count
    (string familyName, int countMembers) family = Guest.GetFamilyInformation();

    // adding family to the list
    Guest.AddGuestToParty(partyList, family.familyName, family.countMembers);

    // continue adding or cloase the list
    closeList = Guest.KeepAddingMembers();
} while (closeList == false);

// printing the party list with every family and the total ammount of guests
Guest.PrintingParyList(partyList);
