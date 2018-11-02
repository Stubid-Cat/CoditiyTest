using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution test = new Solution();
            //test.solution(new int[] { -2, -5, 1, 3, 6, 4, 1, 2, 5, 22, 4, 15, 7 });

            //test.solution(new int[]{ 3, 8, 9, 7, 6 } , 3);
            //Console.WriteLine();
            //test.solution(new int[] {0,0,0}, 1);
            //Console.WriteLine();
            //test.solution(new int[] { 1,2,3,4 }, 4);

            //test.solution(new int[] {-7,-6 -5, -3, -1, 0, 3, 6});

            //test.solution(new int[] { -1, -3, 1, 3, 6, 4, 1, 2 });
            //test.solution(new int[] { -1, -3, 3, 6, 4, 2 });
            //test.solution(new int[] { 1,1,2,3,3}, 4);

            Tree t = new Tree();
            t.x = 0;
            t.l = new Tree()
            {
                x = 1,
                l = new Tree()
                {
                    x = 2,
                    l = null,
                    r = null,
                },
                r = new Tree()
                {
                    x = 5,
                    l = null,
                    r = null,
                }
            };
            t.r = new Tree()
            {
                x = 1,
                l = new Tree()
                {
                    x = 7,
                    l = null,
                    r = null,
                },
                r = new Tree()
                {
                    x = 1,
                    l = new Tree()
                    {
                        x = 9,
                        l = null,
                        r = null,
                    },
                    r = null,
                }
            };

            test.solution(t);

            Console.ReadLine();
        }
    }
}
