/*

p,361 7.

*/

using System;

public interface IFailSoft {
    int Length { get; }
    int this [int index] { get; set; }
}

class FailSoftArray : IFailSoft {
    int[] a; //配列への参照
    public bool ErrorFlag; //直前の操作の結果を表すフラグ

    //自動実装するプロパティ、実質的に読み取り専用
    public int Length { get; private set; }

    //サイズを指定して配列を作る
    public FailSoftArray (int size) {
        a = new int[size];
        Length = size;
    }

    //FailSoftArrayオブジェクトのためのインデクサー
    public int this [int index] {

        //getアクセサー
        get {
            if (ok (index)) {
                ErrorFlag = false;
                return a[index];
            } else {
                ErrorFlag = true;
                return 0;
            }
        }

        //setアクセサー
        set {
            if (ok (index)) {
                a[index] = value;
                ErrorFlag = false;
            } else ErrorFlag = true;
        }
    }

    //インデックスが配列の上限・下限の範囲内ならtrueを返す
    private bool ok (int index) {
        if (index >= 0 & index < Length) return true;
        return false;
    }
}

//自動実装されたLengthプロパティを使用する
class ImprovedFSDemo2 {
    static void Main () {
        FailSoftArray fs = new FailSoftArray (5);
        int x;

        //Lengthを読み取ることができる
        for (int i = 0; i < fs.Length; i++) fs[i] = i * 10;

        for (int i = 0; i < fs.Length; i++) {
            x = fs[i];
            if (x != -1) Console.Write (x + " ");
        }
        Console.WriteLine ();
    }
}