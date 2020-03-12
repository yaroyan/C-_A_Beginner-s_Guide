/*

p,243 4.
2つの値を交換する

*/

using System;

class main {
    static void Main () {
        Test ob1 = new Test (1);
        Test ob2 = new Test (2);

        Console.WriteLine ("ob1: " + ob1.a + " ob2: " + ob2.a);

        Test.swap (ob1, ob2);

        Console.WriteLine ("ob1: " + ob1.a + " ob2: " + ob2.a);

    }

}

class Test {
    public int a;
    public Test (int i) { a = i; }

    //スワップメソッド
    public static void swap (Test ob1, Test ob2) {
        int t;

        t = ob1.a;
        ob1.a = ob2.a;
        ob2.a = t;
    }
}