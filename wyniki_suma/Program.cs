using System;

namespace wyniki_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punktacja");
            int[] Marcin = { };
            int[] Iwona = { };
            int[] Lucja = { };
            int[] Franek = { };
            int dalej = 0;
            int c = 0;
            
            
            do
            {
                int numeric_Marcin = 0;
                Console.Write("Punkty Marcin:");
                Wynik Wynik_Marcin = new Wynik();
                Wynik_Marcin.Punkty = Console.ReadLine();
                
                //moduł sprawdzania czy wprowadzona wartość jest liczbą 
                if (!int.TryParse(Wynik_Marcin.Punkty,out numeric_Marcin)){
                    Console.WriteLine("Wprowadź liczbę, nie litery!");
                    continue;
                }
                numeric_Marcin = int.Parse(Wynik_Marcin.Punkty);
                Array.Resize(ref Marcin, Marcin.Length + 1);
                Marcin[Marcin.GetUpperBound(0)] = numeric_Marcin;
                //Sprawdzenie programu
                Console.WriteLine("Marcin:");
                foreach(int s in Marcin)
                {
                    Console.Write(s+",");   
                }
                Console.WriteLine(" ");
                int sumaMarcin = 0;
                foreach (int item in Marcin)
                {
                    sumaMarcin += item;
                }
                Console.WriteLine("Marcin w sumie:" + sumaMarcin);

                //Wyniki Iwona
                bool check = true;
                while (check==true)
                {
                    int numeric_Iwona = 0;
                    Console.Write("Punkty Iwona:");
                    Wynik Wynik_Iwona = new Wynik();
                    Wynik_Iwona.Punkty = Console.ReadLine();
                    if (!int.TryParse(Wynik_Iwona.Punkty, out numeric_Iwona))
                    {
                        Console.WriteLine("Wprowadź liczbę, nie litery!");
                        continue;
                    }
                    numeric_Iwona = int.Parse(Wynik_Iwona.Punkty);
                    check = false;
                    Array.Resize(ref Iwona, Iwona.Length + 1);
                    Iwona[Iwona.GetUpperBound(0)] = numeric_Iwona;
                    //Sprawdzenie programu
                    Console.WriteLine("Iwona:");
                    foreach (int t in Iwona)
                    {
                        Console.Write(t + ",");
                    }
                    Console.WriteLine(" ");
                    int sumaIwona = 0;
                    foreach (int item in Iwona)
                    {
                        sumaIwona += item;
                    }
                    Console.WriteLine("Iwona w sumie:" + sumaIwona);
                }

                //Wyniki Łucja
                check = true;
                while (check == true) { 
                int numeric_Lucja = 0;
                Console.Write("Punkty Lucja:");
                Wynik Wynik_Lucja = new Wynik();
                Wynik_Lucja.Punkty = Console.ReadLine();
                if (!int.TryParse(Wynik_Lucja.Punkty, out numeric_Lucja))
                {
                    Console.WriteLine("Wprowadź liczbę, nie litery!");
                    continue;
                }

                numeric_Lucja = int.Parse(Wynik_Lucja.Punkty);
                    check = false;
                Array.Resize(ref Lucja, Lucja.Length + 1);
                Lucja[Lucja.GetUpperBound(0)] = numeric_Lucja;
                //Sprawdzenie programu
                Console.WriteLine("Lucja:");
                foreach (int u in Lucja)
                {
                    Console.Write(u + ",");
                }
                Console.WriteLine(" ");
                int sumaLucja = 0;
                foreach (int item in Lucja)
                {
                    sumaLucja += item;
                }
                Console.WriteLine("Łucja w sumie:" + sumaLucja);
                }

                //Wyniki Franek
                check = true;
                while (check == true)
                { 
                int numeric_Franek = 0;
                Console.Write("Punkty Franek:");
                Wynik Wynik_Franek = new Wynik();
                Wynik_Franek.Punkty = Console.ReadLine();
                if (!int.TryParse(Wynik_Franek.Punkty, out numeric_Franek))
                {
                    Console.WriteLine("Wprowadź liczbę, nie litery!");
                    continue;
                }
                numeric_Franek = int.Parse(Wynik_Franek.Punkty);
                    check = false;
                Array.Resize(ref Franek, Franek.Length + 1);
                Franek[Franek.GetUpperBound(0)] = numeric_Franek;
                //Sprawdzenie programu
                Console.WriteLine("Franek:");
                foreach (int w in Franek)
                {
                    Console.Write(w + ",");
                }
                Console.WriteLine(" ");
                int sumaFranek = 0;
                foreach (int item in Franek)
                {
                    sumaFranek += item;
                }
                Console.WriteLine("Franek w sumie:" + sumaFranek
                    );
                }
                c +=1;
                Console.Write("Kolejna Runda? t/n:");
                string decyzja = Console.ReadLine();
                if (decyzja == "t")
                {
                    dalej = 0;
                }
                else
                {
                    dalej = 1;
                }
                
            }
            while (dalej < 1);


        }
        
        
    }
}
