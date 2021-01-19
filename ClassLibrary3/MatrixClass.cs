            //♥сафка♥
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class MatrixClass
    {
        public int N { get; set; }
        public int M { get; set; }
        public int K { get; set; }
        public int[,] Matrix;
        public int[] Matrixx;
        public int[][] MatrixSt;

        public MatrixClass()
        {
            Matrix = new int[,] { { 0, 2, 0 }, { 0, 0, 0 }, { 0, 0, 1 } };
            N = 3; M = 3;
        }

        public MatrixClass(int n)
        {
            N = n;
            Matrix = new int[N, N];
        }

        public MatrixClass(string str)
        {
            MatrixSt = new int[4][];
            MatrixSt[0] = new int[2] { 1, 2 }; // a b
            MatrixSt[1] = new int[3] { 3, 2, 1 }; //c d e
            MatrixSt[2] = new int[4] { 1, 2, 3, 4 }; // f g h i
            //MatrixSt[3] = new int[5] { 4, 2, 3, 1, 5 }; 
            //g k l m n
            
        }

        public MatrixClass(int n, int m)
        {
            N = n;
            M = m;
            Matrix = new int[N, M];
        }

        public MatrixClass(int n, int m, int k)
        {
            N = n;
            K = k;
            Matrixx = new int[N];
        }

        #region 1
        public void Task1()
        {
            Console.WriteLine("Матрица");
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    Matrix[i, j] = i * 10;
                }
            }
            PrintDvMas();
        }
#endregion 1

        #region 2
        public int Task2()
        {
            Random r = new Random();
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    Thread.Sleep(300);
                    Matrix[i, j] = new Random().Next(-50, 50);
                }
            }
            int[,] Kol = new int[2, M];
            for (int i = 0; i < 2; ++i)
                for (int j = 0; j < M; ++j)
                    Kol[i, j] = 0;
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    if (Matrix[i, j] > 0)
                        Kol[0, j]++;
                    else
                        if (Matrix[i, j] < 0)
                        Kol[1, j]++;
                }
            }
            Console.WriteLine("Матрица");
            PrintDvMas();
            return Task2Answer(Kol);
        }

        private int Task2Answer(int[,] Kol)
        {
            int Num = 0;
            for (int i = 0; i < N; ++i)
            {
                if(Kol[0, i]==Kol[1, i])
                {
                    Num = i;
                }
            }
            return Num;
        }
        #endregion 2

        #region 3
        public void Task3()
        {
            Random r = new Random();
            for (int i=0; i<N; ++i)
            {
                Matrixx[i] = r.Next(0, 50);
            }
            Console.WriteLine("Исходная матрица");
            PrintOdMas();
            for (int i = 0; i < N; ++i)
            {
                Matrixx[i] += Matrixx[i] - 2; ;
            }
            Console.WriteLine("Измененная матрица");
            PrintOdMas();
        }
        #endregion 3

        #region 4

        public void Task4()
        {
            Random r = new Random();
            for (int i=0; i<N; ++i)
            {
                for (int j=0; j<M; ++j)
                {
                    Thread.Sleep(400);
                    Matrix[i, j] = new Random().Next(0, 2);
                }
            }
            Console.WriteLine("Исходная матрица");
            PrintDvMas();
            int[,] MatrixResult = Matrix;
            int sch = 0, mindist = 1000, indI = 0, indJ=0;
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    if (MatrixResult[i, j] == 0)
                    {
                        sch = 0; mindist = 1000;
                        for (int p = 0; p < N; ++p)
                        {
                            for (int q = 0; q < M; ++q)
                            {
                                if (Matrix[p, q]!=0)
                                {
                                    if (CountDistance(i, j, p, q)<mindist)
                                    {
                                        mindist = CountDistance(i, j, p, q);
                                        indI = p; indJ = q;
                                        sch++;
                                    }
                                }
                            }
                        }
                        if (mindist!=1000)
                        {
                            if (sch < 2)
                                MatrixResult[i, j] = Matrix[indI, indJ];
                        }
                    }
                }
            }
            Console.WriteLine("Результат");
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    Console.Write(MatrixResult[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private int CountDistance(int i, int j, int p, int q)
        {
            return Math.Abs(i-p)+Math.Abs(j-q);
        }

        #endregion 4

        #region 5

        public void Task5()
        {
            var g = new Graph();
            //добавление вершин
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddVertex("F");
            g.AddVertex("G");
            g.AddVertex("H");
            g.AddVertex("I");
            //добавление ребер
            g.AddEdge("A", "B", 3);
            g.AddEdge("A", "C", 4);
            g.AddEdge("B", "D", 4);
            g.AddEdge("C", "D", 5);
            g.AddEdge("D", "E", 3);
            g.AddEdge("C", "F", 4);
            g.AddEdge("D", "G", 4);
            g.AddEdge("E", "H", 4);
            g.AddEdge("F", "G", 3);
            g.AddEdge("G", "H", 5);
            g.AddEdge("H", "I", 7);

            var dijkstra = new Dijkstra(g);
            var path = dijkstra.FindShortestPath("A", "I");
            Console.WriteLine(path);
        }

        /*public void Task5()
        {
            Console.WriteLine("Матрица");
            for (int i = 0; i < MatrixSt.Length; ++i)
            {
                for (int j = 0; j < MatrixSt[i].Length; ++j)
                {
                    Console.Write(MatrixSt[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Путь:\n");
            int vershina = MatrixSt[0][MatrixSt[0].Length-1];
            Console.Write(vershina + " -> ");
            for (int i=1; i<MatrixSt.Length; ++i)
            {
                vershina = MatrixSt[i][0];
                for (int j=0; j<MatrixSt[i].Length; ++j)
                {
                    if(MatrixSt[i][j]<vershina)
                    {
                        vershina = MatrixSt[i][j];
                    }
                }
                Console.Write(vershina+" -> ");
            }
            Console.Write("приехали\n");
        }*/

        #endregion 5

        public void PrintDvMas()
        {
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void PrintOdMas()
        {
            for (int i = 0; i < N; ++i)
            {
                Console.Write(Matrixx[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
