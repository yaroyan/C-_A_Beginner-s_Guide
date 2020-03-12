/*

p,244 6.
再帰的なメソッド呼び出しを利用して、文字列を逆順に表示する

*/

using System;

class Backwards {
    string str;

    public Backwards (string s) {
        str = s;
    }

    //Backward()メソッドへ、idxの位置にある文字を表示するよう依頼する
    public void Backward (int idx) {
        //idxが末尾でなければ、1文字後ろの文字(idx+1)を先に表示するよう依頼する
        if (idx != str.Length - 1) Backward (idx + 1);
        //前述の呼び出しで後ろの文字が表示されたので、idx指定された文字を表示する
        Console.Write (str[idx]);
    }
}

class BWDemo {
    static void Main () {
        Backwards s = new Backwards ("This is a test");
        s.Backward (0);
    }
}