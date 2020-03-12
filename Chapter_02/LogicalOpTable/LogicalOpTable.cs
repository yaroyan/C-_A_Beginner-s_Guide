/*

p,86 12.
論理演算子の真偽表を出力する（逐語的文字列リテラルVer）

*/

using System;

class LogicalOpTable {
    static void Main () {
        bool p, q;

        Console.WriteLine (@"P     Q     AND   OR    XOR   NOT");

        p = true;
        q = true;
        Console.WriteLine (@"{0} {1} {2} {3} {4} {5}", p, q, (p & q), (p | q), (p ^ q), (!p));

        p = true;
        q = false;
        Console.WriteLine (@"{0} {1} {2} {3} {4} {5}", p, q, (p & q), (p | q), (p ^ q), (!p));

        p = false;
        q = true;
        Console.WriteLine (@"{0} {1} {2} {3} {4} {5}", p, q, (p & q), (p | q), (p ^ q), (!p));

        p = false;
        q = false;
        Console.WriteLine (@"{0} {1} {2} {3} {4} {5}", p, q, (p & q), (p | q), (p ^ q), (!p));
    }
}