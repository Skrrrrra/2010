using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SummOfPow2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2009\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2009\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();


            //запись в строку содержимого строки файла
            string secondLine;
            using (var reader = new StreamReader(inputpath))
            {
                secondLine = reader.ReadLine();  // записываем в переменную
            }


            string[] secondlineforint = secondLine.Split(' ');

            //массив для действий над числами
            int[] lastintarr;
            lastintarr = new int[2];

            //запись в интовый массив из массива строк
            int count = 0;
            foreach (var s in secondlineforint)
            {
                lastintarr[count] = Convert.ToInt32(s);
                count++;
            }



            int m = lastintarr[0];
            int n = lastintarr[1];
            int counter = 0;
            int nod;
            while (n > 0 && m > 0)
            {
                if (m == n)
                {
                    nod = m;
                }

                if (n > m)
                {
                    n -= m;
                }
                else
                {
                    m -= n;
                }
                counter++;
            }
            nod = n;
            string output = counter + " " + nod;
            File.WriteAllText(outputpath, output);


        }
    }
}
