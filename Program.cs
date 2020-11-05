using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercici1();
            //Exercici2();
            Exercici3();
        }

        static void Exercici3()
        {
            //FASE 1
            List<string> cities = new List<string>() { "Barcelona", "Madrid", "Valencia", "Malaga", "Cadis", "Santander" };
            string city1, city2, city3, city4, city5, city6;

            /*for(int i=1; i<7; i++)
            {
                Console.WriteLine("Introdueix el nom de la ciutat {0}:",i);
                string cit = Console.ReadLine();
                cities.Add(cit);
            }*/
            city1 = cities[0];
            city2 = cities[1];
            city3 = cities[2];
            city4 = cities[3];
            city5 = cities[4];
            city6 = cities[5];

            Console.WriteLine("Exercici 1. Noms de les ciutats:");
            Console.WriteLine($"{city1},{city2},{city3},{city4},{city5},{city6}");

            //FASE 2

            string[] arrayCities = new string[6];

            arrayCities[0] = city1; //Ho faria amb un bucle i la llista de ciutats, pero suposo que s'ha de fer amb els strings
            arrayCities[1] = city2;
            arrayCities[2] = city3;
            arrayCities[3] = city4;
            arrayCities[4] = city5;
            arrayCities[5] = city6;

            for (int i = 0; i < arrayCities.Length; i++)
            {
                for (int j = 0; j < arrayCities.Length; j++)
                {
                    if (string.Compare(arrayCities[i], arrayCities[j]) < 0)
                    {
                        string var = arrayCities[i];
                        arrayCities[i] = arrayCities[j];
                        arrayCities[j] = var;
                    }

                    //Ho he provat comprovant cada caracter dels dos strings que comparem, però es molt mes eficient
                    //amb el metode Compare d'string

                    /*for(int k = 0; k < comp; k++)
                    {
                        if (str1[k].CompareTo(str2[k]) < 0)
                        {
                            string var = arrayCities[i];
                            arrayCities[i] = arrayCities[j];
                            arrayCities[j] = var;
                        }
                    }*/
                }
            }

            Console.WriteLine("\nExercici2. Ciutats ordenades alfabèticament:");
            foreach (string str in arrayCities)
            {
                Console.Write($"{str}, ");
            }
            Console.WriteLine("");

            //FASE 3

            string[] arrayModifCities = new string[6];

            for (int i = 0; i < arrayCities.Length; i++)
            {
                string str = arrayCities[i].Replace('a', '4'); //Guardo en un string les ciutats amb la lletra a canviada
                arrayModifCities[i] = str; //Introdueixo aquest string modificat a l'array de ciutats modificades
            }

            for (int i = 0; i < arrayModifCities.Length; i++) //Utilitzo el mateix bucle per ordenar
            {
                for (int j = 0; j < arrayModifCities.Length; j++)
                {
                    if (string.Compare(arrayModifCities[i], arrayModifCities[j]) < 0)
                    {
                        string var = arrayModifCities[i];
                        arrayModifCities[i] = arrayModifCities[j];
                        arrayModifCities[j] = var;
                    }
                }
            }

            Console.WriteLine("\nExercici3. Ciutats modificades ordenades alfabèticament:");
            foreach (string str in arrayModifCities)
            {
                Console.Write($"{str}, ");
            }
            Console.WriteLine("");

            //FASE 4

            /*No és possible inicialitzar els arrays amb aquests valors, ja que em diu que ha de ser un valor constant.*/
            int[] lengths = new int[6] { city1.Length, city2.Length, city3.Length, city4.Length, city5.Length, city6.Length };
            
            char[] city1Array = new char[] { 'B', 'a', 'r', 'c', 'e', 'l', 'o', 'n', 'a' };
            char[] city2Array = new char[] { 'M','a','d','r','i','d' };
            char[] city3Array = new char[] { 'V','a','l','e','n','c','i','a' };
            char[] city4Array = new char[] { 'M','a','l','a','g','a' };
            char[] city5Array = new char[] { 'C','a','d','i','s' };
            char[] city6Array = new char[] { 'S','a','n','t','a','n','d','e','r' };

            //Per no haver de repetir bucles per cada array, creo mètode reverseOrder explicat més abaix i modifico cada array
            city1Array = ReverseOrder(city1Array);
            city2Array = ReverseOrder(city2Array);
            city3Array = ReverseOrder(city3Array);
            city4Array = ReverseOrder(city4Array);
            city5Array = ReverseOrder(city5Array);
            city6Array = ReverseOrder(city6Array);

            Console.WriteLine("\nExercici 4. Arrays desordenats:");
            //Crido al mètode per imprimir cada Array
            PrintEx3(city1Array);
            PrintEx3(city2Array);
            PrintEx3(city3Array);
            PrintEx3(city4Array);
            PrintEx3(city5Array);
            PrintEx3(city6Array);

        }

        /*Mètode per a inveritr l'ordre dels caràcters d'un array*/
        static char[] ReverseOrder(char[] cityArray)
        {
            char[] changedArray = new char[cityArray.Length]; //Creo un array de la mateixa longitud que guardarà els
                                                              // caràcters invertits d'ordre.
            int pos = 0;
            for (int i = cityArray.Length - 1; i >= 0; i--) //Començo a recòrrer l'array pel final per obtenir els últims caràcters primer
            {
                //Guardo cada caràcter a l'array temporal (cal utilitzar index que vagi del principi(0) al final,
                //per aixo augmento la posició, ja que la nostra i va del final al principi.
                changedArray[pos] = cityArray[i]; 
                pos++;
            }

            return changedArray;
        }

        /*Mètode simple per imprimir els caràcters de l'array sense haver de repetir x cops el bucle.*/
        static void PrintEx3(char[] cityArray)
        {
            foreach (char c in cityArray)
            {
                Console.Write(c);
            }
            Console.Write("\n");
        }

        static void Exercici2()
        {
            //FASE 1
            char[] name = new char[] { 'I', 'g', 'n', 'a', 's', 'i', '8' };
            Console.WriteLine("Exercici 1. Les lletres del teu nom són: ");

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //FASE 2
            List<char> nameList = new List<char>() { 'I', 'g', 'n', 'a', 's', 'i', '8' };
            bool vowelCheck = false; //Comprovant de vocal 
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' }; //Enlloc de comprovar 5 coops si és vocal amb equal,
                                                                     // ho comparare amb aquest string

            Console.WriteLine("\nExercici 2:");

            foreach (char character in nameList)
            {
                char characterLower = char.ToLower(character); //Passem a minúscules per a fer les comparacions
                Console.WriteLine(character);

                for (int i = 0; i < vowels.Length; i++) //Bucle que passarà per l'string de vocals 
                {
                    if (characterLower.Equals(vowels[i])) //Comparo cada lletra amb cada vocal per identificar si coincideix.
                    {
                        Console.WriteLine("VOCAL " + vowels[i]);
                        vowelCheck = true; //Ha trobat una vocal, no s'ha d'imprimir consonant.
                        break; //Perquè surti del bucle, ja que ha trobat la vocal que era
                    }
                }

                if (char.IsNumber(character))
                {
                    /* En aquest cas, utilitzo el mateix comprovant de vocal per impedir que imprimeix consonant si és un
                     * número; L'ideal seria crear un identificador per cada tipus de cas o un genèric, però amb aquest 
                       ja ens servirà.*/
                    vowelCheck = true;
                    Console.WriteLine("Els noms de persones no contenen números!");
                }

                if (vowelCheck == false)
                {
                    Console.WriteLine("CONSONANT");
                }

                vowelCheck = false; //Tornem a posar a false per a comprovar la següent lletra
            }

            //FASE 3
            /* Intentaré explicar com he fet l'exercici a veure si s'entén, ja que pot ser una mica complex,
             He intentat utiltzar mètodes de Dictionary, però no m'en sortia, i he acabat fent la búsqueda de lletres
             repetides en una llista i apuntant el número de cops repetits per despres introduir-ho al diccionari*/

            Dictionary<char, int> nameDict = new Dictionary<char, int>();
            List<char> uniqueLetterList = new List<char>() { 'i', 'g', 'g', 'g', 'n', 'a', 'a', 's', 'i', 'i' }; //llista que serà de lletres úniques després de filtrar el nom inicial
            List<int> numbersList = new List<int>();//llista que guardarà el num de cops que apareix cada lletra

            for (int i = 0; i < uniqueLetterList.Count; i++)  //Afegeixo cada lletra del nom a la llista per comprovar dp si són unics o no
            {
                numbersList.Add(1); //Aquí omplo també les aparicions de cada caràcter (en el cas ideal sense repeticions
                                    //nomes apareixerien 1 cop).
            }

            string sentence = ""; //Simple conversió de la paraula analitzada a string
            foreach (char c in uniqueLetterList)
            {
                sentence += c.ToString();
            }

            /*Aquí ve el bucle de búsqueda i elimincació d'elements repetits. Dins la llista de lletres úniques, comparo 
             cada caràcter amb la resta per saber si són iguals. En cas afirmatiu, esborro el caràcter que està en la
             posició repetida, sumo 1 a la llista que porta el compte de les aparicions de cada caràcter en la posició
             associada, i elimino l'1 associat al caràcter repetit. 
             S'ha de disminuir en 1 l'index d'iteració j ja que al esborrar un element tindrem problemes d'index en 
             recòrrer la llista*/
            for (int i = 0; i < uniqueLetterList.Count; i++)
            {
                for (int j = 0; j < uniqueLetterList.Count; j++)
                {
                    if ((j != i) && uniqueLetterList[i].Equals(uniqueLetterList[j]))
                    {
                        uniqueLetterList.RemoveAt(j);
                        numbersList[i] += 1;
                        numbersList.RemoveAt(j);
                        j--;
                    }

                }
            }

            //Afegeixo la llista de lletres úniques i la llista de num d'aparicions associades a cada lletra com a
            //conjunt clau valor del meu diccionari.
            for (int i = 0; i < uniqueLetterList.Count; i++)
            {
                nameDict.Add(uniqueLetterList[i], numbersList[i]);
            }

            Console.WriteLine("\nExercici 3 Diccionari.  La paraula:" + sentence);
            foreach (KeyValuePair<char, int> kvp in nameDict) //imprimim el diccionari
            {
                Console.WriteLine("Lletra: {0}   Cops que ha aparescut: {1}", kvp.Key, kvp.Value);
            }


            //FASE 4
            List<char> surnameList = new List<char>() { 'a', 'g', 'u', 's', 't', 'í' };
            List<char> fullNameList = new List<char>();

            fullNameList = nameList; //No cal fer un bucle per la llista del nom, ja que coincidirà
            fullNameList.Add(' ');
            foreach (char c in surnameList) //Afegeixo el cognom després de l'espai
            {
                fullNameList.Add(c);
            }

            Console.Write("\nExercici 4:\nFullName: {");
            foreach (char c in fullNameList)
            {
                Console.Write("'{0}',", c);
            }
            Console.Write("}\n");
        }

        static void Exercici1()
        {
            //FASE 1
            string name = "Ignasi", surname1 = "Agustí", surname2 = "Bosch";
            int day = 29, month = 10, year = 2020;

            Console.WriteLine("Variables string: " + surname1 + " " + surname2 + ", " + name);
            Console.WriteLine($"Variables int: {day}/{month}/{year}");

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
            for (int i = 0; i < res + 1; i++)
            {
                Console.WriteLine(showYear);
                showYear += traspasYear; //Afegeixo 4 anys a cada iteració, ja que seran els diferents anys de traspàs
            }
            bool trasp = false;
            //Si l'any és de traspàs, la divisió de la resta entre 4 ha de donar quocient 0.
            if ((inputYear - INITIALYEAR) % traspasYear == 0)
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
