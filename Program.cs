using System.ComponentModel.Design;

namespace demoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string userRole = "Admin"; //Detta styr vilket värde som kör koden

            //if (userRole == "Admin")
            //{
            //    Console.WriteLine("You are Admin!");
            //}
            //else if (userRole == "Mod")
            //{
            //    Console.WriteLine("Du är Moderator");
            //}
            //else
            //{
            //    Console.WriteLine("Du är kund");
            //}

            //string itemStatus = "rea";
            //int itemStock = 15;
            //bool isAvailable = false;

            //if((itemStatus== "rea" && isAvailable) || itemStock >= 20)
            //{
            //    Console.WriteLine("Du får 50% rabatt!");
            //}
            //else
            //{
            //    Console.WriteLine("Ej med på rean!");
            //}

            ////-Här kommer en Ternary sats som kan ersätta en if och else sats
            //string userRole = "user";

            //string loginAs = (userRole == "admin") ? "Du är admin!" : "Du är user!";
            //Console.WriteLine(loginAs);

            //if(userRole == "admin")
            //{
            //    Console.WriteLine("Du är admin!");
            //}
            //else
            //{
            //    Console.WriteLine("Du är user!");
            //}

            Console.WriteLine("Enter a day of the week. Tex Monday");
            string day = Console.ReadLine();

            switch(day)
            {
                case "Monday":
                    Console.WriteLine("Worst day of the week!");
                    break;

                case "Friday":
                    Console.WriteLine("Party!");
                    break;

                case "Saturday":
                case "Sunday":
                    Console.WriteLine("It's weekend!");
                    break;

                default:
                    Console.WriteLine("You have written something else than Monday, Friday, Saturday or Sunday");
                    break;


                    

            }
            
        }

    }
}