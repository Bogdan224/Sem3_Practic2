namespace Sem3_Practic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            /*
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
            */

            //Задача 2
            /*
            int n = 1;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr;
            arr = new int[n,n];
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
                        arr[i,j] = 1;
                    Console.Write(arr[i,j]);

                }
                Console.WriteLine();
            }
            */

            //Задача 3, 4
            /*
            int n = 1;
            n = Convert.ToInt32(Console.ReadLine());
            int m = 1;
            m = Convert.ToInt32(Console.ReadLine());
            int[,] arr;
            arr = new int[n, m];
            int x = 1;
            int z = 0;
            while (x<=n*m)
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
                    arr[i, 0+z] = x;
                    x++;
                }
                z++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j]);
                    if (arr[i, j] < 10)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            */


        }

        double DoOperation(int x, int y, int op) => op switch
        {
            1 => x + y,
            2 => x - y,
            3 => x * y,
            4 => Convert.ToDouble(x) / y,
            5 => Math.Pow(x, y),
            6 => Math.Pow(x, 1 / y),
            _ => 0
        };
    }
}
