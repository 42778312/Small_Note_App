using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace SimpleCalendarApp
{
    class Program
    {
        static Dictionary<DateTime, string> calendar = new Dictionary<DateTime, string>();

        static void Main(string[] args)
            
        {
            while (true)
            {
                Console.WriteLine("note Application");
                Console.WriteLine("\nChoose one of the following Choices:");
                Console.WriteLine("\n1. Choose a Day :");
                Console.WriteLine("\n2. View saved Notes :");
                Console.WriteLine("\n3. Exit ");

                Console.WriteLine(" \nchoose an Option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ChooseDay();
                            break;
                        case 2:
                            ViewNotes();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("invalide choice");
                            break;

                    }

                }
                else { Console.WriteLine(" ↑ Choose one of the Options up there ↑ "); }
            }
            


            Console.ReadLine();

        }
        static void ChooseDay()
        {
            Console.WriteLine("! Enter a date in any Date Form ! ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime selectedDate))
            {
                Console.WriteLine("Enter the note for the Day: ");
                string note = Console.ReadLine();

                calendar[selectedDate] = note;
                Console.WriteLine(" your note saved :) choose 2 to see the Note ");

            }
            else
            {
                Console.WriteLine("invalide input :( try again");
            }
        }
        static void ViewNotes()
        {
            Console.WriteLine(" saved Notes: ");
            foreach (var entry in calendar)
            {
                
                Console.WriteLine($"Date: {entry.Key.ToShortDateString()} - Note: {entry.Value}");
                
            }

        }
       
    }
}

