using System;

namespace ConsoleApp1;

public class Task4
{
    static void Main()
    {
        string nums = "MCMXCIV";
        int total = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            // if (nums[i] == 'I' && nums[i + 1] == 'V')
            // {
            //     total += 4
            // }
            if (nums[i] == 'I')
            {
                if (i < nums.Length - 1 && nums[i + 1] == 'V')
                {
                    total += 4;
                    i++;
                }
                else if (i < nums.Length - 1 && nums[i + 1] == 'X')
                {
                    total += 9;
                    i++;
                }
                else
                {
                    total += 1;
                }
            }
            else if (nums[i] == 'V')
            {
                total += 5;
            }
            else if (nums[i] == 'X')
            {
                if (i < nums.Length - 1 && nums[i + 1] == 'L')
                {
                    total += 40;
                    i++;
                }
                else if (i < nums.Length - 1 && nums[i + 1] == 'C')
                {
                    total += 90;
                    i++;
                }
                else
                {
                    total += 10;
                }
            }
            else if (nums[i] == 'L')
            {
                total += 50;
            }
            else if (nums[i] == 'C')
            {
                if (i < nums.Length - 1 && nums[i + 1] == 'D')
                {
                    total += 400;
                    i++;
                }
                else if (i < nums.Length && nums[i + 1] == 'M')
                {
                    total += 900;
                    i++;
                }
                else
                {
                    total += 100;
                }
            }
            else if (nums[i] == 'D')
            {
                total += 500;
            }
            else if (nums[i] == 'M')
            {
                total += 1000;
            }
        }
        Console.WriteLine(total);
    }
}