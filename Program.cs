namespace AddressBookProgram
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Address Book Program");

            CreateContact createContact = new CreateContact();

            createContact.AddPerson();

            createContact.ListPeople();

        }
    }
}