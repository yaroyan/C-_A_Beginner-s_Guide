/*

p,122 11.
小文字と大文字の双方向の変換。

*/

using System;

class ChangeChar {
    static void Main () {
        int changes = 0;
        char ch;

        Console.WriteLine ("Enter period to stop.");

        do {
            ch = (char) Console.Read ();
            if (ch >= 'a' && ch <= 'z') {
                ch -= (char) 32;
                changes++;
                Console.WriteLine (ch);
            } else if (ch >= 'A' && ch <= 'Z') {
                ch += (char) 32;
                changes++;
                Console.WriteLine (ch);
            }
        } while (ch != '.');

        Console.WriteLine ("changes : " + changes);

    }
}