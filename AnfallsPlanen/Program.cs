using System;

namespace AnfallsPlanen
{
    class Program
    {
        static void Main(string[] args)
        {
            int skott = 0;
            string svar;
            bool träff = false;
            int rättSvar = 3;
            bool näraMiss = false;

            Console.WriteLine("Välkommen Till Edvins Sänka Skepp!");
            Console.WriteLine("Ditt Mål Är Att:");
            Console.WriteLine("Försöka Träffa Skeppet Med Dina Kanoner Genom Att Skriva En Siffra Mellan 1-10!");
            Console.WriteLine("Känner Du Dig Redo!?");

            svar = Console.ReadLine();

            if (svar == "ja" || svar == "absolut")
            {
                Console.WriteLine("Bra! Lycka Till!");
                Console.WriteLine("Tryck Enter För Att Börja...");
            }
            else
            {
                Console.WriteLine("Ajdå! Lycka Till Ändå!");
                Console.WriteLine("Tryck Enter För Att Börja...");
            }

            Console.ReadLine();

            while (!(skott == rättSvar))
            {
                näraMiss = false;

                Console.WriteLine("Skriv En Siffra Mellan 1-10:");

                skott = int.Parse(Console.ReadLine());

                if (skott == rättSvar - 1 || skott == rättSvar - 2 || skott == rättSvar + 1 || skott == rättSvar + 2)
                {
                    näraMiss = true;
                }
                if (skott != rättSvar)
                {
                    if (näraMiss == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("Nära Miss!");
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Miss!");

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Träff!!");

                    träff = true;

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadLine();
                }

            }

        }
    }
}
