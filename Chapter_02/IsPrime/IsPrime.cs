/*

p,86 11.
2から100までの範囲内で素数を求める。

*/

using System;

class Prime {
    static void Main () {
        for(int i=0;i<=100;i++) {
            if(IsPrime(i)) Console.WriteLine(i + " is prime.");
            else Console.WriteLine(i + " is not prime.");
        }
    }
    static bool IsPrime (int num) {
        if (num < 2) return false;
        else if (num == 2) return true;
        else if (num % 2 == 0) return false;

        double sqrtnum = Math.Sqrt (num);

        for (int i = 3; i <= sqrtnum; i += 2) {
            if (num % i == 0) return false;

        }

        return true;

    }
}