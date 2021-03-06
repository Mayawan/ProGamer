using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowniePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int gamer = int.Parse(Console.ReadLine());
                if (gamer == 0)
                {
                    return;
                }
                List<List<int>> bPoints = new List<List<int>>();
                int numPoints = 0;
                while (numPoints < gamer)
                {
                    string[] input2 = Console.ReadLine().Split(' ');
                    List<int> point = new List<int>();
                    point.Add(int.Parse(input2[0]));
                    point.Add(int.Parse(input2[1]));
                    bPoints.Add(point);
                    numPoints++;
                }
                
                int a = 0;
                int notIncluded = 0;
                List<int> midpoint = bPoints[(numPoints - 1) / 2];
                for (int i = 0; i < numPoints; i++)
                {
                    if (((bPoints[i][0] > midpoint[0]) && (bPoints[i][1] > midpoint[1])) ||
                        ((bPoints[i][0] < midpoint[0]) && (bPoints[i][1] < midpoint[1])))
                    {
                        a++;
                    }
                    else if (bPoints[i][0] == midpoint[0])
                    {
                        notIncluded++;
                    }
                    else if (bPoints[i][1] == midpoint[1])
                    {
                        notIncluded++;
                    }
                }
                int b = numPoints - a - notIncluded;
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
