using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode, lang, choice;
            do
            {
                Console.WriteLine("Enter Country Code");
                cCode = Console.ReadLine().ToLower();
                switch (cCode)
                {
                    case "uk":
                    case "us":
                        {
                            lang = "English";
                            break;
                        }
                    case "af":
                        {
                            lang = "Dari,Pasto";
                            break;
                        }
                    case "in":
                        {
                            lang = "Kannada,Hindi,English,Tamil,Telgu,Punjabi";
                            break;
                        }

                    case "uae":
                    case "om":
                    case "ksa":
                    case "egypt":
                        {
                            lang = "Arabic";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Sorry!! Your country {cCode} is not in OurDB");
                            lang = "Not Found";
                            break;
                        }
                }
                Console.WriteLine("Country Code:\t " + cCode + "\n  Language(s): \t " + lang);
                Console.WriteLine("Do you wanna Continue if yes press y\n To exit press any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
            }
        }
    }

