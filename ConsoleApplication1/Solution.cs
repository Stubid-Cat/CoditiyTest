using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Solution
    {
        //public int solution(int[] A)
        //{
        //    Array.Sort(A);

        //    if (A.First() > 1)
        //    {
        //        return 1;
        //    }

        //    int result = A.Last() + 1;
        //    if (result < 1 || result > 1000000)
        //    {
        //        result = 1;
        //    }

        //    for (int i = 0; i < A.Length-1; i++)
        //    {
        //        if (A[i] > 0 && A[i] <= 1000000)
        //        {
        //            int next = i + 1;
        //            if (A[i] == A[next] || A[i] + 1 == A[next])
        //            {

        //                continue;
        //            }
        //            else
        //            {
        //                result = A[i] + 1;
        //                break;
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public int solution(int N)
        //{
        //    int result = 0;

        //    string binary = Convert.ToString(N, 2);

        //    //Console.WriteLine(binary);

        //    binary = binary.Trim('0');

        //    string[] splits = binary.Split(new[] { '1' });

        //    foreach(string segment in splits)
        //    {
        //        if (segment.Length > result)
        //        {
        //            result = segment.Length;
        //        }
        //    }

        //    //Console.WriteLine(result);
        //    return result;

        //}

        //public int[] solution(int[] A, int K)
        //{
        //    if (!A.Any())
        //    {
        //        return A;
        //    }

        //    Queue<int> que = new Queue<int>(A.Reverse());
        //    this.print(que);

        //    for (int i =0; i < K; i++)
        //    {
        //        int firstInLine = que.Dequeue();
        //        que.Enqueue(firstInLine);
        //        this.print(que);
        //    }

        //    que.Reverse();

        //    return que.Reverse().ToArray();
        //}


        //private void print(Queue<int> que)
        //{
        //    string queContent = "";
        //    foreach (int item in que)
        //    {
        //        queContent += item + " ";
        //    }

        //    Console.WriteLine(queContent);
        //}

        //public int solution(int[] A)
        //{
        //    int oddOneOute = 0;

        //    Array.Sort(A);

        //    for (int i = 0; i < A.Length-1; i++)
        //    {
        //        if (A[i] != A[i + 1])
        //        {
        //            oddOneOute = A[i];
        //            break;
        //        }

        //        i++;
        //    }

        //    if (oddOneOute == 0)
        //    {
        //        oddOneOute = A.Last();
        //    }

        //    return oddOneOute;
        //}

        //public int solution(int[] A)
        //{
        //    int missingNumber = 1;

        //    if (A.Any())
        //    {
        //        if (A.Length == 1)
        //        {
        //            if (A[0] == 1)
        //            {
        //                missingNumber = A[0] + 1;
        //            }
        //            else
        //            {
        //                missingNumber = A[0] - 1;
        //            }
        //        }

        //        else
        //        {
        //            Array.Sort(A);

        //            bool found = false;

        //            for (int i = 0; i < A.Length - 1; i++)
        //            {
        //                if (A[i] != A[i + 1] - 1)
        //                {
        //                    missingNumber = A[i] + 1;
        //                    found = true;
        //                    break;
        //                }
        //            }

        //            if (!found)
        //            {
        //                if (A[0] == 1)
        //                {
        //                    missingNumber = A[A.Length - 1] + 1;
        //                }
        //                else
        //                {
        //                    missingNumber = A[0] - 1;
        //                }
        //            }
        //        }


        //    }

        //    return missingNumber;
        //}

        //public int solution(int X, int Y, int D)
        //{
        //    int result = 0;

        //    Y = Y - X;
        //    X = 0;

        //    Double jumps = (Double)Y / D;

        //    result = (int)Math.Ceiling(jumps);


        //    return result;
        //}

        //public int solution(int[] A)
        //{
        //    int i;
        //    int result = 0;
        //    int c = 0;
        //    int leftsum;
        //    int rightsum;
        //    int absdiff;
        //    int totalSum = A.Sum();
        //    int[] b = new int[A.Length - 1];

        //    for (i = 0; i < A.Length - 1; i++)
        //    {
        //        c = c + A[i];
        //        leftsum = c;
        //        rightsum = totalSum - leftsum;
        //        absdiff = Math.Abs(leftsum - rightsum);
        //        b[i] = absdiff;
        //    }
        //    result = b.Min();
        //    return result;
        //}

        //public int solution(int[] A)
        //{
        //    int result = 1;

        //    if (A.Length > 1)
        //    {
        //        Array.Sort(A);

        //        for (int i = 0; i < A.Length - 1; i++)
        //        {
        //            if (A[i] != A[i + 1] - 1)
        //            {
        //                result = 0;
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        result = 1;
        //    }

        //    return result;
        //}

        //public int solution(int[] A)
        //{
        //    // -5, -3, -1, 0, 3, 6
        //    int matches = 0;
        //    int leftPointer = 0;
        //    int rightPointer = A.Length - 1;
        //    float? previousValue = null; 

        //    float leftValue = Math.Abs((float)A[leftPointer]);
        //    float rightValue = Math.Abs((float)A[rightPointer]);

        //    while (leftPointer < rightPointer)
        //    {
        //        leftValue = Math.Abs((float)A[leftPointer]);
        //        rightValue = Math.Abs((float)A[rightPointer]);

        //        if (leftValue > rightValue)
        //        {
        //            if (previousValue.HasValue && leftValue == previousValue.Value)
        //            {
        //                matches++;
        //            }

        //            previousValue = leftValue;
        //            leftPointer++;
        //        }
        //        else if (leftValue < rightValue)
        //        {
        //            if (previousValue.HasValue && rightValue == previousValue.Value)
        //            {
        //                matches++;
        //            }

        //            previousValue = rightValue;
        //            rightPointer--;

        //        }
        //        else
        //        {
        //            leftPointer++;
        //            matches++;
        //        }
        //    }

        //    return A.Length - matches;

        //}

        //public int solution(int[] A)
        //{
        //    Array.Sort(A);

        //    int result = A[A.Length -1] +1;

        //    int indexOfFirstPositive = 0;

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (A[i] > 0)
        //        {
        //            indexOfFirstPositive = i;
        //            break;
        //        }
        //    }

        //    if (A[indexOfFirstPositive] != 1)
        //    {
        //        result = 1;
        //    }
        //    else
        //    {
        //        for (int i = indexOfFirstPositive; i < A.Length - 1; i++)
        //        {
        //            if (A[i] == A[i + 1] || A[i] == A[i + 1] - 1)
        //            {
        //                continue;
        //            }

        //            result = A[i] + 1;

        //        }
        //    }

        //    return result;
        //}

        //public int solution(int[] A)
        //{
        //    int result = 0;

        //    if(A.Any())
        //    {
        //        int heads = 0;
        //        int tails = 0;

        //        foreach (int i in A)
        //        {
        //            if (i == 1)
        //            {
        //                heads++;
        //            }
        //            else
        //            {
        //                tails++;
        //            }
        //        }

        //        if (tails < heads)
        //        {
        //            result = tails;
        //        }
        //        else
        //        {
        //            result = heads;
        //        }
        //    }

        //    return result;
        //}

        //public void solution(int N)
        //{
        //    const string div2 = "Codility";
        //    const string div3 = "Test";
        //    const string div5 = "Coders";


        //    for (int i = 1; i <= N; i++)
        //    {
        //        bool divisible = false;
        //        if (i%2 == 0)
        //        {
        //            Console.Write(div2);
        //            divisible = true;
        //        }

        //        if (i%3 == 0)
        //        {
        //            Console.Write(div3);
        //            divisible = true;
        //        }

        //        if (i%5 == 0)
        //        {
        //            Console.Write(div5);
        //            divisible = true;
        //        }

        //        if (!divisible)
        //        {
        //            Console.Write(i);
        //        }

        //        Console.WriteLine();
        //    }
        //}

        //public int solution(int A, int B)
        //{
        //    int result = 0;

        //    string full = B.ToString();
        //    string sub = A.ToString();

        //    if (sub.Length > full.Length)
        //    {
        //        result = -1;
        //    }

        //    result = full.IndexOf(sub);

        //    return result;
        //}

        public int solution(Tree T)
        {
            int result = findVisible(T);


            return result;
        }

        public int maxHeight(Tree T)
        {
            int treeLeftLenght = 0;
            int treeRightLength = 0;

            if (T.l != null)
            {
                treeLeftLenght = 1 + maxHeight(T.l);
            }
            if (T.r != null)
            {
                treeRightLength = 1 + maxHeight(T.r);
            }

            return Math.Max(treeLeftLenght, treeRightLength);
        }

        public int findVisible(Tree T, int sum = 0)
        {
            int count = 0;

            if(T.x > sum)
            {
                count++;
            }

            if (T.l != null)
            {
                count += findVisible(T.l, sum + T.x);
            }
            if (T.r != null)
            {
                count += findVisible(T.r, sum + T.x);
            }

            return count;
        }
    }

    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };
}
