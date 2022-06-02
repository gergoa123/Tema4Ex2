using System;

// Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
//k.Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
// Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
//rezultatul.
// Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
//rezultatul. 

namespace Tema4Ex2
{
    class Program
    {
        static int Citire()
        {
            return int.Parse(Console.ReadLine());           
        }

        static int Suma(int[,,] matrix,int n,int m, int k)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        suma = suma + matrix[i, j, l]; 

                    }
                }
            }
            return suma;

        }

        static int Max(int[,,] matrix, int n, int m, int k)
        {
            int maxim = matrix[0,0,0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        if (matrix[i,j,l] > maxim)
                        {
                            maxim = matrix[i, j, l];
                        }

                    }
                }
            }
            return maxim;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimile matricei! ");
            Console.WriteLine("Lungime1 = ");
            int lungime1 = Citire();
            Console.WriteLine("Lungime2 = ");
            int lungime2 = Citire();
            Console.WriteLine("Lungime3 = ");
            int lungime3 = Citire();

            int[,,] matrix = new int[lungime1, lungime2, lungime3];
            for (int i = 0; i < lungime1; i++)
            {
                for (int j = 0; j < lungime2; j++)
                {
                    for (int k = 0; k < lungime3; k++)
                    {
                        Console.WriteLine("Introduceti numarul = ");
                        matrix[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Valoarea maxima a matricei este = ");
            Console.WriteLine(Max(matrix,lungime1,lungime2,lungime3));
            Console.WriteLine("Suma elementelor este = ");
            Console.WriteLine(Suma(matrix, lungime1, lungime2, lungime3));
        }
    }
}
