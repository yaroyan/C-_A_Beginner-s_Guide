/*

p,243 3.

*/

using System;

//文字用のスタッククラス
class Stack {
    char[] stack; //この配列をスタックのデータ本体にする。
    int tos; //スタックトップを表す添え字（次に積むべき空き位置）

    //サイズを指定して空のスタックを作る
    public Stack (int size) {
        stack = new char[size]; //スタック用のメモリを確保する
        tos = 0;
    }

    //与えられたスタックから新しいスタックを作る
    public Stack (Stack ob) {
        tos = ob.tos;
        stack = new char[ob.stack.Length];

        //要素のコピー
        for (int i = 0; i < tos; i++) {
            stack[i] = ob.stack[i];
        }
    }

    //char型配列を初期値としてスタックを作る
    public Stack (char[] a) {
        stack = new char[a.Length];

        for (int i = 0; i < a.Length; i++) {
            Push (a[i]);
        }
    }

    //スタックに文字を積む
    public void Push (char ch) {
        if (tos == stack.Length) {
            Console.WriteLine (" -- Stack is full.");
            return;
        }

        stack[tos] = ch;
        tos++;
    }

    //スタックから文字を取り出す
    public char Pop () {
        if (tos == 0) {
            Console.WriteLine (" -- Stack is empty.");
            return (char) 0;
        }

        tos--;
        return stack[tos];
    }

}

//Stackクラスを使用する

class SDemo {
    static void Main () {
        //10個の要素を持つことができる空のスタック作成
        Stack stk1 = new Stack (10);

        char[] name = { 'T', 'o', 'm' };

        //配列からスタックを作成する
        Stack stk2 = new Stack (name);

        char ch;
        int i;

        //stk1に何文字か追加する
        for (i = 0; i < 10; i++) stk1.Push ((char) ('A' + i));

        //スタックから別のスタックを作成する
        Stack stk3 = new Stack (stk1);

        //スタックを示す
        Console.Write ("Contents of stk1: ");
        for (i = 0; i < 10; i++) {
            ch = stk1.Pop ();
            Console.Write (ch);
        }

        Console.WriteLine ();

        Console.Write ("Contents of stk2: ");
        for (i = 0; i < 3; i++) {
            ch = stk2.Pop ();
            Console.Write (ch);
        }

        Console.WriteLine ();

        Console.Write ("Contents of stk3: ");
        for (i = 0; i < 10; i++) {
            ch = stk3.Pop ();
            Console.Write (ch);
        }

        Console.WriteLine ();
    }
}