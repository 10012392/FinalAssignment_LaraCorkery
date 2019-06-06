//Lara Corkery 23/05/2019
//Final Assignment Program Code 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            bool validusername = true;
            bool validpassword = true;

           

            //While Loop For The Username
            while(validusername)
            {
                //Introduction 
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("--- Welcome To The Rotorua Thermal Holiday Park ---");
                Console.WriteLine("---------------------------------------------------");

                //Asking user to input a username 
                Console.WriteLine(" Please Enter Desired Username: ");
                string username = Console.ReadLine();

                //if this process is equal to 6 
                if (validateusername(username) ==1)
                {
                    Console.WriteLine("Username is too short. Press Enter To Enter New Username ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Username Accepted And Set");
                    Console.ReadLine();
                    validusername = false;
                } 

            }

            //While Loop For Password 
            while (validpassword)
            {
                //Asks user to input password
                Console.WriteLine("Please Enter Password: ");
                string password1 = Console.ReadLine();

                //Asks user to input that same password
                Console.WriteLine("Please ReEnter Password: ");
                string password2 = Console.ReadLine();

                //
                if (validatepassword(password1, password2 ) ==3 ) 
                {
                    Console.WriteLine("Password Is Invalid, Press Enter To Enter New Password");
                }
                else
                {
                    Console.WriteLine("Password Accepted");
                    Console.ReadLine();
                    validpassword = false;
                }


                

            } 

        } 
        //Method for Username - checking if username is less than 8 charcters
        static int validateusername(string username)
        {
            if (username.Length < 8)
            {
                return 1;

            }
            else
                return 2;
        }
        //Method for Password - Checking if password 
        static int validatepassword(string password1, string password2)
        {
            if (password1.Length < 8)
            {
                return 3;
            }
            else if (password1 == password2)
            {
                return 4;
            }
            else
                return 3;
                

           
        }


        /* Testing Process 
         * Username requires 8 characters, anything less than 8 an error asks for the user to put in new username 
         * When valid username is used, application then asks for the user to enter password twice 
         * When passwords match, it checks if its more than 8 chacters the loop finishes
         * If passwords don't match, it asks for user to enter passwords again until the passwords match and more than 8 charcters. 
         * 
         */
         



    }
}
