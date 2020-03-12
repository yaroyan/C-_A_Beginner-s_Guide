/*

p,122 10.
1,2,4,8,16,32...

*/

using System;

class Progress {
    static void Main () {
        for (int i = 1; i < 100; i += i) {
            Console.WriteLine (i);
        }
    }
}