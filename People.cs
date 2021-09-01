using System;
using System.Collections.Generic;
using System.Text;

namespace printing_names
{
    public class People
    {
        //private fields
        private string firstname = " ";
        private string lastname = " ";
        private int age;
        private string occupation;


        //public references    
        public People(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            Console.WriteLine("Your first Name is " + firstname + " and your last Name is " + lastname);

            //Method to find the age of the person 
            this.age = age;
            Console.WriteLine("Your age selected is " + age);

            //Method to find occupation for the person
            this.occupation = setting_occupation();
        }

        //Program to find the occupation of the selected person
        public string setting_occupation()
        {
            Console.WriteLine("Enter your occupation: \n1: Government Sector \n2: Private Sector \n3: Business \n4: Others");
            int occupation_code = Convert.ToInt32(Console.ReadLine());

            if (occupation_code == 1)
            {
                return "Government Sector";
            }
            else if (occupation_code == 2)
            {
                return "Private Sector";
            }
            else if (occupation_code == 3)
            {
                return "Business";
            }
            else 
            {
                Console.WriteLine("Please mention your occupation: ");
                string other_occupation = Console.ReadLine();
                return other_occupation;
                
            }


        }

        //Show details.
        public string find_details()
        {
            return "Your name is: " + firstname + " " + lastname + "\nYour Age is: " + age + "\nYour occupation is: " + this.occupation;

        }


    }

    
}
    