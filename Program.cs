using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //FASE 1
            string name = "Ignasi", surname1 = "Agustí", surname2="Bosch";
            int day=29, month=10, year=2020;

            Console.WriteLine("Variables string: " + surname1 + " " + surname2 + ", " + name);
            Console.WriteLine($"Variables int: {day}/{month}/{year}" );

            //FASE 2
            const int INITIALYEAR = 1948; 
            int traspasYear = 4; //Cada 4 anys hi ha 1 de traspàs
            Console.WriteLine("Introdueix el teu any de naixement: ");
            int inputYear = int.Parse(Console.ReadLine());
            int res = (inputYear - INITIALYEAR) / traspasYear; //Calculo la diferència entre anys, i divideixo entre 4 per saber
                                                                //quants anys de traspàs hi ha hagut en els anys entremig
            Console.WriteLine($"Hi ha hagut {res} anys de traspàs des del {INITIALYEAR} fins al {inputYear}");

            //FASE 3
            int showYear = INITIALYEAR; //1948
            Console.WriteLine("Anys de traspàs: ");
            for (int i = 0; i<res+1; i++)
            {
                Console.WriteLine(showYear);
                showYear += traspasYear; //Afegeixo 4 anys a cada iteració, ja que seran els diferents anys de traspàs
            }
            bool trasp = false;
            //Si l'any és de traspàs, la divisió de la resta entre 4 ha de donar quocient 0.
            if ( (inputYear - INITIALYEAR) % traspasYear == 0) 
            {
                trasp = true;
            }
            string trueSentence = "L'any de naixement és de traspàs (bool és certa)";
            string falseSentence = "L'any de naixement no és de traspàs (bool no és certa)";
            string completeName = name + " " + surname1 + " " + surname2;
            string completeDate = day + "/" + month + "/" + inputYear;

            Console.WriteLine("El meu nom és " + completeName);
            Console.WriteLine($"Vaig néixer el {completeDate}");
            if (trasp == true)
            {
                Console.WriteLine(trueSentence);
            }
            else
            {
                Console.WriteLine(falseSentence);
            }
        }
    }
}
