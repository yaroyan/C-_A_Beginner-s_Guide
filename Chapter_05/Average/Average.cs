/*

p,198 6.
10個のdouble型の数値の平均値を求める。

*/

using System;

class Average {
    static void Main () {
        double[] nums = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.1 };
        double sum = 0;

        foreach (double val in nums) {
            sum += val;
        }

        Console.WriteLine ("Average : " + sum / nums.Length);
    }
}