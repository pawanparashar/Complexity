using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity
{
    class AlgorithmsAnalysis
    {

        // Rate of Growth                          |
        // BEST                                    |
        // O(1)                                    |
        // O(log log n)                            |
        // O(log n)                                |
        // O(log n power 2)                        |
        // O(sqrt n)                               |
        // O(n)                                    |
        // O(log n!)                               |
        // O(n log n)                              |
        // O(n power 2)                            |
        // O(2 power n)                            |
        // O(4 power n)                            |
        // O(n!)                                   |
        // WORST                                   V

        //O(1)
        public void O_1(int n)
        {
            
            Console.WriteLine(n);
           
        }

        //O(log log n) Algorithms T(n) = T(sqrt(n)) + 1
        public double O_log_log_n(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return 1 + Math.Sqrt(n);
            }

        }

        //O(log n) Algorithms
        public void O_log_n(int n)
        {
            int count = 0;
            for (int k = 1; k <= n; k = k * 2)
            {
                count++;
            }
        }

        //O(log n power 2) Algorithms
        public void O_log_n_Power_2(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i = 2*i)
            {
                for (int j = 0; j < n; j =2*j)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        // O(sqrt n)  Algorithms
        public void O_sqrt_n(int n)
        {
            int count = 0;
            for (int i = 0; i*i < n; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        public void O_Square_root_n(int n)
        {
            int i = 1, s = 1;
            while (s <= n)
            {
                i++;
                s += i;
                Console.WriteLine(s);
            }


        }

        public void O_Square_root_n_e2(int n)
        {
            int i, count = 0;
            for (i = 1; i * i <= n; i++)
            {
                count++;
            }


        }


        // O(n) Algorithms
        public void O_n(int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(i);
            }
        }

        //O(Log n!) Algorithms -  O(nlog n)=O(log n!)
        //O(n log n) Algorithms
        public void O_n_logn(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j += i)
                {
                    Console.WriteLine(j);
                }
            }
        }

        //O(n power 2) Algorithms
        public void O_n_power_2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(i + j);
                }
            }
        }



        //O(2 power n) Algorithms
        public int O_2_Power_n(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return 2 * O_2_Power_n(n - 1);
            }
        }

        //O(4 power n) Algorithms
        public int O_4_Power_n(int n)
        {
            if(n==0)
            {
                return 1;
            }
            else
            {
                return 4 * O_4_Power_n(n - 1);
            }
        }

        //O(n!) Algorithms
        public void o_n_fact(int n)
        {
            for (int i = 0; i < n; i++)
            {
                o_n_fact(n - 1);
            }
        }


        //Others Algorithms
        //O(n ^ 2 log n) Algorithms
        public void O_n_power_2_Logn(int n)
        {
            int count = 0;
            for(int i=n/2;i<=n;i++)
            {
                for(int j=1;j+n/2 <=n;j++)
                {
                    for(int k=1;k<=n;k=k*2)
                    {
                        count++;
                    }
                }
            }
        }

       

       




    }
}
