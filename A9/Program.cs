using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A9
{
    public class validation : Exception
    {
        public validation(string message) : base(message) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name, email, pwd;
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter email");
                email = Console.ReadLine();
                Console.WriteLine("Enter password");
                pwd = Console.ReadLine();
                if (name.Length <6)
                {
                    throw new validation("Name should have minimum 6 characters");
                }
                else if (pwd.Length < 8)
                {
                    throw new validation("Passeord length should be more than 8 ");
                }
                else
                {
                    Console.WriteLine("User registration succes");
                    Console.WriteLine($"Name : {name}\n Email : {email}\nPassword : {pwd}");
                }
            }
            catch(validation v)
            {
                Console.WriteLine("Validation exception !!!!!!"+v.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!!!!!"+e.Message);
            }
            finally
            {
                Console.WriteLine("End");
                Console.ReadKey();
            }
        }
    }
}
