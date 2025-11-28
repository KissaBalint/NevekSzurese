using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevekSzurese
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> nevek = new List<string>();
            nevek.Add("Kiss István");
            nevek.Add("Nagy elemér");
            nevek.Add("kissándorjózsef23");
            nevek.Add(" Tóth# Ilona");
            nevek.Add("Kiss Bálint");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0 Kilépés");
                Console.WriteLine("1 Néveleji szóközök levágva");
                Console.WriteLine("2 Csak nagybetűvel kezdődők");
                Console.WriteLine("3 Csak számjegy nélküliek");
                Console.WriteLine("4 Csak speciális jel nélküliek");
                Console.WriteLine("5 Legalább egy szóközt tartalmazók");
                Console.WriteLine("6 Csak rendes nevek");
                string valaszt = Console.ReadLine();
                if (valaszt == "0")
                {
                    return;
                }
                else if (valaszt == "1")
                {
                    Console.Clear();
                    foreach (string nev in nevek)
                    {
                        Console.WriteLine(nev.TrimStart());
                    }
                }
                else if (valaszt == "2")
                {
                    Console.Clear();
                    foreach (string nev in nevek)
                    {
                        string[] darabok = nev.TrimStart().Split(' ');
                        bool jo = true;
                        foreach (string nevdarab in darabok)
                        {
                            //elemer
                            if (!char.IsUpper(nevdarab.TrimStart()[0]))
                                jo = false;

                        }
                        if (jo)
                            Console.WriteLine(nev.TrimStart());
                    }
                }
                else if (valaszt == "3")
                {
                    Console.Clear();


                    foreach (var nev in nevek)
                    {
                        bool jo = true;
                        foreach (char betu in nev)
                        {

                            if (char.IsNumber(betu))
                                jo = false;

                        }
                        if (jo)
                            Console.WriteLine(nev.TrimStart());

                    }
                }
                else if (valaszt == "4")
                {
                    Console.Clear();
                    foreach (string nev in nevek)
                    {

                        bool jo = true;

                        foreach (char betu in nev)
                        {
                            if (!(char.IsLetterOrDigit(betu) || betu == ' '))
                                jo = false;
                        }
                        if (jo)
                        {
                            Console.WriteLine(nev.TrimStart());
                        }
                    }
                }
                else if (valaszt == "5")
                {
                    Console.Clear();
                    foreach (string nev in nevek)
                    {
                        if(nev.Contains(' '))
                        {
                            Console.WriteLine(nev.TrimStart());
                        }
                    }
                }
                else if (valaszt == "6")
                {
                    Console.Clear();
                    //csak betűk
                    foreach (string nev in nevek)
                    {

                        bool jo = true;

                        foreach (char betu in nev)
                        {
                            if (!char.IsLetter(betu) && betu != ' ')
                                jo = false;
                        }
                        

                        //nagybtű vizsgálat
                        
                        string[] darabok = nev.TrimStart().Split(' ');
                            
                        foreach (string nevdarab in darabok)
                        {
                            
                            if (!char.IsUpper(nevdarab.TrimStart()[0]))
                                jo = false;

                        }
                        if (jo)
                            Console.WriteLine(nev.TrimStart());
                        
                    }
                }
                else
                {
                    Console.WriteLine("Nincs ilyen parancs!");
                }
                Console.ReadKey();
            }
            
        }
    }
}
