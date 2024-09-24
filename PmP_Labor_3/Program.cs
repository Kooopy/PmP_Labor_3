using System;

namespace PmP_Labor_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feladat 1:

            //string[] szinek = { "Kőr", "Káró", "Treff", "Pikk" };
            //string[] magassagok = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jumbó", "Dáma", "Király", "Ász" };


            //string[] pakli = new string[szinek.Length * magassagok.Length];

            //int index = 0;
            //foreach (string szin in szinek)
            //{
            //    foreach (string magassag in magassagok)
            //    {
            //        pakli[index] = szin + " " + magassag;
            //        index++;
            //    }
            //}

            //foreach (string lap in pakli)
            //{
            //    Console.WriteLine(lap);
            //}

            //Feladat 2:

            //FisherYatesKeveres(pakli);

            //foreach (string lap in pakli)
            //{
            //    Console.WriteLine(lap);
            //}

            //Feladat 3:

            //Console.Write("Add meg, hány szót szeretnél megadni: ");
            //int szavakSzama = int.Parse(Console.ReadLine());

            //string[] szavak = new string[szavakSzama];

            //for (int i = 0; i < szavakSzama; i++)
            //{
            //    Console.Write("Add meg a(z) {0}. szót: ", i + 1);
            //    szavak[i] = Console.ReadLine();
            //}

            //Console.Write("Adj meg egy további szót: ");
            //string keresettSzo = Console.ReadLine();

            //int index2 = Array.IndexOf(szavak, keresettSzo);

            //if (index2 != -1)
            //{
            //    Console.WriteLine("A megadott szó benne van a gyűjteményben, és először a(z) {0}. indexen található.", index2);
            //}
            //else
            //{
            //    Console.WriteLine("A megadott szó nincs benne a gyűjteményben.");
            //}

            //Feladat 4:

            //List<string> szavak = new List<string>();

            //while (true)
            //{
            //    Console.Write("Adj meg egy szót (vagy írd be: STOP a befejezéshez): ");
            //    string szo = Console.ReadLine();

            //    if (szo.ToUpper() == "STOP")
            //    {
            //        break;
            //    }

            //    szavak.Add(szo);
            //}

            //Console.Write("Adj meg egy további szót: ");
            //string keresettSzo = Console.ReadLine();

            //int index = szavak.IndexOf(keresettSzo);

            //if (index != -1)
            //{
            //    Console.WriteLine("A megadott szó benne van a gyűjteményben, és először a(z) {0}. indexen található.", index);
            //}
            //else
            //{
            //    Console.WriteLine("A megadott szó nincs benne a gyűjteményben.");
            //}

            //Feladat 5:

            //List<string> nevek = new List<string>();
            //List<int> eletkorok = new List<int>();
            //List<bool> tapasztalatok = new List<bool>();

            //while (true)
            //{
            //    Console.Write("Add meg a személy nevét (vagy hagyd üresen a befejezéshez): ");
            //    string nev = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(nev))
            //    {
            //        break;
            //    }

            //    Console.Write("Add meg a személy életkorát: ");
            //    int eletkor = int.Parse(Console.ReadLine());

            //    Console.Write("Rendelkezik programozói tapasztalattal? (igen/nem): ");
            //    bool tapasztalat = Console.ReadLine().ToLower() == "igen";

            //    nevek.Add(nev);
            //    eletkorok.Add(eletkor);
            //    tapasztalatok.Add(tapasztalat);
            //}

            //int osszEletkor = 0;
            //foreach (int eletkor in eletkorok)
            //{
            //    osszEletkor += eletkor;
            //}
            //double atlagEletkor = (double)osszEletkor / eletkorok.Count;
            //Console.WriteLine("Az átlagéletkor a teljes adathalmazban: {0:F2} év", atlagEletkor);

            //int osszEletkorNincsTapasztalat = 0;
            //int nincsTapasztalatSzam = 0;
            //for (int i = 0; i < tapasztalatok.Count; i++)
            //{
            //    if (!tapasztalatok[i])
            //    {
            //        osszEletkorNincsTapasztalat += eletkorok[i];
            //        nincsTapasztalatSzam++;
            //    }
            //}

            //if (nincsTapasztalatSzam > 0)
            //{
            //    double atlagEletkorNincsTapasztalat = (double)osszEletkorNincsTapasztalat / nincsTapasztalatSzam;
            //    Console.WriteLine("Az átlagéletkor a programozói tapasztalat nélküli személyek között: {0:F2} év", atlagEletkorNincsTapasztalat);
            //}
            //else
            //{
            //    Console.WriteLine("Nincs programozói tapasztalat nélküli személy az adathalmazban.");
            //}

            //int maxEletkor = -1;
            //string legidosebbNev = "";
            //for (int i = 0; i < tapasztalatok.Count; i++)
            //{
            //    if (tapasztalatok[i] && eletkorok[i] > maxEletkor)
            //    {
            //        maxEletkor = eletkorok[i];
            //        legidosebbNev = nevek[i];
            //    }
            //}

            //if (maxEletkor != -1)
            //{
            //    Console.WriteLine("A legidősebb programozói tapasztalattal rendelkező személy: {0}, {1} éves.", legidosebbNev, maxEletkor);
            //}
            //else
            //{
            //    Console.WriteLine("Nincs programozói tapasztalattal rendelkező személy az adathalmazban.");
            //}

            //Feladat 6:

            //Random rand = new Random();

            //Console.Write("Add meg az N értékét (2 és 9 között): ");
            //int N = int.Parse(Console.ReadLine());

            //Console.Write("Add meg az M értékét (2 és 9 között): ");
            //int M = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[N, M];

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
            //        matrix[i, j] = rand.Next(0, 10);
            //    }
            //}

            //Console.WriteLine("Az eredeti mátrix:");
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] transzponalt = new int[M, N];

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
            //        transzponalt[j, i] = matrix[i, j];
            //    }
            //}

            //Console.WriteLine("A transzponált mátrix:");
            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        Console.Write(transzponalt[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Feladat 7:

            //Random rand = new Random();

            //int N = 5;
            //int M = 4;

            //int[,] F = new int[N, M];

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
            //        F[i, j] = rand.Next(0, 11); 
            //    }
            //}

            //Console.WriteLine("Fogási adatok (horgászok × halfajták):");
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("Horgász {0}: ", i + 1);
            //    for (int j = 0; j < M; j++)
            //    {
            //        Console.Write(F[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\nAz egyes halfajtákból fogott összes mennyiség:");
            //for (int j = 0; j < M; j++)
            //{
            //    int osszesHalfajta = 0;
            //    for (int i = 0; i < N; i++)
            //    {
            //        osszesHalfajta += F[i, j];
            //    }
            //    Console.WriteLine("Halfajta {0}: {1} darab", j + 1, osszesHalfajta);
            //}

            //int legtobbHal = -1;
            //int legtobbHalHorgasz = -1;
            //for (int i = 0; i < N; i++)
            //{
            //    int osszesHal = 0;
            //    for (int j = 0; j < M; j++)
            //    {
            //        osszesHal += F[i, j];
            //    }

            //    if (osszesHal > legtobbHal)
            //    {
            //        legtobbHal = osszesHal;
            //        legtobbHalHorgasz = i;
            //    }
            //}
            //Console.WriteLine("\nA legtöbb halat Horgász {0} fogta, összesen {1} darabot.", legtobbHalHorgasz + 1, legtobbHal);

            //bool voltNullaFogas = false;
            //for (int i = 0; i < N; i++)
            //{
            //    int osszesHal = 0;
            //    for (int j = 0; j < M; j++)
            //    {
            //        osszesHal += F[i, j];
            //    }

            //    if (osszesHal == 0)
            //    {
            //        Console.WriteLine("\nHorgász {0} egyetlen halat sem fogott.", i + 1);
            //        voltNullaFogas = true;
            //    }
            //}

            //if (!voltNullaFogas)
            //{
            //    Console.WriteLine("\nNem volt olyan horgász, aki egyetlen halat sem fogott.");
            //}

            //Feladat 8:

            //Console.Write("Adj meg egy pozitív egész számot (N): ");
            //int N = int.Parse(Console.ReadLine());

            //List<int> szamok = new List<int>();
            //szamok.Add(N);

            //while (szamok[szamok.Count - 1] != 1)
            //{
            //    int K = szamok[szamok.Count - 1];

            //    if (K % 2 == 0)
            //    {
            //        szamok.Add(K / 2);
            //    }
            //    else
            //    {
            //        szamok.Add(3 * K + 1);
            //    }
            //}

            //Console.WriteLine("A generált lista elemei:");
            //foreach (int szam in szamok)
            //{
            //    Console.Write(szam + " ");
            //}
            //Console.WriteLine();

            //Feladat 9:

            //int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //for (int i = 0; i < x.Length / 2; i++)
            //{
            //    int tmp = x[i];
            //    x[i] = x[x.Length - i - 1];
            //    x[x.Length - i - 1] = tmp;
            //}

            //Console.WriteLine("Fordított sorrend:");
            //foreach (int elem in x)
            //{
            //    Console.Write(elem + " ");
            //}

            //Feladat 10:

            //    Random rand = new Random();

            //    Console.Write("Add meg a tömb méretét: ");
            //    int size = int.Parse(Console.ReadLine());

            //    int[] array = new int[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        array[i] = rand.Next(1, 101); 
            //    }

            //    Console.WriteLine("Eredeti tömb:");
            //    PrintArray(array);

            //    int[] everySecondElement = new int[(size + 1) / 2]; 
            //    for (int i = 0, j = 0; i < size; i += 2, j++)
            //    {
            //        everySecondElement[j] = array[i];
            //    }

            //    Console.WriteLine("Minden második elem:");
            //    PrintArray(everySecondElement);

            //    Array.Reverse(array);

            //    Console.WriteLine("Megfordított tömb:");
            //    PrintArray(array);

            //    int matrixSize = (int)Math.Ceiling(Math.Sqrt(size));
            //    int[,] matrix = new int[matrixSize, matrixSize];

            //    for (int i = 0; i < size; i++)
            //    {
            //        matrix[i / matrixSize, i % matrixSize] = array[i];
            //    }

            //    Console.WriteLine("Négyzetes mátrix:");
            //    PrintMatrix(matrix);
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Feladat 11:

        //    int[,] matrix = {
        //    { 1, 2, 3 },
        //    { 4, 5, 6 },
        //    { 7, 8, 9 }
        //};

        //    Console.WriteLine("Eredeti mátrix:");
        //    PrintMatrix(matrix);

        //    Console.Write("Add meg a forgatások számát (K): ");
        //    int K = int.Parse(Console.ReadLine());

        //    int[,] rotatedMatrix = RotateMatrix(matrix, K);

        //    Console.WriteLine($"A mátrix {K * 90}°-kal való elforgatása:");
        //    PrintMatrix(rotatedMatrix);
        //}

        //static int[,] RotateMatrix(int[,] matrix, int K)
        //{
        //    int N = matrix.GetLength(0); 
        //    int M = matrix.GetLength(1);

        //    K = K % 4; 

        //    int[,] rotatedMatrix = new int[M, N];

        //    for (int i = 0; i < N; i++)
        //    {
        //        for (int j = 0; j < M; j++)
        //        {
        //            if (K == 1) 
        //            {
        //                rotatedMatrix[j, N - 1 - i] = matrix[i, j];
        //            }
        //            else if (K == 2) 
        //            {
        //                rotatedMatrix[N - 1 - i, M - 1 - j] = matrix[i, j];
        //            }
        //            else if (K == 3) 
        //            {
        //                rotatedMatrix[M - 1 - j, i] = matrix[i, j];
        //            }
        //        }
        //    }

        //    return rotatedMatrix;
        //}

            //static void PrintMatrix(int[,] matrix)
            //{
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++)
            //        {
            //            Console.Write(matrix[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }



            //static void PrintMatrix(int[,] matrix)
            //{
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++)
            //        {
            //            Console.Write(matrix[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}



            //static void FisherYatesKeveres(string[] pakli)
            //{
            //    Random rand = new Random();

            //    for (int i = 0; i < pakli.Length - 1; i++)
            //    {
            //        int j = rand.Next(i, pakli.Length);

            //        string temp = pakli[i];
            //        pakli[i] = pakli[j];
            //        pakli[j] = temp;
            //    }
            //}
        }
    }
}