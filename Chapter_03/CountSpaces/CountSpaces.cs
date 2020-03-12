/*

p,121 1.
スペースをカウントする。

*/

using System;

class CountSpaces {
    static void Main () {
        int spaces = 0;
        char ch;

        Console.WriteLine ("Enter a period to stop.");

        do {
            ch = (char) Console.Read ();
            if (ch == ' ') spaces++;
        } while (ch != '.');

        Console.WriteLine ("spaces : " + spaces);
    }
}