/*

p,198 7.
stringの配列をバブルソート

*/

using System;

class Bubble {
    static void Main () {
        string[] strs = { "This", "is ", "a", "pen" };
        int a, b;
        string t;
        int size = strs.Length; //ソート対象の要素数

        //ソート前の配列要素を表示
        Console.Write ("Original array is : ");
        for (int i = 0; i < size; i++) Console.Write (" " + strs[i]);
        Console.WriteLine ();

        //バブルソート
        for (a = 1; a < size; a++) {
            for (b = size - 1; b >= a; b--) {
                if (strs[b - 1].CompareTo (strs[b]) > 0) {
                    //もし、大小関係が逆ならば、要素の交換
                    t = strs[b - 1];
                    strs[b - 1] = strs[b];
                    strs[b] = t;
                }
            }
        }

        //ソート後の要素を表示
        Console.Write ("Sorted array is : ");
        for (int i = 0; i < size; i++) Console.Write (" " + strs[i]);
        Console.WriteLine ();
    }
}