﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_mart
{
    class Program
    {
        static List<Kund> kundLista = new List<Kund>();

        static void Main(string[] args)
        {

            Console.WriteLine("Vällkommen till K-mart!");
            Console.WriteLine("");
            Console.WriteLine("Ange vilket av följande alternativ önskar du göra.");
            Console.WriteLine("");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Ta bort användare");
            Console.WriteLine("3. Visa alla befintiliga användare");
            Console.WriteLine("4. Visa saldo för en användare");
            Console.WriteLine("5. Gör en insättning för en användare");
            Console.WriteLine("6. Gör ett uttag för en användare");
            Console.WriteLine("7. Avsluta programmet");
            Console.WriteLine("");
            Console.WriteLine("Skriv ditt val: ");


            int val = 0;
            try
            {
                val = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("du valde inte ett nummer");
                Console.WriteLine(e.Message);
            }

            

            while (val != 7) //körs tills 7 inte skrivs in 
            {

                switch (val)
                {
                    case 1:
                        LaggTillKund();
                        break;
                    case 2:
                        TaBortKund();
                        break;
                    case 3:
                        foreach (Kund info in kundLista)//skriver upp alla inskrivna object 
                        {
                            Console.WriteLine(info.KundInfo());
                        }

                        break;
                    case 7:
                        Console.WriteLine("Lycka till välkommen åter");
                        break;

                    default:
                        Console.WriteLine("error 404");
                        break;
                }
                try
                {
                    Console.WriteLine("Skriv ditt val: ");
                    Console.WriteLine("");
                    val = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("try again");
                }
                

            }

        }

        public static void LaggTillKund()//lägger till användare och gör ett nytt object
        {
            Console.WriteLine("skriv kundens namn för att lägga till: ");
            string nyKund = Console.ReadLine();
            Kund Kund = new Kund();
            Kund.namn = nyKund;
            kundLista.Add(Kund);

        }

        public static void TaBortKund()
        {
            Console.WriteLine("namn på kunden du vill ta bort ");
            string namn = Console.ReadLine();
            Kund taBortKund = null;
            foreach (Kund info in kundLista)
            {
                if (info.namn == namn)
                {
                    taBortKund = info; //tarbort en spcific kund
                }
            }
            kundLista.Remove(taBortKund);
        }




    }
}