using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise;
            while(true)
            {
                Console.WriteLine("1.   Даны целые положительные числа M и N. Сформировать целочисленную матрицу");
                Console.WriteLine("размера M × N, у которой все элементы I - й строки имеют значение 10·I(I = 1, …, M).\n");
                Console.WriteLine("2.   Дана целочисленная матрица размера M × N. Найти номер последнего из ее столбцов,");
                Console.WriteLine("содержащих равное количество положительных и отрицательных элементов (нулевые элементы ");
                Console.WriteLine("матрицы не учитываются). Если таких столбцов нет, то вывести 0.\n");
                Console.WriteLine("3.	Дан массив A размера N и целое число K (0 < K <N). Преобразовать массив, увеличив");
                Console.WriteLine("каждый его элемент на исходное значение элемента AK-1*2.\n");
                Console.WriteLine("4.	Дана матрица a размером n x n, заполненная неотрицательными целыми числами. ");
                Console.WriteLine("Расстояние между двумя элементами aij и apq определено как |i−p|+|j−q|. Требуется заменить каждый ");
                Console.WriteLine("нулевой элемент матрицы ближайшим ненулевым. Если есть две или больше ближайших ненулевых ");
                Console.WriteLine("ячейки, нуль должен быть оставлен.\n");
                Console.WriteLine("5.	Дан ступенчатый массив (двумерный массив). Каждая ячейка имеет вес указанный в ");
                Console.WriteLine("матрице, необходимо найти кратчайший маршрут из правого верхнего в левый нижний.\n");
                Console.WriteLine("6.   Выход");
                choise = Convert.ToInt32(Console.ReadLine());
                switch(choise)
                {
                    case 1:
                        int n, m;
                        Console.WriteLine("Введите размерность (n-стрки, m-столбцы)");
                        n = Convert.ToInt32(Console.ReadLine());
                        m = Convert.ToInt32(Console.ReadLine());
                        MatrixClass MyMatrix1 = new MatrixClass(n, m);
                        MyMatrix1.Task1();
                        break;
                    case 2:
                        Console.WriteLine("Введите размерность (n-стрки, m-столбцы)");
                        n = Convert.ToInt32(Console.ReadLine());
                        m = Convert.ToInt32(Console.ReadLine());
                        MatrixClass MyMatrix2 = new MatrixClass(n, m);
                        int ans = MyMatrix2.Task2();
                        if (ans>0)
                            Console.WriteLine($"Номер столбца: {ans+1}");
                        else
                            Console.WriteLine("Такого столбца нет");
                        break;
                    case 3:
                        int k;
                        Console.WriteLine("Введите размерность (n-столбцы, 0<k<n)");
                        n = Convert.ToInt32(Console.ReadLine());
                        k = Convert.ToInt32(Console.ReadLine());
                        MatrixClass MyMatrix3 = new MatrixClass(n, 0, k);
                        MyMatrix3.Task3();
                        break;
                    case 4:
                        Console.WriteLine("Введите размерность (n-стрки, m-столбцы)");
                        n = Convert.ToInt32(Console.ReadLine());
                        m = Convert.ToInt32(Console.ReadLine());
                        MatrixClass MyMatrix4 = new MatrixClass(n, m);
                        MyMatrix4.Task4();
                        break;
                    case 5:
                        /*Console.WriteLine("Введите размерность (n-стрки, m-столбцы)");
                        n = Convert.ToInt32(Console.ReadLine());
                        m = Convert.ToInt32(Console.ReadLine());*/
                        MatrixClass MyMatrix5 = new MatrixClass("");
                        MyMatrix5.Task5();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
