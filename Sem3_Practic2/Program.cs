namespace Sem3_Practic2
{
    internal class Program 
    { 
        static void Main(string[] args)
        {
            //Задание 1
            //Task1();
            //Task2();
            //Task3and4();
            

            //Задание 2
            //Task5();
        }

        static void Task5()
        {
            Console.WriteLine("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер операции(1 - '+', 2 - '-', 3 - '*', 4 - '/', 5 - '^', 6 - 'y√x'): ");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DoOperation(x, y, op).ToString());
        }

        static double DoOperation(int x, int y, int op) => op switch
        {
            1 => x + y,
            2 => x - y,
            3 => x * y,
            4 => Convert.ToDouble(x) / y,
            5 => Math.Pow(x, y),
            6 => Math.Pow(x, 1 / Convert.ToDouble(y)),
            _ => 0
        };

        static void Task1()
        {
            Console.WriteLine("Введите размер массива: ");
            int n = 1;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr;
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Task2() 
        {
            Console.WriteLine("Введите размер квадратной матрицы: ");
            int n = 1;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr;
            arr = new int[n, n];

            int x = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i + 1) > n / 2)
                {
                    x += 1;
                }
                for (int j = 0; j < n; j++)
                {
                    if ((i + 1) > n / 2 && j < x)
                    {
                        arr[i, j] = 0;
                    }
                    else
                        arr[i, j] = 1;
                    Console.Write(arr[i, j]);

                }
                Console.WriteLine();
            }
        }

        static void Task3and4()
        {
            Console.WriteLine("Введите ширину матрицы: ");
            int n = 1;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину матрицы: ");
            int m = 1;
            m = Convert.ToInt32(Console.ReadLine());
            int[,] arr;
            arr = new int[n, m];
            int x = 1;
            int z = 0;
            while (x <= n * m)
            {
                for (int i = 0 + z; i < m - z; i++)
                {
                    arr[z, i] = x;
                    x++;
                }
                if (x > arr.Length)
                    break;
                for (int i = 1 + z; i < n - z; i++)
                {
                    arr[i, m - 1 - z] = x;
                    x++;
                }
                if (x > arr.Length)
                    break;
                for (int i = m - 2 - z; i >= 0 + z; i--)
                {
                    arr[n - 1 - z, i] = x;
                    x++;
                }
                if (x > arr.Length)
                    break;
                for (int i = n - 2 - z; i >= 1 + z; i--)
                {
                    arr[i, 0 + z] = x;
                    x++;
                }
                z++;
            }
            int maxRank = IntegerRank(n*m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                    for (int u = maxRank; u > IntegerRank(arr[i,j]); u--)
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
        static int IntegerRank(int x)
        {
            int res = 0;
            while(x > 0)
            {
                res++;
                x /= 10;
            }
            return res;
        }

    }
}
