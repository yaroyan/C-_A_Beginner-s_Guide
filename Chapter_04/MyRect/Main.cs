/*

p,156 12.
11のクラスを使って四角形の面積を求める。

*/


using System;

class main {
    static void Main() {
        MyRect rect = new MyRect(50,30);
        int r = rect.Area();
        Console.WriteLine(r);
    }
}