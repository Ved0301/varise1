using System;

class minwins
{
    static void Main()
    {
        Console.WriteLine("Enter the points required to qualify:");
        int ptsreq= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of matches:");
        int nmatch = Convert.ToInt32(Console.ReadLine());

        int minWins = CalculateMinWins(ptsreq,nmatch);

        Console.WriteLine("Minimum number of wins required to qualify: " + minWins);
    }

    static int CalculateMinWins(int ptsreq, int nmatch)
    {
        int maxpts=nmatch*2;
        int min=(ptsreq - (nmatch * 1)) / 2;
        return Math.Max(min, 0);
     }
 }