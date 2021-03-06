using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Persistent
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Start:
                BigInteger input =  BigInteger.Parse(Console.ReadLine());
                if(input < -1)
                {
                    Console.WriteLine("There is no such number.");
                    goto Start;
                }
                if (input == -1)
                {
                    return;
                }
                if (input < 10)
                {
                    input = input + 10;
                    Console.WriteLine(input);
                }
                else
                {
                    bool division = false;
                    Dictionary<int, int> digits = new Dictionary<int, int>();

                    digits.Add(2, 0);
                    digits.Add(3, 0);
                    digits.Add(5, 0);
                    digits.Add(7, 0);
                    digits.Add(4, 0);
                    digits.Add(6, 0);
                    digits.Add(8, 0);
                    digits.Add(9, 0);

                    while (!division)
                    {
                        List<int> primeDigits = new List<int> { 2, 3, 5, 7 };
                        bool divisionsucc = false;
                        while (!divisionsucc)
                        {
                            int wrong = 0;
                            for(int i = 0; i < primeDigits.Count; i++)
                            {
                                if(input % primeDigits[i] == 0)
                                {
                                    input = input / primeDigits[i];
                                    digits[primeDigits[i]]++;
                                }
                                else
                                {
                                    wrong++;
                                }
                            }
                            divisionsucc = true;
                            if (wrong == primeDigits.Count)
                            {
                                if (input > 10)
                                {
                                    Console.WriteLine("There is no such number.");
                                    goto Start;
                                }
                                else
                                {
                                    if(!(input == 1))
                                    {
										int gamer = (int)(input);
                                        digits[gamer]++;
                                    }
                                    division = true;
                                    
                                }
                            }
                        }
                    }
		    
                    digits[9] = digits[3]/2;
                    digits[3] -= 2 * digits[9];
                    digits[8] = digits[2] / 3;
                    digits[2] -= 3 * digits[8];
                    int ga = Math.Min(digits[2], digits[3]);
                    digits[6] = ga;
                    digits[2] -= ga;
                    digits[3] -= ga;
                    digits[4] = digits[2] / 2;
                    digits[2] -= 2 * digits[4];
                    int[] keys = digits.Keys.ToArray();
                    Array.Sort(keys);
                    string display = "";
                    for(int i = 2; i < digits.Count + 2; i++)
                    {
                        for(int j = 0; j < digits[i]; j++)
                        {
                            
                            display += keys[i-2];
                        }
                    }
                    Console.WriteLine(display);
                }
            }
        }
    }
}
