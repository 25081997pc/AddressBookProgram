using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

    }

    public class CreateContact
    {
        public List<Person> People = new List<Person>();
        
        public void AddPerson()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Area: ");
            person.Area = Console.ReadLine(); 
            Console.Write("Enter City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter State: ");
            person.State = Console.ReadLine();
            Console.Write("Enter Zip: ");
            person.Zip = Console.ReadLine();

            People.Add(person);
         
        }
        public void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: Area " + person.Area);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip: " + person.Zip);
            Console.WriteLine("--------------------------------");

        }

        public void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            for (int i = 0; i < People.Count; i++)
            {
                PrintPerson(People[i]);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

        }
        public void Edit()
        {
            if (People.Count != 0)
            {
                string edit = Console.ReadLine();
                foreach (var person in People)
                {
                    PrintPerson(person);
                    if (person.FirstName.ToLower() == edit.ToLower())
                    {
                        while (true)
                        {
                            Console.WriteLine("Changes");
                            Console.WriteLine("Enter the number:");
                            int number = Convert.ToInt32(Console.ReadLine());
                            switch (number)
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Phone Number: ");
                                    person.PhoneNumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New Area: ");
                                    person.Area = Console.ReadLine();
                                    Console.WriteLine("Enter New City: ");
                                    person.City = Console.ReadLine();
                                    Console.WriteLine("Enter New State: ");
                                    person.State = Console.ReadLine();
                                    Console.WriteLine("Enter New Zip: ");
                                    person.Zip = Console.ReadLine();
                                    break;
                                case 5:
                                    AddPerson();
                                    break;
                            }
                            return;
                        }
                    }
                    else
                    {
                        Console.Write("Enter valid name:");
                    }

                }
            }
            else
            {
                Console.WriteLine("Address book is Empty");
            }
            
        }
        public void Remove()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove");
            string FirstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == FirstName.ToLower());

            if (person == null)
            {
                Console.WriteLine("That person could not be found.Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(person);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person Removed.Press any key to continue");
                Console.ReadKey();
            }
        }

    }

}
