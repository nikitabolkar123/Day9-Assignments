using System;

namespace AdressBookPrograms
{
    internal class Program
    {
        internal class AddressBook
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome To  Address Book");
                CreateUsers us1 = new CreateUsers();
                us1.getDetails("Nikita", "Bolkar", "Aurangabad", "Maharashtra", 411008, 12345, "nikitabolkar123@gmail.com");
                us1.displayDetail();

                Console.WriteLine("");

                CreateUsers us2 = new CreateUsers();
                us1.getDetails("Rani", "Patil", "Pune", "Maharashtra", 410203, 1234556, "ranipatil@gmail.com");
                us1.displayDetail();

                Console.WriteLine("");

                CreateUsers us3 = new CreateUsers();
                us1.getDetails("Anuradha", "Manal", "Nashik", "Maharashtra", 410204, 1234557, "anuradha0987@gmail.com");
                us1.displayDetail();


            }

        }
        public class CreateUsers
        {
            private string fname;
            private string lname;
            private string city;
            private string state;
            private int zip;
            private int pno;
            private string email;


            public void getDetails(string fname, string lname, string city, string state, int zip, int pno, string email)
            {
                this.fname = fname;
                this.lname = lname;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.pno = pno;
                this.email = email;
            }

            public void displayDetail()
            {
                Console.WriteLine("First Name :" + fname);
                Console.WriteLine("Last Name :" + lname);
                Console.WriteLine("city :" + city);
                Console.WriteLine("state :" + state);
                Console.WriteLine("zip :" + zip);
                Console.WriteLine("Mobile No :" + pno);
                Console.WriteLine("Email :" + email);
            }
        }
    }
}