using System.Collections;

namespace ProviciasAndalucia
{

    class Program
    {


        static void Main(string[] args)
        {

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };

            ArrayList provincias = new ArrayList() {"Huelva", "Sevilla", "Cádiz", "Granada", "Córdoba", "Jaén", "Almería", "Málaga" };

            ArrayList sol = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
            provincias.Sort();

            for(int i = 0; i < provincias.Count; i++)
            {
                Console.WriteLine(provincias[i]);
            }

            provincias.Insert(0, num[0]);

            /*for(int i = 2; i < provincias.Count; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                provincias.Insert(++i + ++i, num[j]);
                }
               
            }*/
            for (int i = 0; i < sol.Count; i++)
            { 
                if (i % 2  == 0 )
                {
                    sol.Insert(i, num[i]);
                    i++;
                }
                else
                {
                    sol.Insert(i, provincias[i]);
                    i++;
                }
                Console.WriteLine(sol[i]);

            }


        }


    }



}
