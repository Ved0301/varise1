using System;
class trailzero
{
    static void Main(string args[])
    {
        Console.WriteLine("enter n to calculate factorial");
        int n=Convert.ToInt32(Console.ReadLine());
        int tzero=countTrailing(n);
        Console.WriteLine("Trailing zeroes="+tzero);
    }
    static int countTrailing(int n)
    {
        int fact=1;
        int count=0;
        for(int i=1;i<=n;i++)
        {
            fact=fact*i;

        }
        while(fact%10==0)
        {
            count++;
            fact/=10;

        }
        return count; 
    }
}